using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlStringAttributeDescription : UIElements.TypedUxmlAttributeDescription<string>
{
    public string defaultValueAsString { get; }

    public UxmlStringAttributeDescription();

    public string GetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);
    public bool TryGetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc, string value);

}

}
