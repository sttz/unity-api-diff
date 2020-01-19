using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class DefaultExecutionOrder : Attribute
{
    public int order { get; private set; }

    public DefaultExecutionOrder(int order);

}

}
