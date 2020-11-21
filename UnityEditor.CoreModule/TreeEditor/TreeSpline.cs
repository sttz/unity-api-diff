using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TreeEditor
{

public class TreeSpline
{
    public TreeEditor.SplineNode[] nodes;
    public float tension;

    public TreeSpline();
    public TreeSpline(TreeEditor.TreeSpline o);

    public void AddPoint(Vector3 pos, float timeInSeconds);
    public float GetApproximateLength();
    public int GetNodeCount();
    public TreeEditor.SplineNode[] GetNodes();
    public Vector3 GetPositionAtTime(float timeParam);
    public Quaternion GetRotationAtTime(float timeParam);
    public void RemoveNode(int c);
    public void Reset();
    public void SetNodeCount(int c);
    public void UpdateRotations();
    public void UpdateTime();

}

}
