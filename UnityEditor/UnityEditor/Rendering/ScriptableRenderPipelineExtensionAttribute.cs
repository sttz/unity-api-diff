using System;
using UnityEngine;

namespace UnityEditor.Rendering
{

public class ScriptableRenderPipelineExtensionAttribute : Attribute
{
    public bool inUse { get; }

    public ScriptableRenderPipelineExtensionAttribute(Type renderPipelineAsset);

}

}
