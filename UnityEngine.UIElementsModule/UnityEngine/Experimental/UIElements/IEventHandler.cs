using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public interface IEventHandler
{
    public void HandleEvent(Experimental.UIElements.EventBase evt);
    public bool HasBubbleHandlers();
    public bool HasBubbleUpHandlers();
    public bool HasCaptureHandlers();
    public bool HasTrickleDownHandlers();
    public void SendEvent(Experimental.UIElements.EventBase e);

}

}
