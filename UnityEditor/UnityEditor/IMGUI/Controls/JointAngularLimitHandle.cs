using System;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{

public class JointAngularLimitHandle
{
    public CapFunction angleHandleDrawFunction { get; set; }
    public SizeFunction angleHandleSizeFunction { get; set; }
    public float fillAlpha { get; set; }
    public float radius { get; set; }
    public float wireframeAlpha { get; set; }
    public Color xHandleColor { get; set; }
    public float xMax { get; set; }
    public float xMin { get; set; }
    public ConfigurableJointMotion xMotion { get; set; }
    public Vector2 xRange { get; set; }
    public Color yHandleColor { get; set; }
    public float yMax { get; set; }
    public float yMin { get; set; }
    public ConfigurableJointMotion yMotion { get; set; }
    public Vector2 yRange { get; set; }
    public Color zHandleColor { get; set; }
    public float zMax { get; set; }
    public float zMin { get; set; }
    public ConfigurableJointMotion zMotion { get; set; }
    public Vector2 zRange { get; set; }

    public JointAngularLimitHandle();

    public void DrawHandle();

}

}
