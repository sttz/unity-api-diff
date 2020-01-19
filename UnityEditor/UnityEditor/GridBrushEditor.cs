using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class GridBrushEditor : UnityEditor.GridBrushEditorBase
{
    public UnityEditor.GridBrush brush { get; }
    public GameObject[] validTargets { get; }

    public GridBrushEditor();

    public void BoxFillPreview(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
    public void ClearPreview();
    public void FloodFillPreview(GridLayout gridLayout, GameObject brushTarget, Vector3Int position);
    protected void OnDisable();
    protected void OnEnable();
    public void OnMouseLeave();
    public void OnPaintSceneGUI(GridLayout gridLayout, GameObject brushTarget, BoundsInt position, Tool tool, bool executing);
    public void OnSelectionInspectorGUI();
    public void OnToolDeactivated(Tool tool);
    public void PaintPreview(GridLayout gridLayout, GameObject brushTarget, Vector3Int position);
    public void RegisterUndo(GameObject brushTarget, Tool tool);

}

}
