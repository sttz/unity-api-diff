using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class RectTransform : Transform
{
    static public event ReapplyDrivenProperties reapplyDrivenProperties;

    public Vector2 anchoredPosition { get; set; }
    public Vector3 anchoredPosition3D { get; set; }
    public Vector2 anchorMax { get; set; }
    public Vector2 anchorMin { get; set; }
    public Object drivenByObject { get; internal set; }
    public Vector2 offsetMax { get; set; }
    public Vector2 offsetMin { get; set; }
    public Vector2 pivot { get; set; }
    public Rect rect { get; }
    public Vector2 sizeDelta { get; set; }

    public RectTransform();

    public void ForceUpdateRectTransforms();
    public void GetLocalCorners(Vector3[] fourCornersArray);
    public void GetWorldCorners(Vector3[] fourCornersArray);
    public void SetInsetAndSizeFromParentEdge(Edge edge, float inset, float size);
    public void SetSizeWithCurrentAnchors(Axis axis, float size);

    public enum Axis
    {
        Horizontal = 0,
        Vertical = 1,
    }

    public enum Edge
    {
        Left = 0,
        Right = 1,
        Top = 2,
        Bottom = 3,
    }

    public delegate void ReapplyDrivenProperties(RectTransform driven);

}

}
