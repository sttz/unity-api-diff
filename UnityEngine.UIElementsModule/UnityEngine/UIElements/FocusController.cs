using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class FocusController
{
    public UIElements.Focusable focusedElement { get; }

    public FocusController(UIElements.IFocusRing focusRing);

}

}
