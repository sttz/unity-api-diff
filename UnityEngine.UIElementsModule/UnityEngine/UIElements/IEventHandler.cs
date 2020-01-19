using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public interface IEventHandler
{
    public void HandleEvent(UIElements.EventBase evt);
    public bool HasBubbleUpHandlers();
    public bool HasTrickleDownHandlers();
    public void SendEvent(UIElements.EventBase e);

}

}
