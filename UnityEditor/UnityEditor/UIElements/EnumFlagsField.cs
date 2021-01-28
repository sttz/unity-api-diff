using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class EnumFlagsField : UnityEditor.UIElements.BaseMaskField<Enum>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public EnumFlagsField();
    public EnumFlagsField(Enum defaultValue);
    public EnumFlagsField(string label);
    public EnumFlagsField(Enum defaultValue, bool includeObsoleteValues);
    public EnumFlagsField(string label, Enum defaultValue);
    public EnumFlagsField(string label, Enum defaultValue, bool includeObsoleteValues);

    public void Init(Enum defaultValue, bool includeObsoleteValues = false);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.EnumFlagsField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Enum>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}