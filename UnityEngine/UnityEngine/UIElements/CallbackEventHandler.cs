using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class CallbackEventHandler : UIElements.IEventHandler
{
    protected CallbackEventHandler();

    public void HandleEvent(UIElements.EventBase evt);
    public bool HasBubbleUpHandlers();
    public bool HasTrickleDownHandlers();
    public void RegisterCallback(UIElements.EventCallback<TEventType> callback, UIElements.TrickleDown useTrickleDown = 0);
    public void RegisterCallback(UIElements.EventCallback<TEventType, TUserArgsType> callback, TUserArgsType userArgs, UIElements.TrickleDown useTrickleDown = 0);
    public void SendEvent(UIElements.EventBase e);
    public void UnregisterCallback(UIElements.EventCallback<TEventType> callback, UIElements.TrickleDown useTrickleDown = 0);
    public void UnregisterCallback(UIElements.EventCallback<TEventType, TUserArgsType> callback, UIElements.TrickleDown useTrickleDown = 0);

}

}
