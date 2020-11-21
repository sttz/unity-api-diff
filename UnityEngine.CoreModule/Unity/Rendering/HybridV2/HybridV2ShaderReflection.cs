using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Rendering.HybridV2
{

public class HybridV2ShaderReflection
{
    static public Unity.Collections.NativeArray<Unity.Rendering.HybridV2.DOTSInstancingCbuffer> GetDOTSInstancingCbuffers(Shader shader);
    static public Unity.Collections.NativeArray<Unity.Rendering.HybridV2.DOTSInstancingProperty> GetDOTSInstancingProperties(Shader shader);
    static public uint GetDOTSReflectionVersionNumber();

    public HybridV2ShaderReflection();

}

}
