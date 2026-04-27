using System;
using System.Collections.Generic;
using System.Linq;
using SFS.Parts.Modules;
using SFS.Translations;
using SFS.UI;
using SFS.Variables;
using SFS.World;
using UnityEngine;

namespace SFS.World
{
    public class ResourceDrawer : MonoBehaviour
    {
        public interface I_Resource
        {
            ResourceType ResourceType { get; }

            float WetMass { get; }

            Double_Reference ResourcePercent { get; }
        }

        public Transform resourcesHolder;

        public RectTransform textPrefab;

        public ResourceBar barPrefab;

        public RectTransform temperatureMenuAttachPoint;

        public GameObject temperatureHolder;

        public GameObject combinedMenuHolder;

        public Button plantFlagButton;

        //private Local_GenericTarget target = new Local_GenericTarget();


    }
}