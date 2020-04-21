using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct NetworkMessageInfo
{
    public NetworkView networkView { get; }
    public NetworkPlayer sender { get; }
    public double timestamp { get; }

}

}
