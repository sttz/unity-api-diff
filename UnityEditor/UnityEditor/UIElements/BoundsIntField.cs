using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class BoundsIntField : UIElements.BaseField<BoundsInt>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string positionUssClassName;
    static public string sizeUssClassName;
    static public string ussClassName;

    public BoundsIntField();
    public BoundsIntField(string label);

    public void SetValueWithoutNotify(BoundsInt newValue);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.BoundsIntField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<BoundsInt>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
