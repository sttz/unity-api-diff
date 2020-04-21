using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class BeforeRenderOrderAttribute : Attribute
{
    public int order { get; private set; }

    public BeforeRenderOrderAttribute(int order);

}

}
