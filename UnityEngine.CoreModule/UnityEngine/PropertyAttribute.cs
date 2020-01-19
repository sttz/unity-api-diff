using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public abstract class PropertyAttribute : Attribute
{
    public int order { get; set; }

    protected PropertyAttribute();

}

}
