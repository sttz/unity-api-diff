using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class ComputeShader : Object
{
    public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
    public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer, uint argsOffset);
    public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer);
    public int FindKernel(string name);
    public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z);
    public bool HasKernel(string name);
    public void SetBool(string name, bool val);
    public void SetBool(int nameID, bool val);
    public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer);
    public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer);
    public void SetFloat(int nameID, float val);
    public void SetFloat(string name, float val);
    public void SetFloats(string name, float[] values);
    public void SetFloats(int nameID, float[] values);
    public void SetInt(int nameID, int val);
    public void SetInt(string name, int val);
    public void SetInts(string name, int[] values);
    public void SetInts(int nameID, int[] values);
    public void SetMatrix(int nameID, Matrix4x4 val);
    public void SetMatrix(string name, Matrix4x4 val);
    public void SetMatrixArray(int nameID, Matrix4x4[] values);
    public void SetMatrixArray(string name, Matrix4x4[] values);
    public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel);
    public void SetTexture(int kernelIndex, int nameID, Texture texture);
    public void SetTexture(int kernelIndex, string name, Texture texture);
    public void SetTexture(int kernelIndex, string name, Texture texture, int mipLevel);
    public void SetTexture(int kernelIndex, int nameID, RenderTexture texture, int mipLevel, Rendering.RenderTextureSubElement element);
    public void SetTexture(int kernelIndex, string name, RenderTexture texture, int mipLevel, Rendering.RenderTextureSubElement element);
    public void SetTextureFromGlobal(int kernelIndex, int nameID, int globalTextureNameID);
    public void SetTextureFromGlobal(int kernelIndex, string name, string globalTextureName);
    public void SetVector(int nameID, Vector4 val);
    public void SetVector(string name, Vector4 val);
    public void SetVectorArray(int nameID, Vector4[] values);
    public void SetVectorArray(string name, Vector4[] values);

}

}
