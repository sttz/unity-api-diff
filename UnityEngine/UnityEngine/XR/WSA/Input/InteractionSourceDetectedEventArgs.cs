using System;
using UnityEngine;

namespace UnityEngine.XR.WSA.Input
{

public struct InteractionSourceDetectedEventArgs
{
    public XR.WSA.Input.InteractionSourceState state { get; private set; }

    public InteractionSourceDetectedEventArgs(XR.WSA.Input.InteractionSourceState state);

}

}
