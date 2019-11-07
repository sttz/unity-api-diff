using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class Vector3IntField : UnityEditor.Experimental.UIElements.BaseCompositeField<Vector3Int, UnityEditor.Experimental.UIElements.IntegerField, int>
{
    public Vector3IntField();

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.Vector3IntField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Vector3Int, UnityEditor.Experimental.UIElements.IntegerField, int>
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
