using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class GridBrushEditorBase : UnityEditor.Editor
{
    public GameObject[] validTargets { get; }

    public GridBrushEditorBase();

    public void OnMouseEnter();
    public void OnMouseLeave();
    public void OnPaintInspectorGUI();
    public void OnPaintSceneGUI(GridLayout gridLayout, GameObject brushTarget, BoundsInt position, Tool tool, bool executing);
    public void OnSelectionInspectorGUI();
    public void OnToolActivated(Tool tool);
    public void OnToolDeactivated(Tool tool);
    public void RegisterUndo(GameObject brushTarget, Tool tool);

}

}
