using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class ShaderUtil
{
    static public bool allowAsyncCompilation { get; set; }
    static public bool anythingCompiling { get; }
    static public bool hardwareSupportsRectRenderTexture { get; }

    static public void ClearCachedData(Shader s);
    static public void ClearShaderErrors(Shader s);
    static public void ClearShaderMessages(Shader s);
    static public void CompilePass(Material material, int pass, bool forceSync = false);
    static public Shader CreateShaderAsset(string source, bool compileInitialShaderVariants);
    static public Shader CreateShaderAsset(string source);
    static public UnityEditor.ShaderInfo[] GetAllShaderInfo();
    static public int GetCallableShaderCount(Experimental.Rendering.RayTracingShader s);
    static public string GetCallableShaderName(Experimental.Rendering.RayTracingShader s, int shaderIndex);
    static public int GetCallableShaderParamSize(Experimental.Rendering.RayTracingShader s, int shaderIndex);
    static public int GetComputeShaderMessageCount(ComputeShader s);
    static public UnityEditor.ShaderMessage[] GetComputeShaderMessages(ComputeShader s);
    static public int GetMissShaderCount(Experimental.Rendering.RayTracingShader s);
    static public string GetMissShaderName(Experimental.Rendering.RayTracingShader s, int shaderIndex);
    static public int GetMissShaderRayPayloadSize(Experimental.Rendering.RayTracingShader s, int shaderIndex);
    static public int GetPropertyCount(Shader s);
    static public string GetPropertyDescription(Shader s, int propertyIdx);
    static public string GetPropertyName(Shader s, int propertyIdx);
    static public ShaderPropertyType GetPropertyType(Shader s, int propertyIdx);
    static public float GetRangeLimits(Shader s, int propertyIdx, int defminmax);
    static public int GetRayGenerationShaderCount(Experimental.Rendering.RayTracingShader s);
    static public string GetRayGenerationShaderName(Experimental.Rendering.RayTracingShader s, int shaderIndex);
    static public int GetRayTracingShaderMessageCount(Experimental.Rendering.RayTracingShader s);
    static public UnityEditor.ShaderMessage[] GetRayTracingShaderMessages(Experimental.Rendering.RayTracingShader s);
    static public UnityEditor.ShaderData GetShaderData(Shader shader);
    static public int GetShaderMessageCount(Shader s);
    static public UnityEditor.ShaderMessage[] GetShaderMessages(Shader s);
    static public Rendering.TextureDimension GetTexDim(Shader s, int propertyIdx);
    static public bool IsPassCompiled(Material material, int pass);
    static public bool IsShaderPropertyHidden(Shader s, int propertyIdx);
    static public bool IsShaderPropertyNonModifiableTexureProperty(Shader s, int propertyIdx);
    static public void RegisterShader(Shader shader);
    static public void RestoreAsyncCompilation(Rendering.CommandBuffer cmd);
    static public void SetAsyncCompilation(Rendering.CommandBuffer cmd, bool allow);
    static public bool ShaderHasError(Shader shader);
    static public void UpdateShaderAsset(Shader shader, string source, bool compileInitialShaderVariants);
    static public void UpdateShaderAsset(Shader shader, string source);

    public ShaderUtil();

    public enum ShaderPropertyTexDim
    {
        TexDimNone = 0,
        TexDim2D = 2,
        TexDim3D = 3,
        TexDimCUBE = 4,
        TexDimAny = 6,
    }

    public enum ShaderPropertyType
    {
        Color = 0,
        Vector = 1,
        Float = 2,
        Range = 3,
        TexEnv = 4,
    }

}

}
