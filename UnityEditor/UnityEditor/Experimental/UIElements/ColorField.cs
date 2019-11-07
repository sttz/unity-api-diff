using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class ColorField : Experimental.UIElements.BaseField<Color>
{
    public int focusIndex { get; set; }
    public bool hdr { get; set; }
    public bool showAlpha { get; set; }
    public bool showEyeDropper { get; set; }

    public ColorField();

    public void SetValueAndNotify(Color newValue);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.ColorField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Color>
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
