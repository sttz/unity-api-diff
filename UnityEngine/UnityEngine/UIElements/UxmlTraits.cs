using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class UxmlTraits
{
    public bool canHaveAnyAttribute { get; protected set; }
    public System.Collections.Generic.IEnumerable<UIElements.UxmlAttributeDescription> uxmlAttributesDescription { get; }
    public System.Collections.Generic.IEnumerable<UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

    protected UxmlTraits();

    public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

}

}
