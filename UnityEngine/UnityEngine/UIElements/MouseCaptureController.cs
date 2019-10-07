using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public static class MouseCaptureController
{
    static public void CaptureMouse(UIElements.IEventHandler handler);
    static public bool HasMouseCapture(UIElements.IEventHandler handler);
    static public bool IsMouseCaptured();
    static public void ReleaseMouse(UIElements.IEventHandler handler);
    static public void ReleaseMouse();

}

}
