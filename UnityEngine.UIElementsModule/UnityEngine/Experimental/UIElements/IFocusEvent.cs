using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public interface IFocusEvent
{
    public Experimental.UIElements.FocusChangeDirection direction { get; }
    public Experimental.UIElements.Focusable relatedTarget { get; }

}

}
