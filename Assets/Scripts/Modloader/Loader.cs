using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using ModLoader;
using SFS.IO;
using UnityEngine;

namespace ModLoader
{
    public class Loader : MonoBehaviour
    {
        public static Loader main;

        private List<Mod> mods;

        private List<Mod> loadedMods = new List<Mod>();

        private static readonly Regex Version_Regex = new Regex("\\b([0-9]+\\.)+[0-9]+\\b", RegexOptions.IgnoreCase | RegexOptions.Compiled);

        public static FolderPath ModsFolder => FileLocations.BaseFolder.Extend("/../Mods");

        public Mod[] GetAllMods()
        {
            return null;
        }

        public Mod[] GetLoadedMods()
        {
            return null;
        }

        public void Initialize_EarlyLoad()
        {

        }

        public void Initialize_Load()
        {

        }

        private void MoveIndividualDLLs()
        {

        }

        private void LoadModList()
        {

        }

        private void LoadMod(Mod mod)
        {
        }

        private static bool VerifyVersion(string targetVersion, string currentVersion)
        {
            return true;
        }

        private bool LoadDependencies(Mod mod)
        {
            return true;
        }
    }
}