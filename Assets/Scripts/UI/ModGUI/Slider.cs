using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SFS.UI.ModGUI
{
    public class Slider : GUIElement
    {
        public Slider() { }

        public UnityAction<float> OnSliderChanged { get;set; }
        public Func<float, string> GetValueWithUnit { get;set; }
        public UnityEngine.UI.Slider.Direction SliderType { get; set; }
        
        public (float min, float max) MinMaxValue { get; set; }
        public bool WholeNumbersOnly { get; set; }
        public float Value { get; set; }

        public override void Init(GameObject self, Transform parent)
        {

        }
    }
}