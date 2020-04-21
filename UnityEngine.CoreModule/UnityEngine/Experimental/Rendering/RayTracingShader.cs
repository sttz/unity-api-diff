using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public sealed class RayTracingShader : Object
{
    public float maxRecursionDepth { get; }

    public void Dispatch(string rayGenFunctionName, int width, int height, int depth, Camera camera = null);
    public void SetAccelerationStructure(string name, Experimental.Rendering.RayTracingAccelerationStructure accelerationStructure);
    public void SetAccelerationStructure(int nameID, Experimental.Rendering.RayTracingAccelerationStructure accelerationStrucure);
    public void SetBool(string name, bool val);
    public void SetBool(int nameID, bool val);
    public void SetBuffer(int nameID, ComputeBuffer buffer);
    public void SetBuffer(int nameID, GraphicsBuffer buffer);
    public void SetBuffer(string resourceName, ComputeBuffer buffer);
    public void SetBuffer(string resourceName, GraphicsBuffer buffer);
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
    public void SetShaderPass(string passName);
    public void SetTexture(int nameID, Texture texture);
    public void SetTexture(string resourceName, Texture texture);
    public void SetTextureFromGlobal(int nameID, int globalTextureNameID);
    public void SetTextureFromGlobal(string resourceName, string globalTextureName);
    public void SetVector(string name, Vector4 val);
    public void SetVector(int nameID, Vector4 val);
    public void SetVectorArray(string name, Vector4[] values);
    public void SetVectorArray(int nameID, Vector4[] values);

}

}
