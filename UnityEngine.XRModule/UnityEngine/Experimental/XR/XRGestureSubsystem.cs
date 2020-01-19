using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRGestureSubsystem : IntegratedSubsystem<Experimental.XR.XRGestureSubsystemDescriptor>
{
    public event Action<Experimental.XR.GestureHoldEvent> HoldChanged;
    public event Action<Experimental.XR.GestureManipulationEvent> ManipulationChanged;
    public event Action<Experimental.XR.GestureNavigationEvent> NavigationChanged;
    public event Action<Experimental.XR.GestureRecognitionEvent> RecognitionChanged;
    public event Action<Experimental.XR.GestureTappedEvent> TappedChanged;

    public XRGestureSubsystem();

    public bool CancelAllGestures();
    public Experimental.XR.GestureEventTypes GetAvailableGestures();
    public bool SetEnabledGestures(Experimental.XR.GestureEventTypes enabledGestures);

}

}
