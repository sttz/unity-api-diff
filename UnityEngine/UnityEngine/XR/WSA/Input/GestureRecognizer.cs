using System;
using UnityEngine;

namespace UnityEngine.XR.WSA.Input
{

public sealed class GestureRecognizer : IDisposable
{
    public event Action<XR.WSA.Input.GestureErrorEventArgs> GestureError;
    public event GestureErrorDelegate GestureErrorEvent;
    public event Action<XR.WSA.Input.HoldCanceledEventArgs> HoldCanceled;
    public event HoldCanceledEventDelegate HoldCanceledEvent;
    public event Action<XR.WSA.Input.HoldCompletedEventArgs> HoldCompleted;
    public event HoldCompletedEventDelegate HoldCompletedEvent;
    public event Action<XR.WSA.Input.HoldStartedEventArgs> HoldStarted;
    public event HoldStartedEventDelegate HoldStartedEvent;
    public event Action<XR.WSA.Input.ManipulationCanceledEventArgs> ManipulationCanceled;
    public event ManipulationCanceledEventDelegate ManipulationCanceledEvent;
    public event Action<XR.WSA.Input.ManipulationCompletedEventArgs> ManipulationCompleted;
    public event ManipulationCompletedEventDelegate ManipulationCompletedEvent;
    public event Action<XR.WSA.Input.ManipulationStartedEventArgs> ManipulationStarted;
    public event ManipulationStartedEventDelegate ManipulationStartedEvent;
    public event Action<XR.WSA.Input.ManipulationUpdatedEventArgs> ManipulationUpdated;
    public event ManipulationUpdatedEventDelegate ManipulationUpdatedEvent;
    public event Action<XR.WSA.Input.NavigationCanceledEventArgs> NavigationCanceled;
    public event NavigationCanceledEventDelegate NavigationCanceledEvent;
    public event Action<XR.WSA.Input.NavigationCompletedEventArgs> NavigationCompleted;
    public event NavigationCompletedEventDelegate NavigationCompletedEvent;
    public event Action<XR.WSA.Input.NavigationStartedEventArgs> NavigationStarted;
    public event NavigationStartedEventDelegate NavigationStartedEvent;
    public event Action<XR.WSA.Input.NavigationUpdatedEventArgs> NavigationUpdated;
    public event NavigationUpdatedEventDelegate NavigationUpdatedEvent;
    public event Action<XR.WSA.Input.RecognitionEndedEventArgs> RecognitionEnded;
    public event RecognitionEndedEventDelegate RecognitionEndedEvent;
    public event Action<XR.WSA.Input.RecognitionStartedEventArgs> RecognitionStarted;
    public event RecognitionStartedEventDelegate RecognitionStartedEvent;
    public event Action<XR.WSA.Input.TappedEventArgs> Tapped;
    public event TappedEventDelegate TappedEvent;

    public GestureRecognizer();

    public void CancelGestures();
    public void Dispose();
    public XR.WSA.Input.GestureSettings GetRecognizableGestures();
    public bool IsCapturingGestures();
    public XR.WSA.Input.GestureSettings SetRecognizableGestures(XR.WSA.Input.GestureSettings newMaskValue);
    public void StartCapturingGestures();
    public void StopCapturingGestures();

    public delegate void HoldCanceledEventDelegate(XR.WSA.Input.InteractionSourceKind source, Ray headRay);

    public delegate void HoldCompletedEventDelegate(XR.WSA.Input.InteractionSourceKind source, Ray headRay);

    public delegate void HoldStartedEventDelegate(XR.WSA.Input.InteractionSourceKind source, Ray headRay);

    public delegate void TappedEventDelegate(XR.WSA.Input.InteractionSourceKind source, int tapCount, Ray headRay);

    public delegate void ManipulationCanceledEventDelegate(XR.WSA.Input.InteractionSourceKind source, Vector3 cumulativeDelta, Ray headRay);

    public delegate void ManipulationCompletedEventDelegate(XR.WSA.Input.InteractionSourceKind source, Vector3 cumulativeDelta, Ray headRay);

    public delegate void ManipulationStartedEventDelegate(XR.WSA.Input.InteractionSourceKind source, Vector3 cumulativeDelta, Ray headRay);

    public delegate void ManipulationUpdatedEventDelegate(XR.WSA.Input.InteractionSourceKind source, Vector3 cumulativeDelta, Ray headRay);

    public delegate void NavigationCanceledEventDelegate(XR.WSA.Input.InteractionSourceKind source, Vector3 normalizedOffset, Ray headRay);

    public delegate void NavigationCompletedEventDelegate(XR.WSA.Input.InteractionSourceKind source, Vector3 normalizedOffset, Ray headRay);

    public delegate void NavigationStartedEventDelegate(XR.WSA.Input.InteractionSourceKind source, Vector3 normalizedOffset, Ray headRay);

    public delegate void NavigationUpdatedEventDelegate(XR.WSA.Input.InteractionSourceKind source, Vector3 normalizedOffset, Ray headRay);

    public delegate void RecognitionEndedEventDelegate(XR.WSA.Input.InteractionSourceKind source, Ray headRay);

    public delegate void RecognitionStartedEventDelegate(XR.WSA.Input.InteractionSourceKind source, Ray headRay);

    public delegate void GestureErrorDelegate(string error, int hresult);

}

}
