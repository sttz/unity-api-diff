using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct DrawingSettings : IEquatable<Rendering.DrawingSettings>
{
    static public int maxShaderPasses;

    public bool enableDynamicBatching { get; set; }
    public bool enableInstancing { get; set; }
    public int mainLightIndex { get; set; }
    public Material overrideMaterial { get; set; }
    public int overrideMaterialPassIndex { get; set; }
    public Rendering.PerObjectData perObjectData { get; set; }
    public Rendering.SortingSettings sortingSettings { get; set; }

    public DrawingSettings(Rendering.ShaderTagId shaderPassName, Rendering.SortingSettings sortingSettings);

    public bool Equals(Rendering.DrawingSettings other);
    public bool Equals(object obj);
    public int GetHashCode();
    public Rendering.ShaderTagId GetShaderPassName(int index);
    public void SetShaderPassName(int index, Rendering.ShaderTagId shaderPassName);

    public struct <shaderPassNames>e__FixedBuffer
    {
        public int FixedElementField;

    }

}

}
