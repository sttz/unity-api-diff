using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct ManipulatorActivationFilter : IEquatable<UIElements.ManipulatorActivationFilter>
{
    public UIElements.MouseButton button { get; set; }
    public int clickCount { get; set; }
    public EventModifiers modifiers { get; set; }

    public bool Equals(object obj);
    public bool Equals(UIElements.ManipulatorActivationFilter other);
    public int GetHashCode();
    public bool Matches(UIElements.IMouseEvent e);

}

}
