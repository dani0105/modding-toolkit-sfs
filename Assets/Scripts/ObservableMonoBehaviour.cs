using System;
using SFS.Variables;
using UnityEngine;

namespace SFS
{
    public class ObservableMonoBehaviour : MonoBehaviour, I_ObservableMonoBehaviour
    {
        private Action onDestroyDelegate;

        Action I_ObservableMonoBehaviour.OnDestroy
        {
            get; set;
        }

    }
}