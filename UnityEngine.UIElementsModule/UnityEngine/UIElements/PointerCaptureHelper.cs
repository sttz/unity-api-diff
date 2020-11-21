using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public static class PointerCaptureHelper
{
    static public void CapturePointer(UIElements.IEventHandler handler, int pointerId);
    static public UIElements.IEventHandler GetCapturingElement(UIElements.IPanel panel, int pointerId);
    static public bool HasPointerCapture(UIElements.IEventHandler handler, int pointerId);
    static public void ReleasePointer(UIElements.IEventHandler handler, int pointerId);
    static public void ReleasePointer(UIElements.IPanel panel, int pointerId);

}

}
