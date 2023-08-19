﻿using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace SFS.Parts.Modules
{
    [HideMonoScript]
    public class CopyPipe : PipeData
    {
        public PipeData input;

        public override void Output()
        {
            if (!Application.isPlaying)
                input.Output();

            Pipe data = input.pipe;

            Pipe copy = new Pipe { points = new List<PipePoint>(data.points.Count) };
            for (int i = 0; i < data.points.Count; i++)
            {
                PipePoint a = data.points[i];
                copy.points.Add(new PipePoint(a.position, a.width, a.height, a.cutLeft, a.cutRight));
            }
            
            SetData(copy);
        }
    }
}