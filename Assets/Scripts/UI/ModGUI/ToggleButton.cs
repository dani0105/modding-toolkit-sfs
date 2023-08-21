
using System;
using SFS.Parts.Modules;

namespace SFS.UI
{
    public class ToggleButton : Button
    {
        public MoveModule moveModule;

        public ToggleButton() { }

        public void Bind(Action toggle, Func<bool> getValue) { }
        public void Bind(Action toggle, Func<bool> getValue, out Action update)
        {
            update = null;
        }
        public void UpdateUI(bool instantAnimation) { }

    }
}