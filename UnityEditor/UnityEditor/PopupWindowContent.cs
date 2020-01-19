using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public abstract class PopupWindowContent
{
    public UnityEditor.EditorWindow editorWindow { get; internal set; }

    protected PopupWindowContent();

    public Vector2 GetWindowSize();
    public void OnClose();
    public void OnGUI(Rect rect);
    public void OnOpen();

}

}
