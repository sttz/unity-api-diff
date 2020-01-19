using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.U2D
{

public static class SpriteDataAccessExtensions
{
    static public Unity.Collections.NativeArray<Matrix4x4> GetBindPoses(Sprite sprite);
    static public Experimental.U2D.SpriteBone[] GetBones(Sprite sprite);
    static public Unity.Collections.NativeArray<BoneWeight> GetBoneWeights(Sprite sprite);
    static public Unity.Collections.NativeArray<ushort> GetIndices(Sprite sprite);
    static public Unity.Collections.NativeSlice<T> GetVertexAttribute<T>(Sprite sprite, Rendering.VertexAttribute channel);
    static public int GetVertexCount(Sprite sprite);
    static public bool HasVertexAttribute(Sprite sprite, Rendering.VertexAttribute channel);
    static public void SetBindPoses(Sprite sprite, Unity.Collections.NativeArray<Matrix4x4> src);
    static public void SetBones(Sprite sprite, Experimental.U2D.SpriteBone[] src);
    static public void SetBoneWeights(Sprite sprite, Unity.Collections.NativeArray<BoneWeight> src);
    static public void SetIndices(Sprite sprite, Unity.Collections.NativeArray<ushort> src);
    static public void SetVertexAttribute<T>(Sprite sprite, Rendering.VertexAttribute channel, Unity.Collections.NativeArray<T> src);
    static public void SetVertexCount(Sprite sprite, int count);

}

}
