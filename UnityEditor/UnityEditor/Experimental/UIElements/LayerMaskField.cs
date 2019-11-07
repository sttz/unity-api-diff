using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class LayerMaskField : UnityEditor.Experimental.UIElements.MaskField
{
    public Func<string, string> formatListItemCallback { get; set; }
    public Func<string, string> formatSelectedValueCallback { get; set; }

    public LayerMaskField(int defaultMask);
    public LayerMaskField();

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.LayerMaskField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

    }

}

}
