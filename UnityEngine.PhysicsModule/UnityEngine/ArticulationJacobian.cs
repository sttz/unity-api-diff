using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct ArticulationJacobian
{
    public int columns { get; set; }
    public List<float> elements { get; set; }
    public float this[int row, int col] { get; set; }
    public int rows { get; set; }

    public ArticulationJacobian(int rows, int cols);

}

}
