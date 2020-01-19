using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public interface IPanel : IDisposable
{
    public Experimental.UIElements.ContextType contextType { get; }
    public Experimental.UIElements.EventDispatcher dispatcher { get; }
    public Experimental.UIElements.FocusController focusController { get; }
    public Experimental.UIElements.VisualElement visualTree { get; }

    public Experimental.UIElements.VisualElement LoadTemplate(string path, Dictionary<string, Experimental.UIElements.VisualElement> slots = null);
    public Experimental.UIElements.VisualElement Pick(Vector2 point);
    public Experimental.UIElements.VisualElement PickAll(Vector2 point, List<Experimental.UIElements.VisualElement> picked);

}

}
