using System;
using UnityEngine;

namespace UnityEngine
{

public class DefaultExecutionOrder : Attribute
{
    public int order { get; private set; }

    public DefaultExecutionOrder(int order);

}

}
