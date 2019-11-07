using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class RectIntField : UnityEditor.UIElements.BaseCompositeField<RectInt, UnityEditor.UIElements.IntegerField, int>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public RectIntField();
    public RectIntField(string label);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.RectIntField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<RectInt>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
