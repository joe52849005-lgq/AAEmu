﻿namespace AAEmu.Game.Core.Packets.G2C;

public static class SCOffsets
{
    // All opcodes here are updated for version client_12_r208022
    public const ushort X2EnterWorldResponsePacket = 0x00;
    public const ushort SCReconnectAuthPacket = 0x01;
    public const ushort SCPrepareLeaveWorldPacket = 0x02;
    public const ushort SCLeaveWorldGrantedPacket = 0x03;
    public const ushort SCLeaveWorldCanceledPacket = 0x04;
    public const ushort SCWorldQueuePacket = 0x05;
    public const ushort SCInitialConfigPacket = 0x06;
    public const ushort SCTrionConfigPacket = 0x07;
    public const ushort SCFactionListPacket = 0x08;
    public const ushort SCFactionRelationListPacket = 0x09;
    public const ushort SCExpeditionRolePolicyListPacket = 0x0b;
    public const ushort SCExpeditionRolePolicyChangedPacket = 0x0c;
    public const ushort SCExpeditionRoleChangedPacket = 0x0d;
    public const ushort SCExpeditionOwnerChangedPacket = 0x0e;
    public const ushort SCExpeditionShowRenameUIPacket = 0x0f;
    public const ushort SCNationShowRenameUIPacket = 0x10;
    public const ushort SCFactionRenamedPacket = 0x11;
    public const ushort SCFactionRetryRenamePacket = 0x12;
    public const ushort SCFactionCreatedPacket = 0x13;
    public const ushort SCExpeditionSponsorChangedPacket = 0x14;
    public const ushort SCExpeditionDismissedPacket = 0x15;
    public const ushort SCExpeditionMemberListPacket = 0x16;
    public const ushort SCExpeditionMemberStatusChangedPacket = 0x17;
    public const ushort SCFactionOwnerChangedPacket = 0x18;
    public const ushort SCFactionSetRelationStatePacket = 0x19;
    public const ushort SCExpeditionInvitationPacket = 0x1a;
    public const ushort SCUnitFactionChangedPacket = 0x1b;
    public const ushort SCUnitExpeditionChangedPacket = 0x1c;
    public const ushort SCDominionDataPacket = 0x1d;
    public const ushort SCDominionDeletedPacket = 0x1e;
    public const ushort SCDominionOwnerChangedPacket = 0x1f;
    public const ushort SCDominionTaxRatePacket = 0x20;
    public const ushort SCNationalTaxRatePacket = 0x21;
    public const ushort SCNationalMonumentChangedPacket = 0x22;
    public const ushort SCDominionTaxBalancedPacket = 0x23;
    public const ushort CDominionStartUnkPacket = 0x24;
    public const ushort SCDominionEndUnkPacket = 0x25;
    public const ushort SCFactionIndependencePacket = 0x26;
    public const ushort SCFactionImmigrateInvitePacket = 0x27;
    public const ushort SCFactionImmigrateInviteResultPacket = 0x28;
    public const ushort SCFactionImmigrateToOriginResultPacket = 0x29;
    public const ushort SCFactionKickToOriginResultPacket = 0x2a;
    public const ushort SCFactionDeclareHostileResultPacket = 0x2b;
    public const ushort SCFactionRelationExpiredPacket = 0x2c;
    public const ushort SCFamilyInvitationPacket = 0x2d;
    public const ushort SCFamilyCreatedPacket = 0x2e;
    public const ushort SCFamilyRemovedPacket = 0x2f;
    public const ushort SCFamilyDescPacket = 0x30;
    public const ushort SCFamilyMemberAddedPacket = 0x31;
    public const ushort SCFamilyMemberRemovedPacket = 0x32;
    public const ushort SCFamilyOwnerChangedPacket = 0x33;
    public const ushort SCFamilyTitleChangedPacket = 0x34;
    public const ushort SCFamilyMemberNameChangedPacket = 0x35;
    public const ushort SCFamilyTitlePacket = 0x36;
    public const ushort SCFamilyMemberOnlinePacket = 0x37;
    public const ushort SCCreateCharacterResponsePacket = 0x38;
    public const ushort SCDeleteCharacterResponsePacket = 0x39;
    public const ushort SCEditCharacterResponsePacket = 0x3a;
    public const ushort SCCharacterDeletedPacket = 0x3b;
    public const ushort SCCancelCharacterDeleteResponsePacket = 0x3c;
    public const ushort SCCharacterCreationFailedPacket = 0x3d;
    public const ushort SCCharacterListPacket = 0x3e;
    public const ushort SCRaceCongestionPacket = 0x3f;
    public const ushort SCCharacterStatePacket = 0x40;
    public const ushort SCNotifyResurrectionPacket = 0x41;
    public const ushort SCCharacterResurrectedPacket = 0x42;
    public const ushort SCForceAttackSetPacket = 0x43;
    public const ushort SCCharacterLaborPowerChangedPacket = 0x45;
    public const ushort SCBmPointPacket = 0x46;
    public const ushort SCAddActionPointPacket = 0x47;
    public const ushort SCLpManagedPacket = 0x48;
    public const ushort SCCharacterBoundPacket = 0x49;
    public const ushort SCCooldownsPacket = 0x4a;
    public const ushort SCCharacterInvenInitPacket = 0x4b;
    public const ushort SCCharacterInvenContentsPacket = 0x4c;
    public const ushort SCInvenExpandedPacket = 0x4d;
    public const ushort SCFriendsPacket = 0x4e;
    public const ushort SCSearchListPacket = 0x4f;
    public const ushort SCAddFriendPacket = 0x50;
    public const ushort SCDeleteFriendPacket = 0x51;
    public const ushort SCFriendStatusChangedPacket = 0x52;
    public const ushort SCCharDetailPacket = 0x53;
    public const ushort SCBlockedUsersPacket = 0x54;
    public const ushort SCAddBlockedUserPacket = 0x55;
    public const ushort SCDeleteBlockedUserPacket = 0x56;
    public const ushort SCLoginCharInfoHousePacket = 0x57;
    public const ushort SCCharBriefPacket = 0x58;
    public const ushort SCPlaytimePacket = 0x59;
    public const ushort SCCharacterRenamedPacket = 0x5a;
    public const ushort SCCharacterPortalsPacket = 0x5b;
    public const ushort SCCharacterReturnDistrictsPacket = 0x5c;
    public const ushort SCPortalInfoSavedPacket = 0x5d;
    public const ushort SCPortalDeletedPacket = 0x5e;
    public const ushort SCUnitPortalUsedPacket = 0x60;
    public const ushort SCSlaveCreatedPacket = 0x61;
    public const ushort SCSlaveRemovedPacket = 0x62;
    public const ushort SCSlaveDespawnPacket = 0x63;
    public const ushort SCSlaveBoundPacket = 0x64;
    public const ushort SCQuestListPacket = 0x65;
    public const ushort SCMySlavePacket = 0x66;
    public const ushort SCEscapeSlavePacket = 0x67;
    public const ushort SCSlaveEquipmentChangedPacket = 0x68;
    public const ushort SCUnitStatePacket = 0x69;
    public const ushort SCUnitsRemovedPacket = 0x6a;
    public const ushort SCUnitMovementsPacket = 0x6b;
    public const ushort SCOneUnitMovementPacket = 0x6c;
    public const ushort SCSkillControllerStatePacket = 0x6d;
    public const ushort SCUnitOfflinePacket = 0x6e;
    public const ushort SCActiveWeaponChangedPacket = 0x6f;
    public const ushort SCUnitNameChangedPacket = 0x70;
    public const ushort SCUnitDeathPacket = 0x71;
    public const ushort SCTeleportUnitPacket = 0x72;
    public const ushort SCBlinkUnitPacket = 0x73;
    public const ushort SCKnockBackUnitPacket = 0x74;
    public const ushort SCUnitAttachedPacket = 0x76;
    public const ushort SCUnitDetachedPacket = 0x77;
    public const ushort SCUnitInvisiblePacket = 0x78;
    public const ushort SCUnitImpulsePacket = 0x79;
    public const ushort SCUnitFlyingStateChangedPacket = 0x7a;
    public const ushort SCNpcInteractionSkillListPacket = 0x7b;
    public const ushort SCNpcInteractionEndedByZonePacket = 0x7c;
    public const ushort SCWorldInteractionSkillListPacket = 0x7e;
    public const ushort SCWorldInteractionCanceledPacket = 0x7f;
    public const ushort SCNpcInteractionStatusChangedPacket = 0x80;
    public const ushort SCVegetationCutdowningPacket = 0x81;
    public const ushort SCNpcFriendshipListPacket = 0x82;
    public const ushort SCNpcFriendshipChangedPacket = 0x83;
    public const ushort SCTargetChangedPacket = 0x84;
    public const ushort SCCombatEngagedPacket = 0x85;
    public const ushort SCCombatClearedPacket = 0x86;
    public const ushort SCCvFCombatRelationshipPacket = 0x87;
    public const ushort SCFvFCombatRelationshipPacket = 0x88;
    public const ushort SCCombatFirstHitPacket = 0x89;
    public const ushort SCDumpCombatStatPacket = 0x8a;
    public const ushort SCDuelChallengedPacket = 0x8b;
    public const ushort SCDuelStartCountdownPacket = 0x8c;
    public const ushort SCDuelStartedPacket = 0x8d;
    public const ushort SCDuelEndedPacket = 0x8e;
    public const ushort SCDuelStatePacket = 0x8f;
    public const ushort SCItemTaskSuccessPacket = 0x90;
    public const ushort SCItemTaskNotifyPacket = 0x91;
    public const ushort SCItemDetailUpdatedPacket = 0x93;
    public const ushort SCUnitEquipmentsChangedPacket = 0x94;
    public const ushort SCUnitEquipmentIdsPacket = 0x95;
    public const ushort SCCofferContentsUpdatePacket = 0x96;
    public const ushort SCItemAcquisitionPacket = 0x97;
    public const ushort SCSyncItemLifespanPacket = 0x98;
    public const ushort SCSpecialtyRatioPacket = 0x99;
    public const ushort SCSpecialtyGoodsPacket = 0x9a;
    public const ushort SCSpecialtyRecordsPacket = 0x9b;
    public const ushort SCGradeEnchantResultPacket = 0x9c;
    public const ushort SCItemSocketingLunagemResultPacket = 0x9d;
    public const ushort SCItemSocketingLunastoneResultPacket = 0x9e;
    public const ushort SCGradeEnchantBroadcastPacket = 0x9f;
    public const ushort SCUnknownPacket = 0xa0;
    public const ushort SCSkillStartedPacket = 0xa1;
    public const ushort SCSkillFiredPacket = 0xa2;
    public const ushort SCSkillEndedPacket = 0xa3;
    public const ushort SCSkillStoppedPacket = 0xa4;
    public const ushort SCCastingStoppedPacket = 0xa5;
    public const ushort SCCastingDelayedPacket = 0xa6;
    public const ushort SCUnitDamagedPacket = 0xa7;
    public const ushort SCUnitHealedPacket = 0xa8;
    public const ushort SCUnitTrackedPacket = 0xa9;
    public const ushort SCBombUpdatedPacket = 0xaa;
    public const ushort SCCombatTextPacket = 0xab;
    public const ushort SCSkillCooldownResetPacket = 0xad;
    public const ushort SCPlotEventPacket = 0xae;
    public const ushort SCPlotEndedPacket = 0xaf;
    public const ushort SCPlotProcessingTimePacket = 0xb0;
    public const ushort SCPlotCastingStoppedPacket = 0xb1;
    public const ushort SCPlotChannelingStoppedPacket = 0xb2;
    public const ushort SCEnvDamagePacket = 0xb3;
    public const ushort SCOnOffSnowPacket = 0xb4;
    public const ushort SCUnkPacket = 0xb5;
    public const ushort SCBuffCreatedPacket = 0xb6;
    public const ushort SCBuffRemovedPacket = 0xb7;
    public const ushort SCBuffUpdatedPacket = 0xb9;
    public const ushort SCUnitPointsPacket = 0xba;
    public const ushort SCUnitBountyMoneyPacket = 0xbb;
    public const ushort SCHouseStatePacket = 0xbc;
    public const ushort SCHouseBuildProgressPacket = 0xbd;
    public const ushort SCHousePermissionChangedPacket = 0xbe;
    public const ushort SCHouseBuildPayChangedPacket = 0xbf;
    public const ushort SCHouseDemolishedPacket = 0xc0;
    public const ushort SCMyHousePacket = 0xc1;
    public const ushort SCMyHouseRemovedPacket = 0xc2;
    public const ushort SCHouseFarmPacket = 0xc3;
    public const ushort SCHouseTaxInfoPacket = 0xc4;
    public const ushort SCConstructHouseTaxPacket = 0xc5;
    public const ushort SCHousingRecoverTogglePacket = 0xc6;
    public const ushort SCHouseSetForSalePacket = 0xc8;
    public const ushort SCHouseResetForSalePacket = 0xc9;
    public const ushort SCHouseSoldPacket = 0xca;
    public const ushort SCHouseOwnerNameChangedPacket = 0xcb;
    public const ushort SCJoinedChatChannelPacket = 0xcc;
    public const ushort SCLeavedChatChannelPacket = 0xcd;
    public const ushort SCChatMessagePacket = 0xce;
    public const ushort SCNpcChatMessagePacket = 0xcf;
    public const ushort SCNoticeMessagePacket = 0xd0;
    public const ushort SCChatFailedPacket = 0xd1;
    public const ushort SCChatLocalizedMessagePacket = 0xd2;
    public const ushort SCChatSpamDelayPacket = 0xd3;
    public const ushort SCAskToJoinTeamPacket = 0xd4;
    public const ushort SCAskToJoinTeamAreaPacket = 0xd5;
    public const ushort SCJoinedTeamPacket = 0xd6;
    public const ushort SCRejectedTeamPacket = 0xd7;
    public const ushort SCLeavedTeamPacket = 0xd8;
    public const ushort SCTeamDismissedPacket = 0xd9;
    public const ushort SCTeamMemberJoinedPacket = 0xda;
    public const ushort SCTeamMemberLeavedPacket = 0xdb;
    public const ushort SCTeamMemberDisconnectedPacket = 0xdc;
    public const ushort SCTeamOwnerChangedPacket = 0xdd;
    public const ushort SCTeamMemberRoleChangedPacket = 0xde;
    public const ushort SCTeamBecameRaidTeamPacket = 0xdf;
    public const ushort SCTeamMemberMovedPacket = 0xe0;
    public const ushort SCTeamLootingRuleChangedPacket = 0xe2;
    public const ushort SCRefreshTeamMemberPacket = 0xe3;
    public const ushort SCTeamRemoteMembersExPacket = 0xe4;
    public const ushort SCTeamAreaInvitedPacket = 0xe5;
    public const ushort SCOverHeadMarkerSetPacket = 0xe6;
    public const ushort SCTeamPingPosPacket = 0xe7;
    public const ushort SCTeamAckRiskyActionPacket = 0xe8;
    public const ushort SCSiegeStatePacket = 0xe9;
    public const ushort SCSiegeDeclaredPacket = 0xea;
    public const ushort SCSiegeReinforcePacket = 0xeb;
    public const ushort SCSiegeMemberPacket = 0xec;
    public const ushort SCSiegeAlertPacket = 0xed;
    public const ushort SCConflictZoneStatePacket = 0xee;
    public const ushort SCConflictZoneHonorPointSumPacket = 0xef;
    public const ushort SCTimeOfDayPacket = 0xf0;
    public const ushort SCDetailedTimeOfDayPacket = 0xf1;
    public const ushort SCQuestsPacket = 0xf2;
    public const ushort SCCompletedQuestsPacket = 0xf3;
    public const ushort SCCraftItemUnlockPacket = 0xf5;
    public const ushort SCLootableStatePacket = 0xf6;
    public const ushort SCUnitLootingStatePacket = 0xf7;
    public const ushort SCLootBagDataPacket = 0xf8;
    public const ushort SCLootItemTookPacket = 0xf9;
    public const ushort SCLootItemFailedPacket = 0xfa;
    public const ushort SCLootDicePacket = 0xfb;
    public const ushort SCLootDiceNotifyPacket = 0xfc;
    public const ushort SCLootDiceSummaryPacket = 0xfd;
    public const ushort SCExpChangedPacket = 0xfe;
    public const ushort SCAbilityExpChangedPacket = 0xff;
    public const ushort SCRecoverableExpPacket = 0x100;
    public const ushort SCMileageChangedPacket = 0x101;
    public const ushort SCLevelChangedPacket = 0x102;
    public const ushort SCUnitModelPostureChangedPacket = 0x103;
    public const ushort SCSkillLearnedPacket = 0x105;
    public const ushort SCSkillUpgradedPacket = 0x106;
    public const ushort SCBuffLearnedPacket = 0x107;
    public const ushort SCSkillsResetPacket = 0x108;
    public const ushort SCAbilitySwappedPacket = 0x109;
    public const ushort SCErrorMsgPacket = 0x10a;
    public const ushort SCDoodadCreatedPacket = 0x10c;
    public const ushort SCDoodadRemovedPacket = 0x10d;
    public const ushort SCDoodadChangedPacket = 0x10e;
    public const ushort SCDoodadPhaseChangedPacket = 0x10f;
    public const ushort SCDoodadPuzzleScenePacket = 0x110;
    public const ushort SCDoodadQuestAcceptPacket = 0x111;
    public const ushort SCDoodadsCreatedPacket = 0x112;
    public const ushort SCDoodadsRemovedPacket = 0x113;
    public const ushort SCDoodadOriginatorPacket = 0x114;
    public const ushort SCMailFailedPacket = 0x115;
    public const ushort SCCountUnreadMailPacket = 0x116;
    public const ushort SCMailSentPacket = 0x117;
    public const ushort SCGotMailPacket = 0x118;
    public const ushort SCMailListPacket = 0x119;
    public const ushort SCMailListEndPacket = 0x11a;
    public const ushort SCMailBodyPacket = 0x11b;
    public const ushort SCMailReceiverOpenedPacket = 0x11c;
    public const ushort SCAttachmentTakenPacket = 0x11d;
    public const ushort SCChargeMoneyPaidPacket = 0x11e;
    public const ushort SCMailDeletedPacket = 0x11f;
    public const ushort SCSpamReportedPacket = 0x120;
    public const ushort SCMailReturnedPacket = 0x121;
    public const ushort SCMailStatusUpdatedPacket = 0x122;
    public const ushort SCMailRemovedPacket = 0x123;
    public const ushort SCMineAmountPacket = 0x124;
    public const ushort SCMateSpawnedPacket = 0x125;
    public const ushort SCMateEquipmentChangedPacket = 0x126;
    public const ushort SCMateEquipmentExpiredPacket = 0x127;
    public const ushort SCUnkPacket4 = 0x128;
    public const ushort SCEmotionExpressedPacket = 0x12b;
    public const ushort SCSoldItemListPacket = 0x12c;
    public const ushort SCActionSlotsPacket = 0x12d;
    public const ushort SCAuctionPostedPacket = 0x12e;
    public const ushort SCAuctionSearchedPacket = 0x12f;
    public const ushort SCAuctionLowestPricePacket = 0x130;
    public const ushort SCAuctionBidPacket = 0x131;
    public const ushort SCAuctionCanceledPacket = 0x132;
    public const ushort SCAuctionMessagePacket = 0x133;
    public const ushort SCDiceValuePacket = 0x134;
    public const ushort SCNpcSpawnerPacket = 0x135;
    public const ushort SCActabilityPacket = 0x136;
    public const ushort SCHungPacket = 0x137;
    public const ushort SCUnhungPacket = 0x138;
    public const ushort SCBondDoodadPacket = 0x139;
    public const ushort SCUnbondDoodadPacket = 0x13a;
    public const ushort SCPlaySequencePacket = 0x13b;
    public const ushort SCGimmicksCreatedPacket = 0x13c;
    public const ushort SCGimmicksRemovedPacket = 0x13d;
    public const ushort SCGimmickMovementPacket = 0x13e;
    public const ushort SCGimmickJointsBrokenPacket = 0x13f;
    public const ushort SCGimmickResetJointsPacket = 0x140;
    public const ushort SCGimmickGraspedPacket = 0x141;
    public const ushort SCWorldRayCastingResultPacket = 0x142;
    public const ushort SCWorldAimPointPacket = 0x143;
    public const ushort SCWorldAABBPacket = 0x144;
    public const ushort SCUnkPacket5 = 0x145;
    public const ushort SCQuestContextFailedPacket = 0x146;
    public const ushort SCQuestContextStartedPacket = 0x147;
    public const ushort SCQuestUnitReqFailedPacket = 0x148;
    public const ushort SCQuestContextUpdatedPacket = 0x149;
    public const ushort CSQuestAcceptConditionalPacket = 0x14a;
    public const ushort SCQuestContextCompletedPacket = 0x14b;
    public const ushort SCQuestContextResetPacket = 0x14c;
    public const ushort SCDoodadCompleteQuestPacket = 0x14d;
    public const ushort SCQuestRewardedByMailPacket = 0x14e;
    public const ushort SCQuestMailSentPacket = 0x150;
    public const ushort SCScheduleItemSentPacket = 0x151;
    public const ushort SCSoundAreaEventPacket = 0x152;
    public const ushort SCAreaChatBubblePacket = 0x153;
    public const ushort SCChatBubblePacket = 0x154;
    public const ushort SCAreaTeamMessagePacket = 0x155;
    public const ushort SCDoodadSoundPacket = 0x156;
    public const ushort SCDoodadPhaseMsgPacket = 0x157;
    public const ushort SCDoodadUccStringPacket = 0x158;
    public const ushort SCDoodadUccDataPacket = 0x15a;
    public const ushort SCUccCharacterNameLoadedPacket = 0x15b;
    public const ushort SCNaviTeleportPacket = 0x15c;
    public const ushort SCItemUccDataChangedPacket = 0x15d;
    public const ushort SCCanStartTradePacket = 0x15e;
    public const ushort SCCannotStartTradePacket = 0x15f;
    public const ushort SCTradeStartedPacket = 0x160;
    public const ushort SCTradeCanceledPacket = 0x161;
    public const ushort SCTradeItemPutupPacket = 0x162;
    public const ushort SCOtherTradeItemPutupPacket = 0x163;
    public const ushort SCTradeMoneyPutupPacket = 0x164;
    public const ushort SCOtherTradeMoneyPutupPacket = 0x165;
    public const ushort SCTradeItemTookdownPacket = 0x166;
    public const ushort SCOtherTradeItemTookdownPacket = 0x167;
    public const ushort SCTradeOkUpdatePacket = 0x168;
    public const ushort SCTradeLockUpdatePacket = 0x169;
    public const ushort SCTradeMadePacket = 0x16a;
    public const ushort SCTowerDefListPacket = 0x16b;
    public const ushort SCTowerDefStartPacket = 0x16c;
    public const ushort SCTowerDefEndPacket = 0x16d;
    public const ushort SCTowerDefWaveStartPacket = 0x16e;
    public const ushort SCCrimeChangedPacket = 0x16f;
    public const ushort SCCriminalArrestedPacket = 0x170;
    public const ushort SCAskImprisonOrTrialPacket = 0x171;
    public const ushort SCInviteJuryPacket = 0x172;
    public const ushort SCSummonJuryPacket = 0x173;
    public const ushort SCJuryBeSeatedPacket = 0x174;
    public const ushort SCSummonDefendantPacket = 0x175;
    public const ushort SCCrimeDataPacket = 0x176;
    public const ushort SCCrimeRecordsPacket = 0x177;
    public const ushort SCChangeTrialStatePacket = 0x178;
    public const ushort SCChangeJuryOKCountPacket = 0x179;
    public const ushort SCChangeJuryVerdictCountPacket = 0x17a;
    public const ushort SCTrialWaitStatusPacket = 0x17b;
    public const ushort SCJuryWaitStatusPacket = 0x17c;
    public const ushort SCRulingStatusPacket = 0x17d;
    public const ushort SCRulingClosedPacket = 0x17e;
    public const ushort SCTrialAudienceJoinedPacket = 0x17f;
    public const ushort SCTrialAudienceLeftPacket = 0x180;
    public const ushort SCTrialInfoPacket = 0x181;
    public const ushort SCJuryWaitingNumberPacket = 0x182;
    public const ushort SCTrialCancledPacket = 0x183;
    public const ushort SCBotSuspectReportedPacket = 0x184;
    public const ushort SCBotSuspectArrestedPacket = 0x185;
    public const ushort SCSuspectGoingBotTrial = 0x186;
    public const ushort SCUnderWaterPacket = 0x187;
    public const ushort SCCharacterGamePointsPacket = 0x188;
    public const ushort SCGamePointChangedPacket = 0x189;
    public const ushort SCJuryPointChangedPacket = 0x18a;
    public const ushort SCAppliedToInstantGamePacket = 0x18b;
    public const ushort SCCancelInstantGamePacket = 0x18c;
    public const ushort SCInstantGameStatePacket = 0x18d;
    public const ushort SCInviteToInstantGamePacket = 0x18e;
    public const ushort SCInstantGameInviteTimeoutPacket = 0x18f;
    public const ushort SCInstantGameJoinedPacket = 0x190;
    public const ushort SCInstantGameStartPacket = 0x191;
    public const ushort SCInstantGameEndPacket = 0x192;
    public const ushort SCInstantGameAddPointPacket = 0x193;
    public const ushort SCInstantGameKillPacket = 0x194;
    public const ushort SCInstantGameKillstreakPacket = 0x195;
    public const ushort SCInstantGameUnkPacket = 0x196;
    public const ushort SCLoadInstancePacket = 0x197;
    public const ushort SCProcessingInstancePacket = 0x198;
    public const ushort SCGmCommandPacket = 0x199;
    public const ushort SCGmDumpInventoryPacket = 0x19a;
    public const ushort SCGmDumpEquipmentPacket = 0x19b;
    public const ushort SCGmDumpQuestsPacket = 0x19c;
    public const ushort SCGmDumpCompletedQuestsPacket = 0x19d;
    public const ushort SCGmDumpNpcPacket = 0x19e;
    public const ushort SCUnkPacket8 = 0x19f;
    public const ushort SCKickedPacket = 0x1a0;
    public const ushort SCAccountWarnedPacket = 0x1a1;
    public const ushort SCAboxTeleportPacket = 0x1a2;
    public const ushort SCDelayedTaskOnInGameNotifyPacket = 0x1a3;
    public const ushort SCAppellationsPacket = 0x1a4;
    public const ushort SCAppellationGainedPacket = 0x1a5;
    public const ushort SCAppellationChangedPacket = 0x1a6;
    public const ushort SCTutorialSavedPacket = 0x1a7;
    public const ushort SCEmblemUploadedPacket = 0x1a8;
    public const ushort SCEmblemDownloadedPacket = 0x1a9;
    public const ushort SCShipyardStatePacket = 0x1aa;
    public const ushort SCSlaveStatePacket = 0x1ab;
    public const ushort SCMateStatePacket = 0x1ac;
    public const ushort SCDumpCombatInfoPacket = 0x1ad;
    public const ushort SCUccCheckecPacket = 0x1ae;
    public const ushort SCShowQuestAreaPacket = 0x1af;
    public const ushort SCShowCommonFarmPacket = 0x1b0;
    public const ushort SCResponseCommonFarmListPacket = 0x1b1;
    public const ushort SCTelescopeToggledPacket = 0x1b2;
    public const ushort SCTelescopeUnitsPacket = 0x1b3;
    public const ushort SCTransferTelescopeToggledPacket = 0x1b4;
    public const ushort SCTransferTelescopeUnitsPacket = 0x1b5;
    public const ushort SCSchoolOfFishFinderToggledPacket = 0x1b6;
    public const ushort SCSchoolOfFishDoodadsPacket = 0x1b7;
    public const ushort SCShowDemoModeUiPacket = 0x1b8;
    public const ushort SCDemoCharResetItemPacket = 0x1b9;
    public const ushort SCDemoCharResetLocPacket = 0x1ba;
    public const ushort SCDemoResetActionSlotPacket = 0x1bb;
    public const ushort SCSetBreathPacket = 0x1bc;
    public const ushort SCAggroTargetChanged = 0x1bd;
    public const ushort SCDoodadReqBattleFieldPacket = 0x1be;
    public const ushort SCCraftFailedPacket = 0x1bf;
    public const ushort SCExpertLimitModifiedPacket = 0x1c0;
    public const ushort SCExpertExpandedPacket = 0x1c1;
    public const ushort SCAccountInfoPacket = 0x1c2;
    public const ushort SCAiDebugPacket = 0x1c3;
    public const ushort SCAiAggroPacket = 0x1c4;
    public const ushort SCHSRequestPacket = 0x1c5;
    public const ushort SCHackGuardRetAddrsRequestPacket = 0x1c6;
    public const ushort SCUnitLocationPacket = 0x1c7;
    public const ushort SCRestrictInfoPacket = 0x1c8;
    public const ushort SCIsUnitInFarmPacket = 0x1c9;
    public const ushort SCResponseUIDataPacket = 0x1ca;
    public const ushort SCUnitVisualOptionsPacket = 0x1cb;
    public const ushort SCNotifyUIMessagePacket = 0x1cc;
    public const ushort SCRefreshInCharacterListPacket = 0x1cd;
    public const ushort SCResultRestrictCheckPacket = 0x1ce;
    public const ushort SCICSMenuListPacket = 0x1cf;
    public const ushort SCICSGoodListPacket = 0x1d0;
    public const ushort SCICSGoodDetailPacket = 0x1d1;
    public const ushort SCICSCheckTimePacket = 0x1d2;
    public const ushort SCICSBuyResultPacket = 0x1d3;
    public const ushort SCICSSyncGoodPacket = 0x1d4;
    public const ushort SCICSCashPointPacket = 0x1d6;
    public const ushort SCICSExchangeRatioPacket = 0x1d7;
    public const ushort SCPremiumServiceListPacket = 0x1d8;
    public const ushort SCBountyListPacket = 0x1d9;
    public const ushort SCSetBountyPermittedPacket = 0x1da;
    public const ushort SCSetBountyDonePacket = 0x1db;
    public const ushort SCBountyPaidPacket = 0x1dc;
    public const ushort SCInvitationCanceledPacket = 0x1dd;
    public const ushort SCPlaySoundPacket = 0x1de;
    public const ushort SCSendUserMusicPacket = 0x1df;
    public const ushort SCUserNoteLoadedPacket = 0x1e0;
    public const ushort SCPauseUserMusicPacket = 0x1e1;
    public const ushort SCGetSlotCountPacket = 0x1e2;
    public const ushort SCSecondPassSettedPacket = 0x1e3;
    public const ushort SCSecondPassKeyTablesPacket = 0x1e4;
    public const ushort SCSecondPassChangedPacket = 0x1e5;
    public const ushort SCSecondPassCheckedPacket = 0x1e6;
    public const ushort SCSecondPassClearedPacket = 0x1e7;
    public const ushort SCSecondPassCheckOverFailedPacket = 0x1e8;
    public const ushort SCSecondPassAccountLockedPacket = 0x1e9;
    public const ushort SCSecondPassCreatedPacket = 0x1ea;
    public const ushort SCScheduleItemUpdatePacket = 0x1eb;
    public const ushort SCScheduledEventStartedPacket = 0x1ec;
    public const ushort SCScheduledEventEndedPacket = 0x1ed;
    public const ushort SCMouldListPacket = 0x1ee;
    public const ushort SCMouldAskedPacket = 0x1ef;
    public const ushort SCMouldTakenPacket = 0x1f0;
    public const ushort SCToggleBeautyshopResponsePacket = 0x1f1;
    public const ushort SCCharacterGenderAndModelModifiedPacket = 0x1f3;
    public const ushort SCSpecialtyCurrentPacket = 0x1f4;
    public const ushort SCUnitIdleStatusPacket = 0x1f5;
    public const ushort SCRaceCondPacket = 0x1f6;
    public const ushort SCRacingPacket = 0x1f7;
    public const ushort SCRacingResultPacket = 0x1f8;
    public const ushort SCRankRewardMailPacket = 0x1f9;
    public const ushort SCRankCharacterPacket = 0x1fa;
    public const ushort SCRankSnapshotPacket = 0x1fb;
    public const ushort SCAchievementsPacket = 0x1fc;
    public const ushort SCAchievementChangedPacket = 0x1fd;
    public const ushort SCAchievementCompletedPacket = 0x1fe;
    public const ushort SCAchievementResetedPacket = 0x1ff;
    public const ushort SCAchievementItemSentPacket = 0x200; // Sleepless/Nightshift sent?
    public const ushort SCUpdatePremiumPointPacket = 0x201;
    public const ushort SCPremiumPointChangedPacket = 0x202;
    public const ushort SCUnitGmModeChangedPacket = 0x203;
    public const ushort SCUnitPvPPointsChangedPacket = 0x204;
    public const ushort SCRankAlarmPacket = 0x205;
    public const ushort SCUnkPacket15 = 0x206; // Select Dimension, uint ZoneGroupId
    public const ushort SCUnkPacket16 = 0x207;
    public const ushort SCUnkPacket17 = 0x208; // Secure mode error message
    public const ushort SCUnkCharacterAddStatPacket = 0x209;
    public const ushort SCUnlockCurrencySlotPacket = 0x20a;
    public const ushort SCUnkPacket20 = 0x20b;
    public const ushort SCUnkPacket21 = 0x20c;
    public const ushort SCUnkPacket22 = 0x20d;
    public const ushort SCUnkPacket23 = 0x20e;
    public const ushort SCUnkPacket24 = 0x20f;
    public const ushort SCUnkPacket28 = 0x210;
    public const ushort SCWorldMessagePacket = 0x211;
    public const ushort SCUnkPacket25 = 0x212;
    public const ushort SCUnkPacket26 = 0x213;
    public const ushort SCUnkPacket27 = 0x214;
    public const ushort SCAccountAttributeConfigPacket = 0x215;
    public const ushort SCIdleKickPacket = 0x216;
    public const ushort SCLevelRestrictionConfigPacket = 0x217;
}
