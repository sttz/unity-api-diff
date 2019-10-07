using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public struct Flex
{
    public float basis { get; set; }
    public float grow { get; set; }
    public float shrink { get; set; }

    public Flex(float g, float s = 1, float b = 0);

}

}
