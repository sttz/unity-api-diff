using System;
using UnityEngine;

namespace UnityEngine.Experimental.U2D
{

public class SpriteShapeUtility
{
    static public int[] Generate(Mesh mesh, Experimental.U2D.SpriteShapeParameters shapeParams, Experimental.U2D.ShapeControlPoint[] points, Experimental.U2D.SpriteShapeMetaData[] metaData, Experimental.U2D.AngleRangeInfo[] angleRange, Sprite[] sprites, Sprite[] corners);
    static public void GenerateSpriteShape(Experimental.U2D.SpriteShapeRenderer renderer, Experimental.U2D.SpriteShapeParameters shapeParams, Experimental.U2D.ShapeControlPoint[] points, Experimental.U2D.SpriteShapeMetaData[] metaData, Experimental.U2D.AngleRangeInfo[] angleRange, Sprite[] sprites, Sprite[] corners);

    public SpriteShapeUtility();

}

}
