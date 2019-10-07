using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class PanelChangedEventBase<T> : UIElements.EventBase<T>, UIElements.IPanelChangedEvent
{
    static public T GetPooled(UIElements.IPanel originPanel, UIElements.IPanel destinationPanel);

    public UIElements.IPanel destinationPanel { get; private set; }
    public UIElements.IPanel originPanel { get; private set; }

    protected PanelChangedEventBase();

    protected void Init();

}

}
