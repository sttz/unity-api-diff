using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class ToolbarSearchField : UIElements.VisualElement, UIElements.INotifyValueChanged<string>
{
    static public string cancelButtonOffVariantUssClassName;
    static public string cancelButtonUssClassName;
    static public string popupVariantUssClassName;
    static public string searchButtonUssClassName;
    static public string textUssClassName;
    static public string ussClassName;

    protected UIElements.Button searchButton { get; }
    public string value { get; set; }

    public ToolbarSearchField();

    public void SetValueWithoutNotify(string newValue);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.ToolbarSearchField>
    {
        public UxmlFactory();

    }

}

}
