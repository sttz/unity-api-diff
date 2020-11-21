using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class DefaultExecutionOrder : Attribute
{
    public int order { get; }

    public DefaultExecutionOrder(int order);

}

}
