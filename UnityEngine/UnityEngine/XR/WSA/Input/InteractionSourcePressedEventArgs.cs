using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.WSA.Input
{

public struct InteractionSourcePressedEventArgs
{
    public XR.WSA.Input.InteractionSourcePressType pressType { get; private set; }
    public XR.WSA.Input.InteractionSourceState state { get; private set; }

    public InteractionSourcePressedEventArgs(XR.WSA.Input.InteractionSourceState state, XR.WSA.Input.InteractionSourcePressType pressType);

}

}
