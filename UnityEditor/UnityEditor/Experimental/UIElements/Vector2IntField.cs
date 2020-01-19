using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class Vector2IntField : UnityEditor.Experimental.UIElements.BaseCompositeField<Vector2Int, UnityEditor.Experimental.UIElements.IntegerField, int>
{
    public Vector2IntField();

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.Vector2IntField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Vector2Int, UnityEditor.Experimental.UIElements.IntegerField, int>
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
