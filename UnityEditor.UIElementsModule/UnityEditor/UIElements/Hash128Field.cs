using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class Hash128Field : UIElements.TextInputBaseField<Hash128>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public Hash128 value { get; set; }

    public Hash128Field();
    public Hash128Field(int maxLength);
    public Hash128Field(string label, int maxLength = -1);

    public void SetValueWithoutNotify(Hash128 newValue);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.Hash128Field, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UnityEditor.UIElements.TextValueFieldTraits<Hash128, UIElements.UxmlHash128AttributeDescription>
    {
        public UxmlTraits();

    }

}

}
