using UnityEngine;

namespace SFS.UI
{
    public class MsgDrawer : MonoBehaviour, I_MsgLogger
    {
        public static MsgDrawer main;
        public TextAdapter text;
        public AnimationClip msgAnimation;
        public AnimationClip msgAnimationBig;

        public MsgDrawer(){}

        public void Log(string msg){}
        public void Log(string msg, bool big){}
    }
}