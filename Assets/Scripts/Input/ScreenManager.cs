using System;
using System.Collections.Generic;
using SFS.Input;
using SFS.World;
using UnityEngine;

namespace SFS.Input
{
    public class ScreenManager : MonoBehaviour
    {
        public static ScreenManager main;

        private Stack<Func<Screen_Base>> screenStack = new Stack<Func<Screen_Base>>();

        [Space]
        public bool selfInitialize;

        public Screen_Base initialScreen;

        public Screen_Base CurrentScreen { get; private set; }


        public int GetStackCount()
        {
            return 0;
        }

        public void SetStack(Func<Screen_Base> screen)
        {

        }

        public void CloseCurrent()
        {

        }

        public void CloseStack()
        {

        }

        public void OpenScreen(Func<Screen_Base> screen)
        {

        }

    }
}