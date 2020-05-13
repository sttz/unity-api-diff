using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class ComputeShader : Object
{
    public string[] shaderKeywords { get; set; }

    public void DisableKeyword(string keyword);
    public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
    public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer);
    public void DispatchIndirect(int kernelIndex, GraphicsBuffer argsBuffer);
    public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer, uint argsOffset);
    public void DispatchIndirect(int kernelIndex, GraphicsBuffer argsBuffer, uint argsOffset);
    public void EnableKeyword(string keyword);
    public int FindKernel(string name);
    public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z);
    public bool HasKernel(string name);
    public bool IsKeywordEnabled(string keyword);
    public void SetBool(string name, bool val);
    public void SetBool(int nameID, bool val);
    public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer);
    public void SetBuffer(int kernelIndex, string name, GraphicsBuffer buffer);
    public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer);
    public void SetBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer);
    public void SetConstantBuffer(string name, ComputeBuffer buffer, int offset, int size);
    public void SetConstantBuffer(string name, GraphicsBuffer buffer, int offset, int size);
    public void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size);
    public void SetConstantBuffer(int nameID, GraphicsBuffer buffer, int offset, int size);
    public void SetFloat(string name, float val);
    public void SetFloat(int nameID, float val);
    public void SetFloats(string name, float[] values);
    public void SetFloats(int nameID, float[] values);
    public void SetInt(string name, int val);
    public void SetInt(int nameID, int val);
    public void SetInts(string name, int[] values);
    public void SetInts(int nameID, int[] values);
    public void SetMatrix(string name, Matrix4x4 val);
    public void SetMatrix(int nameID, Matrix4x4 val);
    public void SetMatrixArray(string name, Matrix4x4[] values);
    public void SetMatrixArray(int nameID, Matrix4x4[] values);
    public void SetTexture(int kernelIndex, string name, Texture texture);
    public void SetTexture(int kernelIndex, int nameID, Texture texture);
    public void SetTexture(int kernelIndex, string name, Texture texture, int mipLevel);
    public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel);
    public void SetTexture(int kernelIndex, string name, RenderTexture texture, int mipLevel, Rendering.RenderTextureSubElement element);
    public void SetTexture(int kernelIndex, int nameID, RenderTexture texture, int mipLevel, Rendering.RenderTextureSubElement element);
    public void SetTextureFromGlobal(int kernelIndex, string name, string globalTextureName);
    public void SetTextureFromGlobal(int kernelIndex, int nameID, int globalTextureNameID);
    public void SetVector(string name, Vector4 val);
    public void SetVector(int nameID, Vector4 val);
    public void SetVectorArray(string name, Vector4[] values);
    public void SetVectorArray(int nameID, Vector4[] values);

}

}
