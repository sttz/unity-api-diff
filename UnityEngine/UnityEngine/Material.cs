using System;
using UnityEngine;

namespace UnityEngine
{

public class Material : Object
{
    static public Material Create(string scriptContents);

    public Color color { get; set; }
    public bool doubleSidedGI { get; set; }
    public bool enableInstancing { get; set; }
    public MaterialGlobalIlluminationFlags globalIlluminationFlags { get; set; }
    public Texture mainTexture { get; set; }
    public Vector2 mainTextureOffset { get; set; }
    public Vector2 mainTextureScale { get; set; }
    public int passCount { get; }
    public int renderQueue { get; set; }
    public Shader shader { get; set; }
    public string[] shaderKeywords { get; set; }

    public Material(Shader shader);
    public Material(Material source);
    public Material(string contents);

    public void CopyPropertiesFromMaterial(Material mat);
    public void DisableKeyword(string keyword);
    public void EnableKeyword(string keyword);
    public int FindPass(string passName);
    public Color GetColor(string name);
    public Color GetColor(int nameID);
    public Color[] GetColorArray(string name);
    public Color[] GetColorArray(int nameID);
    public void GetColorArray(string name, System.Collections.Generic.List<Color> values);
    public void GetColorArray(int nameID, System.Collections.Generic.List<Color> values);
    public float GetFloat(string name);
    public float GetFloat(int nameID);
    public float[] GetFloatArray(string name);
    public float[] GetFloatArray(int nameID);
    public void GetFloatArray(string name, System.Collections.Generic.List<float> values);
    public void GetFloatArray(int nameID, System.Collections.Generic.List<float> values);
    public int GetInt(string name);
    public int GetInt(int nameID);
    public Matrix4x4 GetMatrix(string name);
    public Matrix4x4 GetMatrix(int nameID);
    public Matrix4x4[] GetMatrixArray(string name);
    public Matrix4x4[] GetMatrixArray(int nameID);
    public void GetMatrixArray(string name, System.Collections.Generic.List<Matrix4x4> values);
    public void GetMatrixArray(int nameID, System.Collections.Generic.List<Matrix4x4> values);
    public string GetPassName(int pass);
    public bool GetShaderPassEnabled(string passName);
    public string GetTag(string tag, bool searchFallbacks, string defaultValue);
    public string GetTag(string tag, bool searchFallbacks);
    public Texture GetTexture(string name);
    public Texture GetTexture(int nameID);
    public Vector2 GetTextureOffset(string name);
    public Vector2 GetTextureOffset(int nameID);
    public int[] GetTexturePropertyNameIDs();
    public void GetTexturePropertyNameIDs(System.Collections.Generic.List<int> outNames);
    public string[] GetTexturePropertyNames();
    public void GetTexturePropertyNames(System.Collections.Generic.List<string> outNames);
    public Vector2 GetTextureScale(string name);
    public Vector2 GetTextureScale(int nameID);
    public Vector4 GetVector(string name);
    public Vector4 GetVector(int nameID);
    public Vector4[] GetVectorArray(string name);
    public Vector4[] GetVectorArray(int nameID);
    public void GetVectorArray(string name, System.Collections.Generic.List<Vector4> values);
    public void GetVectorArray(int nameID, System.Collections.Generic.List<Vector4> values);
    public bool HasProperty(int nameID);
    public bool HasProperty(string name);
    public bool IsKeywordEnabled(string keyword);
    public void Lerp(Material start, Material end, float t);
    public void SetBuffer(string name, ComputeBuffer value);
    public void SetBuffer(int nameID, ComputeBuffer value);
    public void SetColor(string name, Color value);
    public void SetColor(int nameID, Color value);
    public void SetColorArray(string name, System.Collections.Generic.List<Color> values);
    public void SetColorArray(int nameID, System.Collections.Generic.List<Color> values);
    public void SetColorArray(string name, Color[] values);
    public void SetColorArray(int nameID, Color[] values);
    public void SetFloat(string name, float value);
    public void SetFloat(int nameID, float value);
    public void SetFloatArray(string name, System.Collections.Generic.List<float> values);
    public void SetFloatArray(int nameID, System.Collections.Generic.List<float> values);
    public void SetFloatArray(string name, float[] values);
    public void SetFloatArray(int nameID, float[] values);
    public void SetInt(string name, int value);
    public void SetInt(int nameID, int value);
    public void SetMatrix(string name, Matrix4x4 value);
    public void SetMatrix(int nameID, Matrix4x4 value);
    public void SetMatrixArray(string name, System.Collections.Generic.List<Matrix4x4> values);
    public void SetMatrixArray(int nameID, System.Collections.Generic.List<Matrix4x4> values);
    public void SetMatrixArray(string name, Matrix4x4[] values);
    public void SetMatrixArray(int nameID, Matrix4x4[] values);
    public void SetOverrideTag(string tag, string val);
    public bool SetPass(int pass);
    public void SetShaderPassEnabled(string passName, bool enabled);
    public void SetTexture(string name, Texture value);
    public void SetTexture(int nameID, Texture value);
    public void SetTextureOffset(string name, Vector2 value);
    public void SetTextureOffset(int nameID, Vector2 value);
    public void SetTextureScale(string name, Vector2 value);
    public void SetTextureScale(int nameID, Vector2 value);
    public void SetVector(string name, Vector4 value);
    public void SetVector(int nameID, Vector4 value);
    public void SetVectorArray(string name, System.Collections.Generic.List<Vector4> values);
    public void SetVectorArray(int nameID, System.Collections.Generic.List<Vector4> values);
    public void SetVectorArray(string name, Vector4[] values);
    public void SetVectorArray(int nameID, Vector4[] values);

}

}
