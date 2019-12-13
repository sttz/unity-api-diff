using System;
using UnityEngine;

namespace UnityEngine.U2D
{

public static class SpriteDataAccessExtensions
{
    static public Unity.Collections.NativeArray<Matrix4x4> GetBindPoses(Sprite sprite);
    static public U2D.SpriteBone[] GetBones(Sprite sprite);
    static public Unity.Collections.NativeArray<ushort> GetIndices(Sprite sprite);
    static public Unity.Collections.NativeSlice<T> GetVertexAttribute(Sprite sprite, Rendering.VertexAttribute channel);
    static public int GetVertexCount(Sprite sprite);
    static public bool HasVertexAttribute(Sprite sprite, Rendering.VertexAttribute channel);
    static public void SetBindPoses(Sprite sprite, Unity.Collections.NativeArray<Matrix4x4> src);
    static public void SetBones(Sprite sprite, U2D.SpriteBone[] src);
    static public void SetIndices(Sprite sprite, Unity.Collections.NativeArray<ushort> src);
    static public void SetVertexAttribute(Sprite sprite, Rendering.VertexAttribute channel, Unity.Collections.NativeArray<T> src);
    static public void SetVertexCount(Sprite sprite, int count);

}

}