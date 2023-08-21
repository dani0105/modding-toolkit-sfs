using System;
using SFS.Parts;
using UnityEngine;

namespace SFS.World
{
	// Token: 0x020001C3 RID: 451
	[Serializable]
	public class PartJoint
	{
		// Token: 0x06000DBC RID: 3516 RVA: 0x0003E5C7 File Offset: 0x0003C7C7
		public PartJoint(Part a, Part b, Vector2 anchor)
		{

		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x0003E5E4 File Offset: 0x0003C7E4
		public Part GetOtherPart(Part part)
		{
			return null;
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0003E61C File Offset: 0x0003C81C
		public Vector2 GetRelativeAnchor(Part part)
		{
			return Vector2.zero;
		}

		// Token: 0x040007C2 RID: 1986
		public Part a;

		// Token: 0x040007C3 RID: 1987
		public Part b;

		// Token: 0x040007C4 RID: 1988
		public Vector2 anchor;
	}
}
