using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class UxmlTraits
{
    public bool canHaveAnyAttribute { get; protected set; }
    public System.Collections.Generic.IEnumerable<Experimental.UIElements.UxmlAttributeDescription> uxmlAttributesDescription { get; }
    public System.Collections.Generic.IEnumerable<Experimental.UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

    protected UxmlTraits();

    public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

}

}
