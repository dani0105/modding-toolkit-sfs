
using System;
using System.Collections.Generic;
using SFS.Input;
using SFS.Variables;
using UnityEngine;

namespace SFS.World
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager main;
        //public WorldEnvironment environment;
        //public Screen_Game world_Input;
        //public Screen_Game map_Input;
        //public AeroData aeroData;
        public List<Rocket> rockets;
        public GameObject fuelManager;

        public GameManager() { }

        public static void AddAxis((I_Key, I_Key) axis, ref Float_Local output) { }
        public static void AddOnKey(I_Key key, Action action) { }
        public static void AddOnKeyDown(I_Key key, Action action) { }
        public void ExitToBuild() { }
        public void ExitToHub() { }
        public void ExitToMainMenu() { }
        public void LoadSave(WorldSave save, bool forLaunch, I_MsgLogger logger) { }
        public void OpenLoad() { }
        public void OpenMenu() { }
        public void OpenSave() { }
        public void RevertToBuild(bool skipConfirmation) { }
        public void RevertToLaunch(bool skipConfirmation) { }
    }
}