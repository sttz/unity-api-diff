using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public interface IFocusEvent
{
    public UIElements.FocusChangeDirection direction { get; }
    public UIElements.Focusable relatedTarget { get; }

}

}
