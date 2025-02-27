﻿using System.Linq;
using AAEmu.Game.Core.Managers.World;
using AAEmu.Game.Models.Game.Char;
using AAEmu.Game.Models.Game.NPChar;
using AAEmu.Game.Models.Game.Quests.Templates;

#pragma warning disable IDE0130 // Namespace does not match folder structure

namespace AAEmu.Game.Models.Game.Quests.Acts;

/// <summary>
/// Does not seem to be used anymore in any active quests
/// </summary>
/// <param name="parentComponent"></param>
public class QuestActCheckDistance(QuestComponentTemplate parentComponent) : QuestActTemplate(parentComponent)
{
    public bool WithIn { get; set; }
    public uint NpcId { get; set; }
    public int Distance { get; set; }

    /// <summary>
    /// Checks if the player is within a given distance of a target NPC type
    /// </summary>
    /// <param name="quest"></param>
    /// <param name="questAct"></param>
    /// <param name="currentObjectiveCount"></param>
    /// <returns></returns>
    public override bool RunAct(Quest quest, QuestAct questAct, int currentObjectiveCount)
    {
        Logger.Error($"{QuestActTemplateName}({DetailId}).RunAct: Quest {quest.TemplateId}, Owner {quest.Owner.Name} ({quest.Owner.Id}), WithIn {WithIn}, NpcId {NpcId}, Distance {Distance}");
        // There is actually no quest left that still uses this
        var player = quest.Owner as Character;
        var npcs = WorldManager.GetAround<Npc>(player, Distance);
        return npcs.Any(x => (x.TemplateId == NpcId) && (x.GetDistanceTo(player, true) <= Distance));
    }
}
