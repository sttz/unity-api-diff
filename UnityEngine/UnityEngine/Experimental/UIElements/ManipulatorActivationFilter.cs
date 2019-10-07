using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public struct ManipulatorActivationFilter
{
    public Experimental.UIElements.MouseButton button;
    public int clickCount;
    public EventModifiers modifiers;

    public bool Matches(Experimental.UIElements.IMouseEvent e);

}

}
