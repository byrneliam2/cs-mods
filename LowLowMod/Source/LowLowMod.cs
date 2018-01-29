using ICities;
using UnityEngine;

namespace LLMod
{
    public class LowLowModBase : IUserMod
    {
        public string Name => "LowLowMod: Height and Level Restrictor";

        public string Description => "Restricts the height of low commercial buildings by limiting their maximum level.";
    }
}
