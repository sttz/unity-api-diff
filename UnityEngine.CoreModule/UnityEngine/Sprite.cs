using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class Sprite : Object
{
    static public Sprite Create(Texture2D texture, Rect rect, Vector2 pivot);
    static public Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit);
    static public Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude);
    static public Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType);
    static public Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border);
    static public Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape);

    public Texture2D associatedAlphaSplitTexture { get; }
    public Vector4 border { get; }
    public Bounds bounds { get; }
    public bool packed { get; }
    public SpritePackingMode packingMode { get; }
    public SpritePackingRotation packingRotation { get; }
    public Vector2 pivot { get; }
    public float pixelsPerUnit { get; }
    public Rect rect { get; }
    public Texture2D texture { get; }
    public Rect textureRect { get; }
    public Vector2 textureRectOffset { get; }
    public ushort[] triangles { get; }
    public Vector2[] uv { get; }
    public Vector2[] vertices { get; }

    public int GetPhysicsShape(int shapeIdx, List<Vector2> physicsShape);
    public int GetPhysicsShapeCount();
    public int GetPhysicsShapePointCount(int shapeIdx);
    public void OverrideGeometry(Vector2[] vertices, ushort[] triangles);
    public void OverridePhysicsShape(IList<Vector2[]> physicsShapes);

}

}
