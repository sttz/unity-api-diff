using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.WSA.Input
{

public struct InteractionSourceReleasedEventArgs
{
    public XR.WSA.Input.InteractionSourcePressType pressType { get; private set; }
    public XR.WSA.Input.InteractionSourceState state { get; private set; }

    public InteractionSourceReleasedEventArgs(XR.WSA.Input.InteractionSourceState state, XR.WSA.Input.InteractionSourcePressType pressType);

}

}
