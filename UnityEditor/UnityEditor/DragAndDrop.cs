using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class DragAndDrop
{
    static public int activeControlID { get; set; }
    static public Object[] objectReferences { get; set; }
    static public string[] paths { get; set; }
    static public UnityEditor.DragAndDropVisualMode visualMode { get; set; }

    static public void AcceptDrag();
    static public object GetGenericData(string type);
    static public void PrepareStartDrag();
    static public void SetGenericData(string type, object data);
    static public void StartDrag(string title);

    public DragAndDrop();

}

}
