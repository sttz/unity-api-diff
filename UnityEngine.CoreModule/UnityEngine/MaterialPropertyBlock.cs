using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class MaterialPropertyBlock
{
    public bool isEmpty { get; }

    public MaterialPropertyBlock();

    public void AddColor(string name, Color value);
    public void AddColor(int nameID, Color value);
    public void AddFloat(string name, float value);
    public void AddFloat(int nameID, float value);
    public void AddMatrix(string name, Matrix4x4 value);
    public void AddMatrix(int nameID, Matrix4x4 value);
    public void AddTexture(string name, Texture value);
    public void AddTexture(int nameID, Texture value);
    public void AddVector(string name, Vector4 value);
    public void AddVector(int nameID, Vector4 value);
    public void Clear();
    public void CopyProbeOcclusionArrayFrom(List<Vector4> occlusionProbes);
    public void CopyProbeOcclusionArrayFrom(Vector4[] occlusionProbes);
    public void CopyProbeOcclusionArrayFrom(List<Vector4> occlusionProbes, int sourceStart, int destStart, int count);
    public void CopyProbeOcclusionArrayFrom(Vector4[] occlusionProbes, int sourceStart, int destStart, int count);
    public void CopySHCoefficientArraysFrom(List<Rendering.SphericalHarmonicsL2> lightProbes);
    public void CopySHCoefficientArraysFrom(Rendering.SphericalHarmonicsL2[] lightProbes);
    public void CopySHCoefficientArraysFrom(List<Rendering.SphericalHarmonicsL2> lightProbes, int sourceStart, int destStart, int count);
    public void CopySHCoefficientArraysFrom(Rendering.SphericalHarmonicsL2[] lightProbes, int sourceStart, int destStart, int count);
    public Color GetColor(string name);
    public Color GetColor(int nameID);
    public float GetFloat(string name);
    public float GetFloat(int nameID);
    public float[] GetFloatArray(string name);
    public float[] GetFloatArray(int nameID);
    public void GetFloatArray(string name, List<float> values);
    public void GetFloatArray(int nameID, List<float> values);
    public int GetInt(string name);
    public int GetInt(int nameID);
    public Matrix4x4 GetMatrix(string name);
    public Matrix4x4 GetMatrix(int nameID);
    public Matrix4x4[] GetMatrixArray(string name);
    public Matrix4x4[] GetMatrixArray(int nameID);
    public void GetMatrixArray(string name, List<Matrix4x4> values);
    public void GetMatrixArray(int nameID, List<Matrix4x4> values);
    public Texture GetTexture(string name);
    public Texture GetTexture(int nameID);
    public Vector4 GetVector(string name);
    public Vector4 GetVector(int nameID);
    public Vector4[] GetVectorArray(string name);
    public Vector4[] GetVectorArray(int nameID);
    public void GetVectorArray(string name, List<Vector4> values);
    public void GetVectorArray(int nameID, List<Vector4> values);
    public void SetBuffer(string name, ComputeBuffer value);
    public void SetBuffer(int nameID, ComputeBuffer value);
    public void SetColor(string name, Color value);
    public void SetColor(int nameID, Color value);
    public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size);
    public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size);
    public void SetFloat(string name, float value);
    public void SetFloat(int nameID, float value);
    public void SetFloatArray(string name, List<float> values);
    public void SetFloatArray(string name, float[] values);
    public void SetFloatArray(int nameID, List<float> values);
    public void SetFloatArray(int nameID, float[] values);
    public void SetInt(string name, int value);
    public void SetInt(int nameID, int value);
    public void SetMatrix(string name, Matrix4x4 value);
    public void SetMatrix(int nameID, Matrix4x4 value);
    public void SetMatrixArray(string name, List<Matrix4x4> values);
    public void SetMatrixArray(string name, Matrix4x4[] values);
    public void SetMatrixArray(int nameID, List<Matrix4x4> values);
    public void SetMatrixArray(int nameID, Matrix4x4[] values);
    public void SetTexture(string name, Texture value);
    public void SetTexture(int nameID, Texture value);
    public void SetTexture(string name, RenderTexture value, Rendering.RenderTextureSubElement element);
    public void SetTexture(int nameID, RenderTexture value, Rendering.RenderTextureSubElement element);
    public void SetVector(string name, Vector4 value);
    public void SetVector(int nameID, Vector4 value);
    public void SetVectorArray(string name, List<Vector4> values);
    public void SetVectorArray(string name, Vector4[] values);
    public void SetVectorArray(int nameID, List<Vector4> values);
    public void SetVectorArray(int nameID, Vector4[] values);

}

}
