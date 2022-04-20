using OWML.Common;
using OWML.ModHelper;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace GhostMatterNerf
{
    public class GhostMatterNerf : ModBehaviour
    {
        private void Update()
        {
            
         Locator.GetPlayerController()._hazardDetector._darkMatterDamagePerSecond = 1;        
        }
    }
}
