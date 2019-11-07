using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class Vector2IntField : UnityEditor.UIElements.BaseCompositeField<Vector2Int, UnityEditor.UIElements.IntegerField, int>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public Vector2IntField();
    public Vector2IntField(string label);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.Vector2IntField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Vector2Int>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
