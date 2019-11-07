using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class Vector4Field : UnityEditor.Experimental.UIElements.BaseCompositeField<Vector4, UnityEditor.Experimental.UIElements.FloatField, float>
{
    public Vector4Field();

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.Vector4Field, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Vector4, UnityEditor.Experimental.UIElements.FloatField, float>
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
