using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class ImmediateModeElement : UIElements.VisualElement
{
    public bool cullingEnabled { get; set; }

    public ImmediateModeElement();

    protected void ImmediateRepaint();

}

}
