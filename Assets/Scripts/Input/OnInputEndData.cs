using System;

namespace SFS.Input
{
	// Token: 0x02000207 RID: 519
	public class OnInputEndData
	{

		public bool LeftClick
		{
			get;
		
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x0004CD0A File Offset: 0x0004AF0A
		public OnInputEndData(InputType inputType, TouchPosition position, bool click)
		{
		}

		// Token: 0x040008E5 RID: 2277
		public InputType inputType;

		// Token: 0x040008E6 RID: 2278
		public TouchPosition position;

		// Token: 0x040008E7 RID: 2279
		public bool click;
	}
}
