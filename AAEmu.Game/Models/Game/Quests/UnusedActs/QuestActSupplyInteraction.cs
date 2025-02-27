﻿using AAEmu.Game.Models.Game.Quests.Templates;
using AAEmu.Game.Models.Game.World;

#pragma warning disable IDE0130 // Namespace does not match folder structure

namespace AAEmu.Game.Models.Game.Quests.Acts;

/// <summary>
/// Not actively used
/// </summary>
/// <param name="parentComponent"></param>
public class QuestActSupplyInteraction(QuestComponentTemplate parentComponent) : QuestActTemplate(parentComponent)
{
    public WorldInteractionType WiId { get; set; }

    public override bool RunAct(Quest quest, QuestAct questAct, int currentObjectiveCount)
    {
        return base.RunAct(quest, questAct, currentObjectiveCount);
    }
}
