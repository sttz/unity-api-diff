using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Internal.Experimental.UIElements
{

public class PanelWrapper : ScriptableObject
{
    public bool UIREnabled { set; }
    public Experimental.UIElements.VisualElement visualTree { get; }

    public PanelWrapper();

    public void Repaint(Event e);

}

}