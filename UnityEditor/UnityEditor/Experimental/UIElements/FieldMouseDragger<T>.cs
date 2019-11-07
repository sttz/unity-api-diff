using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class FieldMouseDragger<T>
{
    public bool dragging;
    public T startValue;

    public FieldMouseDragger(UnityEditor.Experimental.UIElements.IValueField<T> drivenField);

    public void SetDragZone(Experimental.UIElements.VisualElement dragElement);
    public void SetDragZone(Experimental.UIElements.VisualElement dragElement, Rect hotZone);

}

}
