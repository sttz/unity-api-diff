using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class ColorField : UIElements.BaseField<Color>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public bool hdr { get; set; }
    public bool showAlpha { get; set; }
    public bool showEyeDropper { get; set; }

    public ColorField();
    public ColorField(string label);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.ColorField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UIElements.BaseFieldTraits<Color, UIElements.UxmlColorAttributeDescription>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
