using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{

public class SearchField
{
    public bool autoSetFocusOnFindCommand { get; set; }
    public int searchFieldControlID { get; set; }

    public event SearchFieldCallback downOrUpArrowKeyPressed;

    public SearchField();

    public bool HasFocus();
    public string OnGUI(Rect rect, string text);
    public string OnGUI(string text, GUILayoutOption[] options);
    public string OnGUI(Rect rect, string text, GUIStyle style, GUIStyle cancelButtonStyle, GUIStyle emptyCancelButtonStyle);
    public string OnToolbarGUI(Rect rect, string text);
    public string OnToolbarGUI(string text, GUILayoutOption[] options);
    public void SetFocus();

    public delegate void SearchFieldCallback();

}

}
