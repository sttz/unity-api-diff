using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class FocusController
{
    public UIElements.Focusable focusedElement { get; }

    public FocusController(UIElements.IFocusRing focusRing);

}

}
