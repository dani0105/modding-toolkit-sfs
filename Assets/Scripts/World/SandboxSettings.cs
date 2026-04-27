using System;
using Beebyte.Obfuscator;
using SFS;
using SFS.Builds;
using SFS.Input;
using SFS.Parts.Modules;
using SFS.Translations;
using SFS.UI;
using SFS.Variables;
using SFS.World;
using SFS.WorldBase;
using UnityEngine;

namespace SFS.World
{
    public class SandboxSettings : BasicMenu
    {
        [Serializable]
        [Skip]
        public class Data
        {
            public bool infiniteFuel;

            public bool noAtmosphericDrag;

            public bool unbreakableParts;

            public bool noGravity;

            public bool noHeatDamage;

            public bool noBurnMarks;

            public bool infiniteBuildArea;

            public bool partClipping;
        }

        public static SandboxSettings main;

        public ToggleButton infiniteBuildArea;

        public ToggleButton partClipping;

        public ToggleButton infiniteFuel;

        public ToggleButton infiniteOxygen;

        public ToggleButton noAtmosphericDrag;

        public ToggleButton unbreakableParts;

        public ToggleButton noGravity;

        public ToggleButton noHeatDamage;

        public ToggleButton noBurnMarks;

        public SFS.UI.Button buyInfiniteBuildAreaButton;

        public SFS.UI.Button buyCheatsButton;

        public SFS.UI.Button preventUse_InfiniteArea;

        public SFS.UI.Button preventUse_Cheats;

        //public ContainerElement containerElement;

        //public SettingsMenuSizer settingsMenuSizer;

        public ButtonPC fullVersionButton;

        public GameObject[] fullVersionElements;

        public SFS.UI.Button teleportButton;

        public SFS.UI.Button refillButton;

        public SFS.UI.Button unlockCheatsButton;

        [HideInInspector]
        public Data settings;

        [HideInInspector]
        public bool initialized;

        public Transform settingsTransform;

        public Event_Local onToggleCheat = new Event_Local();

        private void Awake()
        {
            main = this;
        }

        private void Start()
        {

        }

        private void UpdatePreventUse()
        {

        }

        private bool ShowUnlockCheats()
        {
            return false;
        }

        public override void OnOpen()
        {

        }

        private void UnlockCheats()
        {

        }

        private void Refill()
        {

        }

        private void ToggleInfiniteBuildArea()
        {

        }

        private void TogglePartClipping()
        {

        }

        private void ToggleInfiniteFuel()
        {

        }

        private void ToggleNoAtmosphericDrag()
        {

        }

        private void ToggleUnbreakableParts()
        {

        }

        private void ToggleNoGravity()
        {

        }

        private void ToggleNoHeatDamage()
        {

        }

        private void ToggleNoBurnMarks()
        {

        }

        private void OnToggle()
        {

        }

        public void UpdateUI(bool instantAnimation)
        {

        }
    }
}