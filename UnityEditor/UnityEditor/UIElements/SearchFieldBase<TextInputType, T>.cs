using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public abstract class SearchFieldBase<TextInputType, T> : UIElements.VisualElement, UIElements.INotifyValueChanged<T>
{
    static public string cancelButtonOffVariantUssClassName;
    static public string cancelButtonUssClassName;
    static public string popupVariantUssClassName;
    static public string searchButtonUssClassName;
    static public string textUssClassName;
    static public string ussClassName;

    protected UIElements.Button searchButton { get; }
    protected TextInputType textInputField { get; }
    public T value { get; set; }

    protected SearchFieldBase();

    protected void ClearTextField();
    protected bool FieldIsEmpty(T fieldValue);
    public void SetValueWithoutNotify(T newValue);

}

}
