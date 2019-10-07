using System;
using UnityEngine;

namespace UnityEngine.Experimental.VFX
{

public class VFXExpressionValues
{
    public AnimationCurve GetAnimationCurve(int nameID);
    public AnimationCurve GetAnimationCurve(string name);
    public bool GetBool(int nameID);
    public bool GetBool(string name);
    public float GetFloat(int nameID);
    public float GetFloat(string name);
    public Gradient GetGradient(int nameID);
    public Gradient GetGradient(string name);
    public int GetInt(int nameID);
    public int GetInt(string name);
    public Matrix4x4 GetMatrix4x4(int nameID);
    public Matrix4x4 GetMatrix4x4(string name);
    public Mesh GetMesh(int nameID);
    public Mesh GetMesh(string name);
    public Texture GetTexture(int nameID);
    public Texture GetTexture(string name);
    public uint GetUInt(int nameID);
    public uint GetUInt(string name);
    public Vector2 GetVector2(int nameID);
    public Vector2 GetVector2(string name);
    public Vector3 GetVector3(int nameID);
    public Vector3 GetVector3(string name);
    public Vector4 GetVector4(int nameID);
    public Vector4 GetVector4(string name);

}

}
