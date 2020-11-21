using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlHash128AttributeDescription : UIElements.TypedUxmlAttributeDescription<Hash128>
{
    public string defaultValueAsString { get; }

    public UxmlHash128AttributeDescription();

    public Hash128 GetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);
    public bool TryGetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc, Hash128 value);

}

}
