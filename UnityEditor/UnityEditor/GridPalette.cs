using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class GridPalette : ScriptableObject
{
    public CellSizing cellSizing;

    public GridPalette();

    public enum CellSizing
    {
        Automatic = 0,
        Manual = 100,
    }

}

}
