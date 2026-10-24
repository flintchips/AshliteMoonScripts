using System;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace FlintChips.AshliteMoon
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class AshliteMoonPlugin : BaseUnityPlugin
    {
        public const string PluginGuid = "FlintChips.AshliteMoon";
        public const string PluginName = "240_Ashlite";
        public const string PluginVersion = "0.1.1";
        
        internal static ManualLogSource Log = null!;
        
        private void Awake()
        {
            Log = Logger;
            new Harmony(PluginGuid).PatchAll();
            Logger.LogInfo($"scripts have loaded. THE SUN IS A DEADLY LAZER.");
        }
    }
}