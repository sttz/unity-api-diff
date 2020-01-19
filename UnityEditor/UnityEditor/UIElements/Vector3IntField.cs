using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class Vector3IntField : UnityEditor.UIElements.BaseCompositeField<Vector3Int, UnityEditor.UIElements.IntegerField, int>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public Vector3IntField();
    public Vector3IntField(string label);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.Vector3IntField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Vector3Int>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
