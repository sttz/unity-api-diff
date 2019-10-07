using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public interface IPanel : IDisposable
{
    public UIElements.ContextType contextType { get; }
    public UIElements.EventDispatcher dispatcher { get; }
    public UIElements.FocusController focusController { get; }
    public UIElements.VisualElement visualTree { get; }

    public UIElements.VisualElement Pick(Vector2 point);
    public UIElements.VisualElement PickAll(Vector2 point, System.Collections.Generic.List<UIElements.VisualElement> picked);

}

}
