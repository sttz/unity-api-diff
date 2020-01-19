using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class Vector2Field : UnityEditor.Experimental.UIElements.BaseCompositeField<Vector2, UnityEditor.Experimental.UIElements.FloatField, float>
{
    public Vector2Field();

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.Vector2Field, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Vector2, UnityEditor.Experimental.UIElements.FloatField, float>
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
