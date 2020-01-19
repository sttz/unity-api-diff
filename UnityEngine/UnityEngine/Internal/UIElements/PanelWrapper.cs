using System;
using System.Collections;
using System.Collections.Generic;
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
