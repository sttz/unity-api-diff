using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct ArticulationReducedSpace
{
    public int dofCount;

    public float this[int i] { get; set; }

    public ArticulationReducedSpace(float a);
    public ArticulationReducedSpace(float a, float b);
    public ArticulationReducedSpace(float a, float b, float c);

    public struct <x>e__FixedBuffer
    {
        public float FixedElementField;

    }

}

}
