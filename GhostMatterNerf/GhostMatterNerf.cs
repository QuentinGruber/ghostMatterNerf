using OWML.ModHelper;

namespace GhostMatterNerf
{
    public class GhostMatterNerf : ModBehaviour
    {
        private void Update()
        {
            if (Locator.GetPlayerController())
            {
                Locator.GetPlayerController()._hazardDetector._darkMatterDamagePerSecond = 0;
            }
        }
    }
}
