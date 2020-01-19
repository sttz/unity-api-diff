using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class GUILayoutUtility
{
    static public void BeginGroup(string GroupName);
    static public void EndGroup(string groupName);
    static public Rect GetAspectRect(float aspect);
    static public Rect GetAspectRect(float aspect, GUILayoutOption[] options);
    static public Rect GetAspectRect(float aspect, GUIStyle style);
    static public Rect GetAspectRect(float aspect, GUIStyle style, GUILayoutOption[] options);
    static public Rect GetLastRect();
    static public Rect GetRect(GUIContent content, GUIStyle style);
    static public Rect GetRect(float width, float height);
    static public Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options);
    static public Rect GetRect(float width, float height, GUILayoutOption[] options);
    static public Rect GetRect(float width, float height, GUIStyle style);
    static public Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight);
    static public Rect GetRect(float width, float height, GUIStyle style, GUILayoutOption[] options);
    static public Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUILayoutOption[] options);
    static public Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style);
    static public Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options);

    public GUILayoutUtility();

}

}
