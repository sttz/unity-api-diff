using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{

public class TreeViewState
{
    public Vector2 scrollPos;

    public List<int> expandedIDs { get; set; }
    public int lastClickedID { get; set; }
    public string searchString { get; set; }
    public List<int> selectedIDs { get; set; }

    public TreeViewState();

}

}
