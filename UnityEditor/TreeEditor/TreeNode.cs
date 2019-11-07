using System;
using UnityEngine;

namespace TreeEditor
{

public class TreeNode
{
    public float angle;
    public float animSeed;
    public float baseAngle;
    public float breakOffset;
    public float capRange;
    public int groupID;
    public Matrix4x4 matrix;
    public float offset;
    public int parentID;
    public float pitch;
    public Quaternion rotation;
    public float scale;
    public int seed;
    public float size;
    public TreeEditor.TreeSpline spline;
    public int triEnd;
    public int triStart;
    public int vertEnd;
    public int vertStart;
    public bool visible;

    public int uniqueID { get; set; }

    public TreeNode();

    public Matrix4x4 GetLocalMatrixAtTime(float time);
    public void GetPropertiesAtTime(float time, out Vector3 pos, out Quaternion rot, out float rad);
    public float GetRadiusAtTime(float time);
    public float GetScale();
    public float GetSurfaceAngleAtTime(float time);

}

}
