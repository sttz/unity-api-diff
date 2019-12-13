using System;
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
