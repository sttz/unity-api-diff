using System;
using UnityEngine;

namespace UnityEngine
{

public class BeforeRenderOrderAttribute : Attribute
{
    public int order { get; private set; }

    public BeforeRenderOrderAttribute(int order);

}

}
