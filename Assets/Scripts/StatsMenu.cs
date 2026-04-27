
using System;
using UnityEngine;
using SFS.Translations;

public class StatsMenu : MonoBehaviour
{
    public StatsMenu() { }

    private class ElementData
    {
        public readonly int priority;

        public readonly int index;

        public readonly Action draw;

        public readonly bool statElement;

        public ElementData(int priority, int index, Action draw, bool statElement)
        {
            this.priority = priority;
            this.index = index;
            this.draw = draw;
            this.statElement = statElement;
        }
    }

    public RectTransform menuHolder;

   // public VerticalLayoutGroup statsHolderGroup;

    //[Space]
    //public VerticalLayout statsHolderLayout;

   // public NewElement rootElement;

    [Space]
    public GameObject titleHolder;

    //public TextAdapter titleText;

    [Space]
   // public PopupAnimation popupAnimation;

    [Space]
    public RectTransform spacePrefab;

    public RectTransform textPrefab;

    public RectTransform statPrefab;

    public RectTransform statBackPrefab;

    public RectTransform togglePrefab;

    public RectTransform sliderPrefab;

    public RectTransform buttonPrefab;

    public RectTransform fullButtonPrefab;

    //private List<ElementData> drawQueue = new List<ElementData>();

    //private List<GameObject> elements = new List<GameObject>();

    private Func<bool> hasControl;

    private Action onClose;

    private bool disableAtAwake = true;

    private bool HasControl
    {
        get
        {
            if (hasControl != null)
            {
                return hasControl();
            }
            return true;
        }
    }

    private void Awake()
    {

    }
    /*
        public OpenTracker Open(Func<bool> hasControl, Action<StatsMenu> draw, bool skipAnimation, Action onOpen = null, Action onClose = null)
        {

        }*/

    public void Close()
    {

    }

    public void DrawTitle(string title)
    {

    }

    public void DrawText(int priority, string text)
    {

    }

    public void DrawStat(int priority, string labelAndValue, string valueSize_Optional = null)
    {

    }

    public void DrawStat(int priority, Func<string> labelAndValue, Func<string> valueSize_Optional, Action<Action> register, Action<Action> unregister)
    {
    }

    public void DrawStat_Separate(int priority, Func<string> label, Func<string> value, Func<string> valueSize_Optional, Action<Action> register, Action<Action> unregister)
    {

    }

    public void DrawToggle(int priority, Func<string> labelText, Action toggle, Func<bool> getValue, Action<Action> register, Action<Action> unregister)
    {

    }

    public void DrawSlider(int priority, Func<string> labelAndValue, Func<string> valueSize_Optional, Func<float> getFillPercent, Action<float, bool> setFillPercent, Action<Action> register, Action<Action> unregister, bool startUndoStep = false)
    {
    }

    public void DrawSlider_Separate(int priority, Func<string> labelText, Func<string> valueText, Func<string> valueSize_Optional, Func<float> getFillPercent, Action<float, bool> setFillPercent, Action<Action> register, Action<Action> unregister, bool startUndoStep = false)
    {

    }

    public void DrawButton(int priority, string labelText, string buttonText, Action buttonAction, bool enabled = true)
    {

    }

    public void DrawButton(int priority, Func<string> labelText, Func<string> buttonText, Action buttonAction, Func<bool> enabled, Action<Action> register, Action<Action> unregister)
    {

    }

    public void DrawFullButton(int priority, string buttonText, Action buttonAction, bool enabled = true)
    {

    }

    public void DrawFullButton(int priority, Func<string> buttonText, Action buttonAction, Func<bool> enabled, Action<Action> register, Action<Action> unregister)
    {

    }

    public void DrawSpace(int priority, float height = 5f)
    {

    }





}