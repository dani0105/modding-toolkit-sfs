using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using SFS.Parts;
using SFS.Parts.Modules;
using UnityEngine;

namespace SFS.World
{
	// Token: 0x020001C4 RID: 452
	[Serializable]
	public class JointGroup
	{
		// Token: 0x06000DBF RID: 3519 RVA: 0x0003E664 File Offset: 0x0003C864
		public JointGroup(List<PartJoint> joints, List<Part> parts)
		{
		}


		// Token: 0x06000DC1 RID: 3521 RVA: 0x0003E718 File Offset: 0x0003C918
		public static void OnPartDestroyed(Part part, Rocket rocket, DestructionReason reason)
		{
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0003E784 File Offset: 0x0003C984
		public static void DestroyJoint(PartJoint joint, Rocket rocket, out bool split, out Rocket newRocket)
		{
      split= false;
      newRocket= null;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0003E7C4 File Offset: 0x0003C9C4
		public static List<JointGroup> RecreateRockets(Rocket rocket, out List<Rocket> childRockets)
		{
      childRockets= null;
			return null;
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x0003E87C File Offset: 0x0003CA7C
		public void RecreateGroups(out List<JointGroup> newGroups)
		{
      newGroups= null;
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0003E9E4 File Offset: 0x0003CBE4
		public void AddJoint(PartJoint joint)
		{

		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x0003E9FC File Offset: 0x0003CBFC
		public void RemovePartAndItsJoints(Part part)
		{

		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0003EAA8 File Offset: 0x0003CCA8
		public void RepositionParts()
		{
			
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0003EBA8 File Offset: 0x0003CDA8
		public List<List<ResourceModule>> GetResourceGroups()
		{
			return null;
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x0003EDC0 File Offset: 0x0003CFC0
		public List<SplitModule> GetConnectedFairings(Part startPart, SplitModule fairing)
		{
			return null;
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x0003EEA4 File Offset: 0x0003D0A4
		public List<PartJoint> GetConnectedJoints(Part part)
		{
			return null;
		}




		// Token: 0x040007C5 RID: 1989
		public Dictionary<Part, List<PartJoint>> dictionary;

		// Token: 0x040007C6 RID: 1990
		public List<PartJoint> joints;

		// Token: 0x040007C7 RID: 1991
		public List<Part> parts;
	}
}
