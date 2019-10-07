using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class ImmediateModeElement : UIElements.VisualElement
{
    public ImmediateModeElement();

    protected void ImmediateRepaint();

}

}
