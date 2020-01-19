using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.U2D
{

public class SpriteShapeRenderer : Renderer
{
    public Color color { get; set; }
    public SpriteMaskInteraction maskInteraction { get; set; }

    public SpriteShapeRenderer();

    public Unity.Collections.NativeArray<Bounds> GetBounds();
    public void GetChannels(int dataSize, out Unity.Collections.NativeArray<T> indices, out Unity.Collections.NativeSlice<T> vertices, out Unity.Collections.NativeSlice<T> texcoords);
    public Unity.Collections.NativeArray<Experimental.U2D.SpriteShapeSegment> GetSegments(int dataSize);
    public void Prepare(Unity.Jobs.JobHandle handle, Experimental.U2D.SpriteShapeParameters shapeParams, Sprite[] sprites);

}

}
