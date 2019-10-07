using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public interface IFocusEvent
{
    public UIElements.FocusChangeDirection direction { get; }
    public UIElements.Focusable relatedTarget { get; }

}

}
