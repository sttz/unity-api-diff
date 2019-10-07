using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public static class VisualElementExtensions
{
    static public void AddManipulator(UIElements.VisualElement ele, UIElements.IManipulator manipulator);
    static public Vector2 ChangeCoordinatesTo(UIElements.VisualElement src, UIElements.VisualElement dest, Vector2 point);
    static public Rect ChangeCoordinatesTo(UIElements.VisualElement src, UIElements.VisualElement dest, Rect rect);
    static public Vector2 LocalToWorld(UIElements.VisualElement ele, Vector2 p);
    static public Rect LocalToWorld(UIElements.VisualElement ele, Rect r);
    static public void RemoveManipulator(UIElements.VisualElement ele, UIElements.IManipulator manipulator);
    static public void StretchToParentSize(UIElements.VisualElement elem);
    static public void StretchToParentWidth(UIElements.VisualElement elem);
    static public Vector2 WorldToLocal(UIElements.VisualElement ele, Vector2 p);
    static public Rect WorldToLocal(UIElements.VisualElement ele, Rect r);

}

}
