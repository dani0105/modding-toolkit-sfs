using System;
using UnityEngine;

namespace SFS.World
{
	// Token: 0x02000193 RID: 403
	public interface I_Physics
	{
		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000C0D RID: 3085
		// (set) Token: 0x06000C0E RID: 3086
		bool PhysicsMode { get; set; }

		// Token: 0x06000C0F RID: 3087
		void OnFixedUpdate(Vector2 gravity);

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000C10 RID: 3088
		// (set) Token: 0x06000C11 RID: 3089
		Vector2 LocalPosition { get; set; }

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000C12 RID: 3090
		// (set) Token: 0x06000C13 RID: 3091
		Vector2 LocalVelocity { get; set; }

		// Token: 0x06000C14 RID: 3092
		void OnCrashIntoPlanet();
	}
}
