using System;
using System.Collections;
using System.Collections.Generic;
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

    public Material(string contents);
    public Material(Shader shader);
    public Material(Material source);

    public int ComputeCRC();
    public void CopyPropertiesFromMaterial(Material mat);
    public void DisableKeyword(string keyword);
    public void EnableKeyword(string keyword);
    public int FindPass(string passName);
    public Color GetColor(string name);
    public Color GetColor(int nameID);
    public Color[] GetColorArray(string name);
    public Color[] GetColorArray(int nameID);
    public void GetColorArray(string name, List<Color> values);
    public void GetColorArray(int nameID, List<Color> values);
    public float GetFloat(string name);
    public float GetFloat(int nameID);
    public float[] GetFloatArray(string name);
    public float[] GetFloatArray(int nameID);
    public void GetFloatArray(string name, List<float> values);
    public void GetFloatArray(int nameID, List<float> values);
    public int GetInt(string name);
    public int GetInt(int nameID);
    public int GetInteger(string name);
    public int GetInteger(int nameID);
    public Matrix4x4 GetMatrix(string name);
    public Matrix4x4 GetMatrix(int nameID);
    public Matrix4x4[] GetMatrixArray(string name);
    public Matrix4x4[] GetMatrixArray(int nameID);
    public void GetMatrixArray(string name, List<Matrix4x4> values);
    public void GetMatrixArray(int nameID, List<Matrix4x4> values);
    public string GetPassName(int pass);
    public bool GetShaderPassEnabled(string passName);
    public string GetTag(string tag, bool searchFallbacks);
    public string GetTag(string tag, bool searchFallbacks, string defaultValue);
    public Texture GetTexture(string name);
    public Texture GetTexture(int nameID);
    public Vector2 GetTextureOffset(string name);
    public Vector2 GetTextureOffset(int nameID);
    public int[] GetTexturePropertyNameIDs();
    public void GetTexturePropertyNameIDs(List<int> outNames);
    public string[] GetTexturePropertyNames();
    public void GetTexturePropertyNames(List<string> outNames);
    public Vector2 GetTextureScale(string name);
    public Vector2 GetTextureScale(int nameID);
    public Vector4 GetVector(string name);
    public Vector4 GetVector(int nameID);
    public Vector4[] GetVectorArray(string name);
    public Vector4[] GetVectorArray(int nameID);
    public void GetVectorArray(string name, List<Vector4> values);
    public void GetVectorArray(int nameID, List<Vector4> values);
    public bool HasBuffer(string name);
    public bool HasBuffer(int nameID);
    public bool HasColor(string name);
    public bool HasColor(int nameID);
    public bool HasConstantBuffer(string name);
    public bool HasConstantBuffer(int nameID);
    public bool HasFloat(string name);
    public bool HasFloat(int nameID);
    public bool HasInt(string name);
    public bool HasInt(int nameID);
    public bool HasInteger(string name);
    public bool HasInteger(int nameID);
    public bool HasMatrix(string name);
    public bool HasMatrix(int nameID);
    public bool HasProperty(string name);
    public bool HasProperty(int nameID);
    public bool HasTexture(string name);
    public bool HasTexture(int nameID);
    public bool HasVector(string name);
    public bool HasVector(int nameID);
    public bool IsKeywordEnabled(string keyword);
    public void Lerp(Material start, Material end, float t);
    public void SetBuffer(string name, ComputeBuffer value);
    public void SetBuffer(string name, GraphicsBuffer value);
    public void SetBuffer(int nameID, ComputeBuffer value);
    public void SetBuffer(int nameID, GraphicsBuffer value);
    public void SetColor(string name, Color value);
    public void SetColor(int nameID, Color value);
    public void SetColorArray(string name, List<Color> values);
    public void SetColorArray(string name, Color[] values);
    public void SetColorArray(int nameID, List<Color> values);
    public void SetColorArray(int nameID, Color[] values);
    public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size);
    public void SetConstantBuffer(string name, GraphicsBuffer value, int offset, int size);
    public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size);
    public void SetConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size);
    public void SetFloat(string name, float value);
    public void SetFloat(int nameID, float value);
    public void SetFloatArray(string name, List<float> values);
    public void SetFloatArray(string name, float[] values);
    public void SetFloatArray(int nameID, List<float> values);
    public void SetFloatArray(int nameID, float[] values);
    public void SetInt(string name, int value);
    public void SetInt(int nameID, int value);
    public void SetInteger(string name, int value);
    public void SetInteger(int nameID, int value);
    public void SetMatrix(string name, Matrix4x4 value);
    public void SetMatrix(int nameID, Matrix4x4 value);
    public void SetMatrixArray(string name, List<Matrix4x4> values);
    public void SetMatrixArray(string name, Matrix4x4[] values);
    public void SetMatrixArray(int nameID, List<Matrix4x4> values);
    public void SetMatrixArray(int nameID, Matrix4x4[] values);
    public void SetOverrideTag(string tag, string val);
    public bool SetPass(int pass);
    public void SetShaderPassEnabled(string passName, bool enabled);
    public void SetTexture(string name, Texture value);
    public void SetTexture(int nameID, Texture value);
    public void SetTexture(string name, RenderTexture value, Rendering.RenderTextureSubElement element);
    public void SetTexture(int nameID, RenderTexture value, Rendering.RenderTextureSubElement element);
    public void SetTextureOffset(string name, Vector2 value);
    public void SetTextureOffset(int nameID, Vector2 value);
    public void SetTextureScale(string name, Vector2 value);
    public void SetTextureScale(int nameID, Vector2 value);
    public void SetVector(string name, Vector4 value);
    public void SetVector(int nameID, Vector4 value);
    public void SetVectorArray(string name, List<Vector4> values);
    public void SetVectorArray(string name, Vector4[] values);
    public void SetVectorArray(int nameID, List<Vector4> values);
    public void SetVectorArray(int nameID, Vector4[] values);

}

}
