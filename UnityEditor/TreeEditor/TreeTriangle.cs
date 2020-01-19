using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TreeEditor
{

public class TreeTriangle
{
    public bool isBillboard;
    public bool isCutout;
    public int materialIndex;
    public bool tileV;
    public int[] v;

    public TreeTriangle(int material, int v0, int v1, int v2);
    public TreeTriangle(int material, int v0, int v1, int v2, bool isBillboard);
    public TreeTriangle(int material, int v0, int v1, int v2, bool isBillboard, bool tileV, bool isCutout);

    public void flip();

}

}
