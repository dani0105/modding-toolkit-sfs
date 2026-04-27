using UnityEngine;
using SFS.Builds;
using SFS.Translations;
using System.Collections.Generic;
using SFS.Input;

namespace SFS.Builds
{
    public class BuildManager : MonoBehaviour
    {
        public static BuildManager main;
        public BuildGrid buildGrid;
        
        /*[Serializable]
        public class ExampleRocket
        {
            public TranslationVariable rocketName;

            public string json;
        }

        //public Screen_Game build_Input;

        [Space]
        public BuildCamera buildCamera;

        public BuildMenus buildMenus;

        public PickGridUI pickGrid;

        public HoldGrid holdGrid;

        

        public GridSize buildGridSize;

        public BuildSelector selector;

        public AreaSelect areaSelect;

        [Space]
        public DownloadMenu downloadMenu;

        [Space]
        public SoundEffect destroyPartSound;

        public MusicPlaylistPlayer music;

        [Space]
        public PostProcessing postProcessing;

        [Space]
        public SFS.UI.Button launchButton;

        public PopupAnimation noFuelSourcePopup;

        private Vector2? noFuelSourcePopupData;

        public RectTransform fullVersionButton;

        public bool symmetryMode;

        private OpenTracker partMenuReference;

        public ExampleRocket[] exampleRockets;
*/
        public BuildManager()
        {
            main = this;
        }

        private void Start()
        {

        }

        private void OnDestroy()
        {
        }

        private void OnInputStart(OnInputStartData data)
        {

        }

        private void OnInputMove(OnNotStationary data)
        {

        }

        private void OnInputEnd(OnInputEndData data)
        {

        }

        private void OnTouchLongClick(OnTouchLongClickData data)
        {

        }

        private void On_LeftOrTouch_Start(OnInputStartData data)
        {

        }

        private void On_LeftOrTouch_Move(OnNotStationary data)
        {

        }

        private void On_LeftOrTouch_End(OnInputEndData data)
        {

        }

        private void On_RightOrLong_Click(TouchPosition position, bool longClick)
        {

        }

        private void OnDrag(DragData data)
        {

        }

        private void OnZoom(ZoomData data)
        {

        }

        public void Launch()
        {

        }

        private void LateUpdate()
        {

        }

        private void ResetNoFuelSourcePopup()
        {

        }

        public void OpenMenu()
        {

        }

        public void ResumeGame()
        {

        }

        public void OpenLoadMenu()
        {

        }

        public void OpenSaveMenu()
        {

        }

        public void AskClear()
        {

        }

        public void UploadPC()
        {

        }

        public void ExitToHome()
        {

        }

        public void ToggleSymmetryMode()
        {

        }

        public void ToggleStagingMode()
        {

        }

        public void OpenPartsSalePage()
        {

        }

        public void OpenSkinsSalePage()
        {

        }

        public void OpenFullVersionSalePage()
        {

        }

        private void OpenExampleRocketsMenu()
        {

        }
    }

}