using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class MaterialProperty
{
    public ApplyPropertyCallback applyPropertyCallback { get; set; }
    public Color colorValue { get; set; }
    public string displayName { get; }
    public PropFlags flags { get; }
    public float floatValue { get; set; }
    public bool hasMixedValue { get; }
    public string name { get; }
    public Vector2 rangeLimits { get; }
    public Object[] targets { get; }
    public Rendering.TextureDimension textureDimension { get; }
    public Vector4 textureScaleAndOffset { get; set; }
    public Texture textureValue { get; set; }
    public PropType type { get; }
    public Vector4 vectorValue { get; set; }

    public MaterialProperty();

    public void ReadFromMaterialPropertyBlock(MaterialPropertyBlock block);
    public void WriteToMaterialPropertyBlock(MaterialPropertyBlock materialblock, int changedPropertyMask);

    public delegate bool ApplyPropertyCallback(UnityEditor.MaterialProperty prop, int changeMask, object previousValue);

    public enum PropType
    {
        Color = 0,
        Vector = 1,
        Float = 2,
        Range = 3,
        Texture = 4,
    }

    public enum PropFlags
    {
        None = 0,
        HideInInspector = 1,
        PerRendererData = 2,
        NoScaleOffset = 4,
        Normal = 8,
        HDR = 16,
        Gamma = 32,
        NonModifiableTextureData = 64,
    }

    public enum TexDim
    {
        Unknown = -1,
        None = 0,
        Tex2D = 2,
        Tex3D = 3,
        Cube = 4,
        Any = 6,
    }

}

}
