using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.WSA.Input
{

public class InteractionManager
{
    static public int numSourceStates { get; }

    static public event Action<XR.WSA.Input.InteractionSourceDetectedEventArgs> InteractionSourceDetected;
    static public event SourceEventHandler InteractionSourceDetectedLegacy;
    static public event Action<XR.WSA.Input.InteractionSourceLostEventArgs> InteractionSourceLost;
    static public event SourceEventHandler InteractionSourceLostLegacy;
    static public event Action<XR.WSA.Input.InteractionSourcePressedEventArgs> InteractionSourcePressed;
    static public event SourceEventHandler InteractionSourcePressedLegacy;
    static public event Action<XR.WSA.Input.InteractionSourceReleasedEventArgs> InteractionSourceReleased;
    static public event SourceEventHandler InteractionSourceReleasedLegacy;
    static public event Action<XR.WSA.Input.InteractionSourceUpdatedEventArgs> InteractionSourceUpdated;
    static public event SourceEventHandler InteractionSourceUpdatedLegacy;
    static public event SourceEventHandler SourceDetected;
    static public event SourceEventHandler SourceLost;
    static public event SourceEventHandler SourcePressed;
    static public event SourceEventHandler SourceReleased;
    static public event SourceEventHandler SourceUpdated;

    static public XR.WSA.Input.InteractionSourceState[] GetCurrentReading();
    static public int GetCurrentReading(XR.WSA.Input.InteractionSourceState[] sourceStates);

    public InteractionManager();

    public delegate void SourceEventHandler(XR.WSA.Input.InteractionSourceState state);

}

}
