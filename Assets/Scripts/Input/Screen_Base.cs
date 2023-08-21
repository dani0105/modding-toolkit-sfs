using System;
using System.Collections.Generic;
using SFS.Input;
using UnityEngine;


namespace SFS.Input
{
    public abstract class Screen_Base : MonoBehaviour
    {
        protected static Dictionary<I_Key, Action> keys = new Dictionary<I_Key, Action>();

        public abstract bool PauseWhileOpen { get; }

        public static void AddOnKeyDown(I_Key key, Action action)
        {
        }

        public abstract void ProcessInput();

        public abstract void OnOpen();

        public abstract void OnClose();
    }
}