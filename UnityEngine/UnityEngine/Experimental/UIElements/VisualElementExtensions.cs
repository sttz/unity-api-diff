using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public static class VisualElementExtensions
{
    static public void AddManipulator(Experimental.UIElements.VisualElement ele, Experimental.UIElements.IManipulator manipulator);
    static public Vector2 ChangeCoordinatesTo(Experimental.UIElements.VisualElement src, Experimental.UIElements.VisualElement dest, Vector2 point);
    static public Rect ChangeCoordinatesTo(Experimental.UIElements.VisualElement src, Experimental.UIElements.VisualElement dest, Rect rect);
    static public Vector2 LocalToWorld(Experimental.UIElements.VisualElement ele, Vector2 p);
    static public Rect LocalToWorld(Experimental.UIElements.VisualElement ele, Rect r);
    static public void RemoveManipulator(Experimental.UIElements.VisualElement ele, Experimental.UIElements.IManipulator manipulator);
    static public void StretchToParentSize(Experimental.UIElements.VisualElement elem);
    static public void StretchToParentWidth(Experimental.UIElements.VisualElement elem);
    static public Vector2 WorldToLocal(Experimental.UIElements.VisualElement ele, Vector2 p);
    static public Rect WorldToLocal(Experimental.UIElements.VisualElement ele, Rect r);

}

}
