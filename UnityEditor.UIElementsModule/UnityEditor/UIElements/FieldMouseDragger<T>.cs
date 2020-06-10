using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class FieldMouseDragger<T>
{
    public bool dragging { get; set; }
    public T startValue { get; set; }

    public FieldMouseDragger(UnityEditor.UIElements.IValueField<T> drivenField);

    public void SetDragZone(UIElements.VisualElement dragElement);
    public void SetDragZone(UIElements.VisualElement dragElement, Rect hotZone);

}

}
