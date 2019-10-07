using System;
using UnityEngine;

namespace UnityEngine.XR.WSA.Input
{

public struct InteractionSourceLostEventArgs
{
    public XR.WSA.Input.InteractionSourceState state { get; private set; }

    public InteractionSourceLostEventArgs(XR.WSA.Input.InteractionSourceState state);

}

}
