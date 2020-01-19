using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class PointerManipulator : UIElements.MouseManipulator
{
    protected PointerManipulator();

    protected bool CanStartManipulation(UIElements.IPointerEvent e);
    protected bool CanStopManipulation(UIElements.IPointerEvent e);

}

}
