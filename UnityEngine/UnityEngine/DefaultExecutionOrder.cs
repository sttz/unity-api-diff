using System;
using UnityEngine;

namespace UnityEngine
{

public class DefaultExecutionOrder : Attribute
{
    public int order { get; }

    public DefaultExecutionOrder(int order);

}

}
