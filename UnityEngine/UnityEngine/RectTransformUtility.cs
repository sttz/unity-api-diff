using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class RectTransformUtility
{
    static public Bounds CalculateRelativeRectTransformBounds(Transform root, Transform child);
    static public Bounds CalculateRelativeRectTransformBounds(Transform trans);
    static public void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive);
    static public void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive);
    static public Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas);
    static public Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas);
    static public bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint);
    static public bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam);
    static public bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint);
    static public Ray ScreenPointToRay(Camera cam, Vector2 screenPos);
    static public bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint);
    static public Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint);

}

}
