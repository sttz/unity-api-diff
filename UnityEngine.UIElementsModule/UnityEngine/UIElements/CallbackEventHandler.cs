using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class CallbackEventHandler : UIElements.IEventHandler
{
    protected CallbackEventHandler();

    protected void ExecuteDefaultAction(UIElements.EventBase evt);
    protected void ExecuteDefaultActionAtTarget(UIElements.EventBase evt);
    public void HandleEvent(UIElements.EventBase evt);
    public bool HasBubbleUpHandlers();
    public bool HasTrickleDownHandlers();
    public void RegisterCallback<TEventType>(UIElements.EventCallback<TEventType> callback, UIElements.TrickleDown useTrickleDown = 0);
    public void RegisterCallback<TEventType, TUserArgsType>(UIElements.EventCallback<TEventType, TUserArgsType> callback, TUserArgsType userArgs, UIElements.TrickleDown useTrickleDown = 0);
    public void SendEvent(UIElements.EventBase e);
    public void UnregisterCallback<TEventType>(UIElements.EventCallback<TEventType> callback, UIElements.TrickleDown useTrickleDown = 0);
    public void UnregisterCallback<TEventType, TUserArgsType>(UIElements.EventCallback<TEventType, TUserArgsType> callback, UIElements.TrickleDown useTrickleDown = 0);

}

}
