using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class Toggle : Experimental.UIElements.BaseField<bool>
{
    public string text { get; set; }

    public Toggle();
    public Toggle(Action clickEvent);

    public void OnToggle(Action clickEvent);
    public void SetValueWithoutNotify(bool newValue);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.Toggle, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<bool>
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
