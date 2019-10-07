using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class MouseManipulator : UIElements.Manipulator
{
    public System.Collections.Generic.List<UIElements.ManipulatorActivationFilter> activators { get; private set; }

    protected MouseManipulator();

    protected bool CanStartManipulation(UIElements.IMouseEvent e);
    protected bool CanStopManipulation(UIElements.IMouseEvent e);

}

}
