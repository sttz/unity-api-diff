using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public enum SynchronisationStageFlags
{
    VertexProcessing = 1,
    PixelProcessing = 2,
    ComputeProcessing = 4,
    AllGPUOperations = 7,
}

}
