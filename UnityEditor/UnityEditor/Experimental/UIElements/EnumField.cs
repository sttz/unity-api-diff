using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class EnumField : Experimental.UIElements.BaseField<Enum>
{
    public string text { get; }

    public EnumField();
    public EnumField(Enum defaultValue);

    public void Init(Enum defaultValue);
    public void SetValueAndNotify(Enum newValue);
    public void SetValueWithoutNotify(Enum newValue);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.EnumField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Enum>
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
