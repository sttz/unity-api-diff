using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class Vector3Field : UnityEditor.Experimental.UIElements.BaseCompositeField<Vector3, UnityEditor.Experimental.UIElements.FloatField, float>
{
    public Vector3Field();

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.Vector3Field, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Vector3, UnityEditor.Experimental.UIElements.FloatField, float>
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
