using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public static class MouseCaptureController
{
    static public void CaptureMouse(UIElements.IEventHandler handler);
    static public bool HasMouseCapture(UIElements.IEventHandler handler);
    static public bool IsMouseCaptured();
    static public void ReleaseMouse();
    static public void ReleaseMouse(UIElements.IEventHandler handler);

}

}
