using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class PanelChangedEventBase<T> : Experimental.UIElements.EventBase<T>, Experimental.UIElements.IPanelChangedEvent, Experimental.UIElements.IPropagatableEvent
{
    static public T GetPooled(Experimental.UIElements.IPanel originPanel, Experimental.UIElements.IPanel destinationPanel);

    public Experimental.UIElements.IPanel destinationPanel { get; private set; }
    public Experimental.UIElements.IPanel originPanel { get; private set; }

    protected PanelChangedEventBase();

    protected void Init();

}

}
