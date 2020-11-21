using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.VFX
{

public class VisualEffect : Behaviour
{
    public Action<VFX.VFXOutputEventArgs> outputEventReceived;

    public int aliveParticleCount { get; }
    public bool culled { get; }
    public int initialEventID { get; set; }
    public string initialEventName { get; set; }
    public bool pause { get; set; }
    public float playRate { get; set; }
    public bool resetSeedOnPlay { get; set; }
    public uint startSeed { get; set; }
    public VFX.VisualEffectAsset visualEffectAsset { get; set; }

    public VisualEffect();

    public void AdvanceOneFrame();
    public VFX.VFXEventAttribute CreateVFXEventAttribute();
    public AnimationCurve GetAnimationCurve(string name);
    public AnimationCurve GetAnimationCurve(int nameID);
    public bool GetBool(string name);
    public bool GetBool(int nameID);
    public float GetFloat(string name);
    public float GetFloat(int nameID);
    public Gradient GetGradient(string name);
    public Gradient GetGradient(int nameID);
    public int GetInt(string name);
    public int GetInt(int nameID);
    public Matrix4x4 GetMatrix4x4(string name);
    public Matrix4x4 GetMatrix4x4(int nameID);
    public Mesh GetMesh(string name);
    public Mesh GetMesh(int nameID);
    public void GetOutputEventNames(List<string> names);
    public VFX.VFXParticleSystemInfo GetParticleSystemInfo(string name);
    public VFX.VFXParticleSystemInfo GetParticleSystemInfo(int nameID);
    public void GetParticleSystemNames(List<string> names);
    public SkinnedMeshRenderer GetSkinnedMeshRenderer(string name);
    public SkinnedMeshRenderer GetSkinnedMeshRenderer(int nameID);
    public VFX.VFXSpawnerState GetSpawnSystemInfo(string name);
    public VFX.VFXSpawnerState GetSpawnSystemInfo(int nameID);
    public void GetSpawnSystemInfo(int nameID, VFX.VFXSpawnerState spawnState);
    public void GetSpawnSystemNames(List<string> names);
    public void GetSystemNames(List<string> names);
    public Texture GetTexture(string name);
    public Texture GetTexture(int nameID);
    public Rendering.TextureDimension GetTextureDimension(string name);
    public Rendering.TextureDimension GetTextureDimension(int nameID);
    public uint GetUInt(string name);
    public uint GetUInt(int nameID);
    public Vector2 GetVector2(string name);
    public Vector2 GetVector2(int nameID);
    public Vector3 GetVector3(string name);
    public Vector3 GetVector3(int nameID);
    public Vector4 GetVector4(string name);
    public Vector4 GetVector4(int nameID);
    public bool HasAnimationCurve(string name);
    public bool HasAnimationCurve(int nameID);
    public bool HasBool(string name);
    public bool HasBool(int nameID);
    public bool HasFloat(string name);
    public bool HasFloat(int nameID);
    public bool HasGradient(string name);
    public bool HasGradient(int nameID);
    public bool HasInt(string name);
    public bool HasInt(int nameID);
    public bool HasMatrix4x4(string name);
    public bool HasMatrix4x4(int nameID);
    public bool HasMesh(string name);
    public bool HasMesh(int nameID);
    public bool HasSkinnedMeshRenderer(string name);
    public bool HasSkinnedMeshRenderer(int nameID);
    public bool HasSystem(string name);
    public bool HasSystem(int nameID);
    public bool HasTexture(string name);
    public bool HasTexture(int nameID);
    public bool HasUInt(string name);
    public bool HasUInt(int nameID);
    public bool HasVector2(string name);
    public bool HasVector2(int nameID);
    public bool HasVector3(string name);
    public bool HasVector3(int nameID);
    public bool HasVector4(string name);
    public bool HasVector4(int nameID);
    public void Play();
    public void Play(VFX.VFXEventAttribute eventAttribute);
    public void Reinit();
    public void ResetOverride(string name);
    public void ResetOverride(int nameID);
    public void SendEvent(string eventName);
    public void SendEvent(int eventNameID);
    public void SendEvent(string eventName, VFX.VFXEventAttribute eventAttribute);
    public void SendEvent(int eventNameID, VFX.VFXEventAttribute eventAttribute);
    public void SetAnimationCurve(string name, AnimationCurve c);
    public void SetAnimationCurve(int nameID, AnimationCurve c);
    public void SetBool(string name, bool b);
    public void SetBool(int nameID, bool b);
    public void SetFloat(string name, float f);
    public void SetFloat(int nameID, float f);
    public void SetGradient(string name, Gradient g);
    public void SetGradient(int nameID, Gradient g);
    public void SetInt(string name, int i);
    public void SetInt(int nameID, int i);
    public void SetMatrix4x4(string name, Matrix4x4 v);
    public void SetMatrix4x4(int nameID, Matrix4x4 v);
    public void SetMesh(string name, Mesh m);
    public void SetMesh(int nameID, Mesh m);
    public void SetSkinnedMeshRenderer(string name, SkinnedMeshRenderer m);
    public void SetSkinnedMeshRenderer(int nameID, SkinnedMeshRenderer m);
    public void SetTexture(string name, Texture t);
    public void SetTexture(int nameID, Texture t);
    public void SetUInt(string name, uint i);
    public void SetUInt(int nameID, uint i);
    public void SetVector2(string name, Vector2 v);
    public void SetVector2(int nameID, Vector2 v);
    public void SetVector3(string name, Vector3 v);
    public void SetVector3(int nameID, Vector3 v);
    public void SetVector4(string name, Vector4 v);
    public void SetVector4(int nameID, Vector4 v);
    public void Simulate(float stepDeltaTime, uint stepCount = 1);
    public void Stop();
    public void Stop(VFX.VFXEventAttribute eventAttribute);

}

}
