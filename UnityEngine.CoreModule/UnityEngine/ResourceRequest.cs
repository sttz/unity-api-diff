using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class ResourceRequest : AsyncOperation
{
    public Object asset { get; }

    public ResourceRequest();

    protected Object GetResult();

}

}
