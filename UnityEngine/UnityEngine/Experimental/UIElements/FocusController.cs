using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class FocusController
{
    public Experimental.UIElements.Focusable focusedElement { get; private set; }

    public FocusController(Experimental.UIElements.IFocusRing focusRing);

    public void SwitchFocusOnEvent(Experimental.UIElements.EventBase e);

}

}
