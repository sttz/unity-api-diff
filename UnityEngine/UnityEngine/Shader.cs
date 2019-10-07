using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class Shader : Object
{
    static public int globalMaximumLOD { get; set; }
    static public string globalRenderPipeline { get; set; }
    static public Rendering.ShaderHardwareTier globalShaderHardwareTier { get; set; }

    static public void DisableKeyword(string keyword);
    static public void EnableKeyword(string keyword);
    static public Shader Find(string name);
    static public Color GetGlobalColor(string name);
    static public Color GetGlobalColor(int nameID);
    static public float GetGlobalFloat(string name);
    static public float GetGlobalFloat(int nameID);
    static public float[] GetGlobalFloatArray(string name);
    static public float[] GetGlobalFloatArray(int nameID);
    static public void GetGlobalFloatArray(string name, System.Collections.Generic.List<float> values);
    static public void GetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
    static public int GetGlobalInt(string name);
    static public int GetGlobalInt(int nameID);
    static public Matrix4x4 GetGlobalMatrix(string name);
    static public Matrix4x4 GetGlobalMatrix(int nameID);
    static public Matrix4x4[] GetGlobalMatrixArray(string name);
    static public Matrix4x4[] GetGlobalMatrixArray(int nameID);
    static public void GetGlobalMatrixArray(string name, System.Collections.Generic.List<Matrix4x4> values);
    static public void GetGlobalMatrixArray(int nameID, System.Collections.Generic.List<Matrix4x4> values);
    static public Texture GetGlobalTexture(string name);
    static public Texture GetGlobalTexture(int nameID);
    static public Vector4 GetGlobalVector(string name);
    static public Vector4 GetGlobalVector(int nameID);
    static public Vector4[] GetGlobalVectorArray(string name);
    static public Vector4[] GetGlobalVectorArray(int nameID);
    static public void GetGlobalVectorArray(string name, System.Collections.Generic.List<Vector4> values);
    static public void GetGlobalVectorArray(int nameID, System.Collections.Generic.List<Vector4> values);
    static public bool IsKeywordEnabled(string keyword);
    static public int PropertyToID(string name);
    static public void SetGlobalBuffer(string name, ComputeBuffer value);
    static public void SetGlobalBuffer(int nameID, ComputeBuffer value);
    static public void SetGlobalColor(string name, Color value);
    static public void SetGlobalColor(int nameID, Color value);
    static public void SetGlobalFloat(string name, float value);
    static public void SetGlobalFloat(int nameID, float value);
    static public void SetGlobalFloatArray(string name, System.Collections.Generic.List<float> values);
    static public void SetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
    static public void SetGlobalFloatArray(string name, float[] values);
    static public void SetGlobalFloatArray(int nameID, float[] values);
    static public void SetGlobalInt(string name, int value);
    static public void SetGlobalInt(int nameID, int value);
    static public void SetGlobalMatrix(string name, Matrix4x4 value);
    static public void SetGlobalMatrix(int nameID, Matrix4x4 value);
    static public void SetGlobalMatrixArray(string name, System.Collections.Generic.List<Matrix4x4> values);
    static public void SetGlobalMatrixArray(int nameID, System.Collections.Generic.List<Matrix4x4> values);
    static public void SetGlobalMatrixArray(string name, Matrix4x4[] values);
    static public void SetGlobalMatrixArray(int nameID, Matrix4x4[] values);
    static public void SetGlobalTexGenMode(string propertyName, TexGenMode mode);
    static public void SetGlobalTexture(string name, Texture value);
    static public void SetGlobalTexture(int nameID, Texture value);
    static public void SetGlobalTextureMatrixName(string propertyName, string matrixName);
    static public void SetGlobalVector(string name, Vector4 value);
    static public void SetGlobalVector(int nameID, Vector4 value);
    static public void SetGlobalVectorArray(string name, System.Collections.Generic.List<Vector4> values);
    static public void SetGlobalVectorArray(int nameID, System.Collections.Generic.List<Vector4> values);
    static public void SetGlobalVectorArray(string name, Vector4[] values);
    static public void SetGlobalVectorArray(int nameID, Vector4[] values);
    static public void WarmupAllShaders();

    public bool isSupported { get; }
    public int maximumLOD { get; set; }
    public int renderQueue { get; }

}

}
