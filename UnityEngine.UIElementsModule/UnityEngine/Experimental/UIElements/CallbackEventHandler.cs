using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class CallbackEventHandler : Experimental.UIElements.IEventHandler
{
    protected CallbackEventHandler();

    public void HandleEvent(Experimental.UIElements.EventBase evt);
    public bool HasBubbleHandlers();
    public bool HasBubbleUpHandlers();
    public bool HasCaptureHandlers();
    public bool HasTrickleDownHandlers();
    public void RegisterCallback<TEventType>(Experimental.UIElements.EventCallback<TEventType> callback, Experimental.UIElements.Capture useCapture);
    public void RegisterCallback<TEventType>(Experimental.UIElements.EventCallback<TEventType> callback, Experimental.UIElements.TrickleDown useTrickleDown = 0);
    public void RegisterCallback<TEventType, TUserArgsType>(Experimental.UIElements.EventCallback<TEventType, TUserArgsType> callback, TUserArgsType userArgs, Experimental.UIElements.Capture useCapture);
    public void RegisterCallback<TEventType, TUserArgsType>(Experimental.UIElements.EventCallback<TEventType, TUserArgsType> callback, TUserArgsType userArgs, Experimental.UIElements.TrickleDown useTrickleDown = 0);
    public void SendEvent(Experimental.UIElements.EventBase e);
    public void UnregisterCallback<TEventType>(Experimental.UIElements.EventCallback<TEventType> callback, Experimental.UIElements.Capture useCapture);
    public void UnregisterCallback<TEventType>(Experimental.UIElements.EventCallback<TEventType> callback, Experimental.UIElements.TrickleDown useTrickleDown = 0);
    public void UnregisterCallback<TEventType, TUserArgsType>(Experimental.UIElements.EventCallback<TEventType, TUserArgsType> callback, Experimental.UIElements.Capture useCapture);
    public void UnregisterCallback<TEventType, TUserArgsType>(Experimental.UIElements.EventCallback<TEventType, TUserArgsType> callback, Experimental.UIElements.TrickleDown useTrickleDown = 0);

}

}
