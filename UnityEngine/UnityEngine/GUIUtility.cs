using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class GUIUtility
{
    static public bool hasModalWindow { get; }
    static public int hotControl { get; set; }
    static public int keyboardControl { get; set; }
    static public string systemCopyBuffer { get; set; }

    static public Rect AlignRectToDevice(Rect rect);
    static public Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels);
    static public void ExitGUI();
    static public int GetControlID(FocusType focus);
    static public int GetControlID(GUIContent contents, FocusType focus);
    static public int GetControlID(FocusType focus, Rect position);
    static public int GetControlID(int hint, FocusType focus);
    static public int GetControlID(GUIContent contents, FocusType focus, Rect position);
    static public int GetControlID(int hint, FocusType focusType, Rect rect);
    static public object GetStateObject(Type t, int controlID);
    static public Vector2 GUIToScreenPoint(Vector2 guiPoint);
    static public Rect GUIToScreenRect(Rect guiRect);
    static public object QueryStateObject(Type t, int controlID);
    static public void RotateAroundPivot(float angle, Vector2 pivotPoint);
    static public void ScaleAroundPivot(Vector2 scale, Vector2 pivotPoint);
    static public Vector2 ScreenToGUIPoint(Vector2 screenPoint);
    static public Rect ScreenToGUIRect(Rect screenRect);

    public GUIUtility();

}

}
