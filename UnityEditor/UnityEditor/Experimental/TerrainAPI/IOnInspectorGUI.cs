using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.TerrainAPI
{

public interface IOnInspectorGUI
{
    public void Repaint(UnityEditor.Experimental.TerrainAPI.RepaintFlags flags = 1);
    public void ShowBrushesGUI(int spacing);
    public void ShowBrushesGUI(int spacing, UnityEditor.Experimental.TerrainAPI.BrushGUIEditFlags flags);

}

}
