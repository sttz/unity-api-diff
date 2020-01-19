using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class LayerField : UnityEditor.Experimental.UIElements.PopupField<int>
{
    public Func<int, string> formatListItemCallback { get; set; }
    public Func<int, string> formatSelectedValueCallback { get; set; }
    public int value { get; set; }

    public LayerField();
    public LayerField(int defaultValue);

    public void SetValueWithoutNotify(int newValue);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.LayerField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<int>
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
