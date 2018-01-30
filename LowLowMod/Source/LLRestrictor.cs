using ICities;

namespace LowLowMod
{
    class LLRestrictor : LevelUpExtensionBase
    {
        public override void OnCreated(ILevelUp levelUp)
        {
            base.OnCreated(levelUp);
        }

        public override CommercialLevelUp OnCalculateCommercialLevelUp(CommercialLevelUp levelUp, int averageWealth, int landValue, ushort buildingID, Service service, SubService subService, Level currentLevel)
        {
            levelUp.targetLevel = Level.Level1;
            return base.OnCalculateCommercialLevelUp(levelUp, averageWealth, landValue, buildingID, service, subService, currentLevel);
        }

    }
}
