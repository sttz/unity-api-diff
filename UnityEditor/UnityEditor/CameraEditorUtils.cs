using System;
using UnityEngine;

namespace UnityEditor
{

public static class CameraEditorUtils
{
    static public float GameViewAspectRatio { get; }

    static public void DrawFrustumGizmo(Camera camera);
    static public float GetFrustumAspectRatio(Camera camera);
    static public void GetFrustumPlaneAt(Matrix4x4 clipToWorld, Vector3 viewPosition, float distance, Vector3[] points);
    static public void HandleFrustum(Camera c, int cameraEditorTargetIndex);
    static public bool IsViewportRectValidToRender(Rect normalizedViewPortRect);
    static public Vector3 PerspectiveClipToWorld(Matrix4x4 clipToWorld, Vector3 viewPositionWS, Vector3 positionCS);
    static public bool TryGetFrustum(Camera camera, Vector3[] near, Vector3[] far, out float frustumAspect);
    static public bool TryGetSensorGateFrustum(Camera camera, Vector3[] near, Vector3[] far, out float frustumAspect);

}

}
