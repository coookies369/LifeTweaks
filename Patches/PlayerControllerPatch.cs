using System;
using HarmonyLib;

namespace LifeTweaks.Patches;

[HarmonyPatch(typeof(PlayerController))]
public class PlayerControllerPatch
{
    [HarmonyPatch("AddNewLive")]
    [HarmonyPrefix]
    private static void LimitLifeGain(ref int live, PlayerController __instance)
    {
        live = Math.Min(live, Config.lifeCap.Value - __instance.GetLifes());
    }

    [HarmonyPatch("ResetLifes")]
    [HarmonyPrefix]
    private static void SetStartingLives(ref int startLifesCount)
    {
        startLifesCount = Config.startLifeCount.Value;
    }
}