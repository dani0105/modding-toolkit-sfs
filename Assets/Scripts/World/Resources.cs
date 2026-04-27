using System;
using System.Collections.Generic;
using System.Linq;
using SFS.Parts;
using SFS.Parts.Modules;
using SFS.World;
using UnityEngine;

namespace SFS.World
{
    public class Resources : ObservableMonoBehaviour
    {
        [Serializable]
        public class Transfer
        {
            public Part part;

            public ResourceModule group;

            public Transfer(Part part, ResourceModule group)
            {
                this.part = part;
                this.group = group;
            }
        }

        public GameObject groupsHolder;

        public ResourceModule[] localGroups = new ResourceModule[0];

        public ResourceModule[] globalGroups = new ResourceModule[0];

        public BoosterModule[] boosters;

        public List<Transfer> transfers = new List<Transfer>();

        public Action onGroupsSetup;

        public void SetupResourceGroups(Rocket rocket)
        {
            
        }

        public void ToggleTransfer(Part part, ResourceModule group)
        {
            
        }

        public void RemoveInvalidTransfers(PartHolder holder)
        {
           
        }
    }
}