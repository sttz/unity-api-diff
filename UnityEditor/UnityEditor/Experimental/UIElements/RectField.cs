using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class RectField : UnityEditor.Experimental.UIElements.BaseCompositeField<Rect, UnityEditor.Experimental.UIElements.FloatField, float>
{
    public RectField();

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.RectField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Rect, UnityEditor.Experimental.UIElements.FloatField, float>
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
