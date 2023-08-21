using System;
using UnityEngine;

namespace SFS.Input
{
	// Token: 0x0200020B RID: 523
	public class TouchPosition
	{
		// Token: 0x06001020 RID: 4128 RVA: 0x0004CD45 File Offset: 0x0004AF45
		public TouchPosition(Vector2 pixel)
		{
			this.pixel = pixel;
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0004CD54 File Offset: 0x0004AF54
		public Vector2 World(float positionZ)
		{
			return Vector2.zero;
		}

		// Token: 0x040008EE RID: 2286
		public Vector2 pixel;
	}
}
