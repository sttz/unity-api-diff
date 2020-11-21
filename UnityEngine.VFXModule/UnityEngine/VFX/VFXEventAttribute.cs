using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.VFX
{

public sealed class VFXEventAttribute : IDisposable
{
    public VFXEventAttribute(VFX.VFXEventAttribute original);

    public void CopyValuesFrom(VFX.VFXEventAttribute eventAttibute);
    public void Dispose();
    public bool GetBool(string name);
    public bool GetBool(int nameID);
    public float GetFloat(string name);
    public float GetFloat(int nameID);
    public int GetInt(string name);
    public int GetInt(int nameID);
    public Matrix4x4 GetMatrix4x4(string name);
    public Matrix4x4 GetMatrix4x4(int nameID);
    public uint GetUint(string name);
    public uint GetUint(int nameID);
    public Vector2 GetVector2(string name);
    public Vector2 GetVector2(int nameID);
    public Vector3 GetVector3(string name);
    public Vector3 GetVector3(int nameID);
    public Vector4 GetVector4(string name);
    public Vector4 GetVector4(int nameID);
    public bool HasBool(string name);
    public bool HasBool(int nameID);
    public bool HasFloat(string name);
    public bool HasFloat(int nameID);
    public bool HasInt(string name);
    public bool HasInt(int nameID);
    public bool HasMatrix4x4(string name);
    public bool HasMatrix4x4(int nameID);
    public bool HasUint(string name);
    public bool HasUint(int nameID);
    public bool HasVector2(string name);
    public bool HasVector2(int nameID);
    public bool HasVector3(string name);
    public bool HasVector3(int nameID);
    public bool HasVector4(string name);
    public bool HasVector4(int nameID);
    public void SetBool(string name, bool b);
    public void SetBool(int nameID, bool b);
    public void SetFloat(string name, float f);
    public void SetFloat(int nameID, float f);
    public void SetInt(string name, int i);
    public void SetInt(int nameID, int i);
    public void SetMatrix4x4(string name, Matrix4x4 v);
    public void SetMatrix4x4(int nameID, Matrix4x4 v);
    public void SetUint(string name, uint i);
    public void SetUint(int nameID, uint i);
    public void SetVector2(string name, Vector2 v);
    public void SetVector2(int nameID, Vector2 v);
    public void SetVector3(string name, Vector3 v);
    public void SetVector3(int nameID, Vector3 v);
    public void SetVector4(string name, Vector4 v);
    public void SetVector4(int nameID, Vector4 v);

}

}
