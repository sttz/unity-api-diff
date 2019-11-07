using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class RectIntField : UnityEditor.Experimental.UIElements.BaseCompositeField<RectInt, UnityEditor.Experimental.UIElements.IntegerField, int>
{
    public RectIntField();

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.RectIntField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<RectInt, UnityEditor.Experimental.UIElements.IntegerField, int>
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
