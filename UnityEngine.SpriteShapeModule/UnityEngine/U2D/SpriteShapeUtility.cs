using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.U2D
{

public class SpriteShapeUtility
{
    static public int[] Generate(Mesh mesh, U2D.SpriteShapeParameters shapeParams, U2D.ShapeControlPoint[] points, U2D.SpriteShapeMetaData[] metaData, U2D.AngleRangeInfo[] angleRange, Sprite[] sprites, Sprite[] corners);
    static public void GenerateSpriteShape(U2D.SpriteShapeRenderer renderer, U2D.SpriteShapeParameters shapeParams, U2D.ShapeControlPoint[] points, U2D.SpriteShapeMetaData[] metaData, U2D.AngleRangeInfo[] angleRange, Sprite[] sprites, Sprite[] corners);

    public SpriteShapeUtility();

}

}
