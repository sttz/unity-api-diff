using System;
using UnityEngine;

namespace UnityEngine.Internal.UIElements
{

public class PanelWrapper : ScriptableObject
{
    public bool UIREnabled { set; }
    public UIElements.VisualElement visualTree { get; }

    public PanelWrapper();

    public void Repaint(Event e);

}

}
