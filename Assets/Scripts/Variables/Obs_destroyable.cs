using System;
using SFS.Variables;

namespace SFS.Variables
{
    [Serializable]
    public abstract class Obs_Destroyable<T> : Obs<T> where T : I_ObservableMonoBehaviour
    {
        public new T Value
        {
            get; set;
        }

        private void OnDestroy()
        {

        }
    }
}