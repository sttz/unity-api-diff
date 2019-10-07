using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public interface IRenderPipelineAsset
{
    public Experimental.Rendering.IRenderPipeline CreatePipeline();
    public void DestroyCreatedInstances();
    public int GetTerrainBrushPassIndex();

}

}
