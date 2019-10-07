using System;
using UnityEngine;

namespace UnityEngine.Experimental.VFX
{

public class VisualEffect : Behaviour
{
    public int aliveParticleCount { get; }
    public bool culled { get; }
    public bool pause { get; set; }
    public float playRate { get; set; }
    public bool resetSeedOnPlay { get; set; }
    public uint startSeed { get; set; }
    public Experimental.VFX.VisualEffectAsset visualEffectAsset { get; set; }

    public VisualEffect();

    public void AdvanceOneFrame();
    public Experimental.VFX.VFXEventAttribute CreateVFXEventAttribute();
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
    public Rendering.TextureDimension GetTextureDimension(int nameID);
    public Rendering.TextureDimension GetTextureDimension(string name);
    public uint GetUInt(int nameID);
    public uint GetUInt(string name);
    public Vector2 GetVector2(int nameID);
    public Vector2 GetVector2(string name);
    public Vector3 GetVector3(int nameID);
    public Vector3 GetVector3(string name);
    public Vector4 GetVector4(int nameID);
    public Vector4 GetVector4(string name);
    public bool HasAnimationCurve(int nameID);
    public bool HasAnimationCurve(string name);
    public bool HasBool(int nameID);
    public bool HasBool(string name);
    public bool HasFloat(int nameID);
    public bool HasFloat(string name);
    public bool HasGradient(int nameID);
    public bool HasGradient(string name);
    public bool HasInt(int nameID);
    public bool HasInt(string name);
    public bool HasMatrix4x4(int nameID);
    public bool HasMatrix4x4(string name);
    public bool HasMesh(int nameID);
    public bool HasMesh(string name);
    public bool HasTexture(int nameID);
    public bool HasTexture(string name);
    public bool HasUInt(int nameID);
    public bool HasUInt(string name);
    public bool HasVector2(int nameID);
    public bool HasVector2(string name);
    public bool HasVector3(int nameID);
    public bool HasVector3(string name);
    public bool HasVector4(int nameID);
    public bool HasVector4(string name);
    public void Play(Experimental.VFX.VFXEventAttribute eventAttribute);
    public void Play();
    public void Reinit();
    public void ResetOverride(int nameID);
    public void ResetOverride(string name);
    public void SendEvent(int eventNameID, Experimental.VFX.VFXEventAttribute eventAttribute);
    public void SendEvent(string eventName);
    public void SendEvent(string eventName, Experimental.VFX.VFXEventAttribute eventAttribute);
    public void SetAnimationCurve(int nameID, AnimationCurve c);
    public void SetAnimationCurve(string name, AnimationCurve c);
    public void SetBool(int nameID, bool b);
    public void SetBool(string name, bool b);
    public void SetFloat(int nameID, float f);
    public void SetFloat(string name, float f);
    public void SetGradient(int nameID, Gradient g);
    public void SetGradient(string name, Gradient g);
    public void SetInt(int nameID, int i);
    public void SetInt(string name, int i);
    public void SetMatrix4x4(int nameID, Matrix4x4 v);
    public void SetMatrix4x4(string name, Matrix4x4 v);
    public void SetMesh(int nameID, Mesh m);
    public void SetMesh(string name, Mesh m);
    public void SetTexture(int nameID, Texture t);
    public void SetTexture(string name, Texture t);
    public void SetUInt(int nameID, uint i);
    public void SetUInt(string name, uint i);
    public void SetVector2(int nameID, Vector2 v);
    public void SetVector2(string name, Vector2 v);
    public void SetVector3(int nameID, Vector3 v);
    public void SetVector3(string name, Vector3 v);
    public void SetVector4(int nameID, Vector4 v);
    public void SetVector4(string name, Vector4 v);
    public void Simulate(float stepDeltaTime, uint stepCount = 1);
    public void Stop(Experimental.VFX.VFXEventAttribute eventAttribute);
    public void Stop();

}

}
