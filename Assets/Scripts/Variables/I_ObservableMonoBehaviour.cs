// SFS.Variables.I_ObservableMonoBehaviour
using System;

namespace SFS.Variables
{
    public interface I_ObservableMonoBehaviour
    {
        Action OnDestroy { get; set; }
    }

}
