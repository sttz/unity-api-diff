using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class PopupField<T> : UnityEditor.Experimental.UIElements.BasePopupField<T, T>
{
    public Func<T, string> formatListItemCallback { get; set; }
    public Func<T, string> formatSelectedValueCallback { get; set; }
    public int index { get; set; }
    public T value { get; set; }

    protected PopupField(System.Collections.Generic.List<T> choices, Func<T, string> formatSelectedValueCallback = null, Func<T, string> formatListItemCallback = null);
    public PopupField(System.Collections.Generic.List<T> choices, T defaultValue, Func<T, string> formatSelectedValueCallback = null, Func<T, string> formatListItemCallback = null);
    public PopupField(System.Collections.Generic.List<T> choices, int defaultIndex, Func<T, string> formatSelectedValueCallback = null, Func<T, string> formatListItemCallback = null);

    public void SetValueWithoutNotify(T newValue);

}

}
