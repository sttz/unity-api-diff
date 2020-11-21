using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlLongAttributeDescription : UIElements.TypedUxmlAttributeDescription<long>
{
    public string defaultValueAsString { get; }

    public UxmlLongAttributeDescription();

    public long GetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);
    public bool TryGetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc, long value);

}

}
