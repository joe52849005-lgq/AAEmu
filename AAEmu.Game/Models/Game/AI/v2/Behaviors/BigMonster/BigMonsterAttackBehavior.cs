﻿using System;
using System.Collections.Generic;
using System.Linq;

using AAEmu.Commons.Utils;
using AAEmu.Game.Core.Managers;
using AAEmu.Game.Core.Packets.G2C;
using AAEmu.Game.Models.Game.AI.v2.Params.BigMonster;
using AAEmu.Game.Models.Game.AI.V2.Params.BigMonster;
using AAEmu.Game.Models.Game.Models;
using AAEmu.Game.Models.Game.Skills;
using AAEmu.Game.Models.Game.Skills.Static;
using AAEmu.Game.Models.Game.Units;
using AAEmu.Game.Models.Game.Units.Movements;

namespace AAEmu.Game.Models.Game.AI.v2.Behaviors.BigMonster;

public class BigMonsterAttackBehavior : BaseCombatBehavior
{
    private bool _enter;

    public override void Enter()
    {
        Ai.Owner.InterruptSkills();
        Ai.Owner.CurrentGameStance = GameStanceType.Combat;
        Ai.Owner.CurrentAlertness = MoveTypeAlertness.Combat;
        Ai.Owner.BroadcastPacket(new SCUnitModelPostureChangedPacket(Ai.Owner, Ai.Owner.AnimActionId, false), false);

        Ai.Owner.IsInBattle = true;
        if (Ai.Owner is { } npc)
        {
            npc.Events.OnCombatStarted(this, new OnCombatStartedArgs { Owner = npc, Target = npc });
        }
        Ai.Param = Ai.Owner.Template.AiParams;
        _enter = true;
    }

    public override void Tick(TimeSpan delta)
    {
        if (!_enter)
            return; // not initialized yet Enter()

        Ai.Param ??= new BigMonsterAiParams("");

        if (Ai.Param is not BigMonsterAiParams aiParams)
            return;

        if (!UpdateTarget() || ShouldReturn)
        {
            Ai.OnNoAggroTarget();
            return;
        }

        if (CanStrafe && !IsUsingSkill)
            MoveInRange(Ai.Owner.CurrentTarget, delta);

        if (!CanUseSkill)
            return;

        _strafeDuringDelay = false;

        #region Pick a skill

        // TODO: Get skill list
        var targetDist = Ai.Owner.GetDistanceTo(Ai.Owner.CurrentTarget);
        var selectedSkill = PickSkill(RequestAvailableSkills(aiParams, targetDist));
        if (selectedSkill == null)
        {
            // If skill list is empty, get Base skill
            PickSkillAndUseIt(SkillUseConditionKind.InCombat, Ai.Owner.CurrentTarget, targetDist);
            return;
        }

        var skillTemplate = SkillManager.Instance.GetSkillTemplate(selectedSkill.SkillType);
        if (skillTemplate == null)
            return;

        UseSkill(new Skill(skillTemplate), Ai.Owner.CurrentTarget, selectedSkill.SkillDelay);
        _strafeDuringDelay = selectedSkill.StrafeDuringDelay;

        #endregion
    }

    public override void Exit()
    {
        // Clear combat state here
        _enter = false;
    }

    private List<BigMonsterCombatSkill> RequestAvailableSkills(BigMonsterAiParams aiParams, float trgDist)
    {
        var healthRatio = (int)((float)Ai.Owner.Hp / Ai.Owner.MaxHp * 100);

        var baseList = aiParams.CombatSkills.AsEnumerable();

        baseList = baseList.Where(s => s.HealthRangeMin <= healthRatio && healthRatio <= s.HealthRangeMax);
        baseList = baseList.Where(s => !Ai.Owner.Cooldowns.CheckCooldown(s.SkillType));
        baseList = baseList.Where(s =>
        {
            var template = SkillManager.Instance.GetSkillTemplate(s.SkillType);
            return (template != null && (trgDist >= template.MinRange && trgDist <= template.MaxRange || template.TargetType == SkillTargetType.Self));
        });

        return baseList.ToList();
    }

    private BigMonsterCombatSkill PickSkill(List<BigMonsterCombatSkill> skills)
    {
        if (skills.Count > 0)
            return skills[Rand.Next(0, skills.Count)];

        if (!Ai.Owner.Cooldowns.CheckCooldown((uint)Ai.Owner.Template.BaseSkillId))
            return new BigMonsterCombatSkill
            {
                SkillType = (uint)Ai.Owner.Template.BaseSkillId,
                SkillDelay = Ai.Owner.Template.BaseSkillDelay,
                StrafeDuringDelay = Ai.Owner.Template.BaseSkillStrafe
            };

        return null;
    }
}
