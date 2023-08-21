// SFS.World

// 

// SFS.Input.OnInputStartData
using SFS.Input;

namespace SFS.Input
{
    public class OnInputStartData
    {
        public InputType inputType;

        public TouchPosition position;

        public OnInputStartData(InputType inputType, TouchPosition position)
        {
            this.inputType = inputType;
            this.position = position;
        }
    }
}