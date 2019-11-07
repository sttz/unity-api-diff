using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class ShaderUtil
{
    static public bool hardwareSupportsRectRenderTexture { get; }

    static public void ClearShaderErrors(Shader s);
    static public Shader CreateShaderAsset(string source);
    static public UnityEditor.ShaderInfo[] GetAllShaderInfo();
    static public int GetPropertyCount(Shader s);
    static public string GetPropertyDescription(Shader s, int propertyIdx);
    static public string GetPropertyName(Shader s, int propertyIdx);
    static public ShaderPropertyType GetPropertyType(Shader s, int propertyIdx);
    static public float GetRangeLimits(Shader s, int propertyIdx, int defminmax);
    static public UnityEditor.ShaderData GetShaderData(Shader shader);
    static public Rendering.TextureDimension GetTexDim(Shader s, int propertyIdx);
    static public bool IsShaderPropertyHidden(Shader s, int propertyIdx);
    static public bool IsShaderPropertyNonModifiableTexureProperty(Shader s, int propertyIdx);
    static public void RegisterShader(Shader shader);
    static public void UpdateShaderAsset(Shader shader, string source);

    public ShaderUtil();

    public enum ShaderPropertyType
    {
        Color = 0,
        Vector = 1,
        Float = 2,
        Range = 3,
        TexEnv = 4,
    }

    public enum ShaderPropertyTexDim
    {
        TexDimNone = 0,
        TexDim2D = 2,
        TexDim3D = 3,
        TexDimCUBE = 4,
        TexDimAny = 6,
    }

}

}
