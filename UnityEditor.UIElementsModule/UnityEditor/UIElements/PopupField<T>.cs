using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class PopupField<T> : UnityEditor.UIElements.BasePopupField<T, T>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public Func<T, string> formatListItemCallback { get; set; }
    public Func<T, string> formatSelectedValueCallback { get; set; }
    public int index { get; set; }
    public T value { get; set; }

    public PopupField();
    public PopupField(string label = null);
    public PopupField(List<T> choices, int defaultIndex, Func<T, string> formatSelectedValueCallback = null, Func<T, string> formatListItemCallback = null);
    public PopupField(List<T> choices, T defaultValue, Func<T, string> formatSelectedValueCallback = null, Func<T, string> formatListItemCallback = null);
    public PopupField(string label, List<T> choices, int defaultIndex, Func<T, string> formatSelectedValueCallback = null, Func<T, string> formatListItemCallback = null);
    public PopupField(string label, List<T> choices, T defaultValue, Func<T, string> formatSelectedValueCallback = null, Func<T, string> formatListItemCallback = null);

    public void SetValueWithoutNotify(T newValue);

}

}
