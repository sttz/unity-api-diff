using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class LayerMaskField : UnityEditor.UIElements.MaskField
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public Func<string, string> formatListItemCallback { get; set; }
    public Func<string, string> formatSelectedValueCallback { get; set; }

    public LayerMaskField(int defaultMask);
    public LayerMaskField(string label, int defaultMask);
    public LayerMaskField();
    public LayerMaskField(string label);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.LayerMaskField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

    }

}

}
