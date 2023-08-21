using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SFS.UI.ModGUI
{
    public static class Builder
    {
        public static void AttachToCanvas(GameObject holder, SceneToAttach mode) { }
        public static Box CreateBox(Transform parent, int width, int height, int posX = 0, int posY = 0, float opacity = 0.3F)
        {
            return null;
        }

        public static Button CreateButton(Transform parent, int width, int height, int posX = 0, int posY = 0, Action onClick = null, string text = "")
        {
            return new Button();
        }
        public static ButtonWithLabel CreateButtonWithLabel(Transform parent, int width, int height, int posX = 0, int posY = 0, string labelText = "", string buttonText = "", Action onClick = null)
        {
            return new ButtonWithLabel();
        }
        public static Container CreateContainer(Transform parent, int posX = 0, int posY = 0)
        {
            return new Container();
        }
        public static GameObject CreateHolder(SceneToAttach mode, string name)
        {
            return new GameObject();
        }
        public static InputWithLabel CreateInputWithLabel(Transform parent, int width, int height, int posX = 0, int posY = 0, string labelText = "", string inputText = "", UnityAction<string> onInputChange = null)
        {
            return new InputWithLabel();
        }
        public static Label CreateLabel(Transform parent, int width, int height, int posX = 0, int posY = 0, string text = "")
        {
            return new Label();
        }
        public static Separator CreateSeparator(Transform parent, int width, int posX = 0, int posY = 0)
        {
            return new Separator();
        }
        public static Slider CreateSlider(Transform parent, int size, float value, (float min, float max) minMaxValue, bool wholeNumbers = false, UnityAction<float> onSliderChange = null, Func<float, string> getValueWithUnits = null)
        {
            return new Slider();
        }
        public static Space CreateSpace(Transform parent, int width, int height)
        {
            return new Space();
        }
        public static TextInput CreateTextInput(Transform parent, int width, int height, int posX = 0, int posY = 0, string text = "", UnityAction<string> onChange = null)
        {
            return new TextInput();
        }
        public static Toggle CreateToggle(Transform parent, Func<bool> getToggleValue, int posX = 0, int posY = 0, Action onChange = null)
        {
            return new Toggle();
        }
        public static ToggleWithLabel CreateToggleWithLabel(Transform parent, int width, int height, Func<bool> getToggleValue, Action onChange = null, int posX = 0, int posY = 0, string labelText = "")
        {
            return new ToggleWithLabel();
        }
        /*public static WebImage CreateWebImage(Transform parent, int width, int height, int posX = 0, int posY = 0, string link = null, bool useMask = true, SDWebImage.LoadingIndicatorType loadingIndicatorType = SDWebImage.LoadingIndicatorType.Circles, bool preserveAspect = false)
        {
            return new WebImage();
        }*/
        public static Window CreateWindow(Transform parent, int ID, int width, int height, int posX = 0, int posY = 0, bool draggable = false, bool savePosition = true, float opacity = 1, string titleText = "")
        {
            return new Window();
        }
        public static int GetRandomID()
        {
            return 0;
        }

        public enum SceneToAttach
        {
            BaseScene = 0,
            CurrentScene = 1
        }
    }
}