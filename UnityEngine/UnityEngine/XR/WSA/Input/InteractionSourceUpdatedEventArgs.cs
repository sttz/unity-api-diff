using System;
using UnityEngine;

namespace UnityEngine.XR.WSA.Input
{

public struct InteractionSourceUpdatedEventArgs
{
    public XR.WSA.Input.InteractionSourceState state { get; private set; }

    public InteractionSourceUpdatedEventArgs(XR.WSA.Input.InteractionSourceState state);

}

}
