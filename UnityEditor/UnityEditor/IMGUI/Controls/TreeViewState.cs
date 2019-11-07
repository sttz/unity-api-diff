using System;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{

public class TreeViewState
{
    public Vector2 scrollPos;

    public System.Collections.Generic.List<int> expandedIDs { get; set; }
    public int lastClickedID { get; set; }
    public string searchString { get; set; }
    public System.Collections.Generic.List<int> selectedIDs { get; set; }

    public TreeViewState();

}

}
