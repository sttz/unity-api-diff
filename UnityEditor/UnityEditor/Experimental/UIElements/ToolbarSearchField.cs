using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class ToolbarSearchField : Experimental.UIElements.VisualElement, Experimental.UIElements.INotifyValueChanged<string>
{
    protected Experimental.UIElements.Button m_SearchButton;

    public string value { get; set; }

    public ToolbarSearchField();
    protected ToolbarSearchField(string searchButtonStyleClassName);

    public void OnValueChanged(Experimental.UIElements.EventCallback<Experimental.UIElements.ChangeEvent<string>> callback);
    public void RemoveOnValueChanged(Experimental.UIElements.EventCallback<Experimental.UIElements.ChangeEvent<string>> callback);
    public void SetValueAndNotify(string newValue);
    public void SetValueWithoutNotify(string newValue);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.ToolbarSearchField>
    {
        public UxmlFactory();

    }

}

}
