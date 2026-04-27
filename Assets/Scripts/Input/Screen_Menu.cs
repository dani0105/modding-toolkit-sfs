using System;
using System.Collections.Generic;
using SFS.Input;
using UnityEngine;

namespace SFS.Input
{
    public abstract class Screen_Menu : Screen_Base
    {
        public bool pauseWhileOpen = true;

        public override bool PauseWhileOpen => pauseWhileOpen;

        //protected abstract CloseMode OnEscape { get; }

        public override void ProcessInput()
        {
            foreach (KeyValuePair<I_Key, Action> key in Screen_Base.keys)
            {
                if (key.Key.IsKeyDown())
                {
                    key.Value?.Invoke();
                }
            }
  
        }

        public virtual void Open()
        {
            if (ScreenManager.main.CurrentScreen != this)
            {
                ScreenManager.main.OpenScreen(() => this);
            }
        }

        public virtual void Close()
        {
            if (ScreenManager.main.CurrentScreen == this)
            {
                ScreenManager.main.CloseCurrent();
            }
        }

        public void CloseStack()
        {
            if (ScreenManager.main.CurrentScreen == this)
            {
                ScreenManager.main.CloseStack();
            }
        }
    }
}