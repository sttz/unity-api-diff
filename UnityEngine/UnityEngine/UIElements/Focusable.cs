using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class Focusable : UIElements.CallbackEventHandler
{
    public bool canGrabFocus { get; }
    public bool delegatesFocus { get; set; }
    public bool focusable { get; set; }
    public UIElements.FocusController focusController { get; }
    public int tabIndex { get; set; }

    protected Focusable();

    public void Blur();
    public void Focus();

}

}
