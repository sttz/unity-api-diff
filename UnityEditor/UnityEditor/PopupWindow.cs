using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class PopupWindow : UnityEditor.EditorWindow
{
    static public void Show(Rect activatorRect, UnityEditor.PopupWindowContent windowContent);

    protected void OnDisable();
    protected void OnEnable();

}

}
