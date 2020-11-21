using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class ObjectField : UIElements.BaseField<Object>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string objectUssClassName;
    static public string selectorUssClassName;
    static public string ussClassName;

    public bool allowSceneObjects { get; set; }
    public Type objectType { get; set; }

    public ObjectField();
    public ObjectField(string label);

    public void SetValueWithoutNotify(Object newValue);
    protected void UpdateMixedValueContent();

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.ObjectField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Object>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
