using ICities;

namespace LowLowMod
{
    public class LLModBase : IUserMod
    {
        public string Name
        {
            get
            {
                return "LowLowMod: Height and Level Restrictor";
            }
        }

        public string Description
        {
            get
            {
                return "Restricts the height of low commercial buildings by limiting their maximum level.";
            }
        }
    }
}
