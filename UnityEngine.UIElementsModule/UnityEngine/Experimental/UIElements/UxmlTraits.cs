using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class UxmlTraits
{
    public bool canHaveAnyAttribute { get; protected set; }
    public IEnumerable<Experimental.UIElements.UxmlAttributeDescription> uxmlAttributesDescription { get; }
    public IEnumerable<Experimental.UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

    protected UxmlTraits();

    public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

}

}
