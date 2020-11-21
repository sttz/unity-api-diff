using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{

public class ArcHandle
{
    static public void DefaultAngleHandleDrawFunction(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);
    static public float DefaultAngleHandleSizeFunction(Vector3 position);
    static public float DefaultRadiusHandleSizeFunction(Vector3 position);

    public float angle { get; set; }
    public Color angleHandleColor { get; set; }
    public CapFunction angleHandleDrawFunction { get; set; }
    public SizeFunction angleHandleSizeFunction { get; set; }
    public Color fillColor { get; set; }
    public float radius { get; set; }
    public Color radiusHandleColor { get; set; }
    public CapFunction radiusHandleDrawFunction { get; set; }
    public SizeFunction radiusHandleSizeFunction { get; set; }
    public Color wireframeColor { get; set; }

    public ArcHandle();

    public void DrawHandle();
    public void SetColorWithoutRadiusHandle(Color color, float fillColorAlpha);
    public void SetColorWithRadiusHandle(Color color, float fillColorAlpha);

}

}
