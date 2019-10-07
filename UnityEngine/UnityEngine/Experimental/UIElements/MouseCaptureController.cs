using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public static class MouseCaptureController
{
    static public void CaptureMouse(Experimental.UIElements.IEventHandler handler);
    static public bool HasMouseCapture(Experimental.UIElements.IEventHandler handler);
    static public bool IsMouseCaptured();
    static public bool IsMouseCaptureTaken();
    static public void ReleaseMouse(Experimental.UIElements.IEventHandler handler);
    static public void ReleaseMouse();
    static public void ReleaseMouseCapture(Experimental.UIElements.IEventHandler handler);
    static public void ReleaseMouseCapture();
    static public void TakeMouseCapture(Experimental.UIElements.IEventHandler handler);

}

}
