using System;
using UnityEngine;

namespace UnityEngine.U2D
{

public class SpriteShapeRenderer : Renderer
{
    public Color color { get; set; }
    public SpriteMaskInteraction maskInteraction { get; set; }

    public SpriteShapeRenderer();

    public Unity.Collections.NativeArray<Bounds> GetBounds();
    public void GetChannels(int dataSize, out Unity.Collections.NativeArray<T> indices, out Unity.Collections.NativeSlice<T> vertices, out Unity.Collections.NativeSlice<T> texcoords);
    public void GetChannels(int dataSize, out Unity.Collections.NativeArray<T> indices, out Unity.Collections.NativeSlice<T> vertices, out Unity.Collections.NativeSlice<T> texcoords, out Unity.Collections.NativeSlice<T> tangents);
    public void GetChannels(int dataSize, out Unity.Collections.NativeArray<T> indices, out Unity.Collections.NativeSlice<T> vertices, out Unity.Collections.NativeSlice<T> texcoords, out Unity.Collections.NativeSlice<T> tangents, out Unity.Collections.NativeSlice<T> normals);
    public Unity.Collections.NativeArray<U2D.SpriteShapeSegment> GetSegments(int dataSize);
    public void Prepare(Unity.Jobs.JobHandle handle, U2D.SpriteShapeParameters shapeParams, Sprite[] sprites);

}

}
