using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlFloatAttributeDescription : UIElements.TypedUxmlAttributeDescription<float>
{
    public string defaultValueAsString { get; }

    public UxmlFloatAttributeDescription();

    public float GetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);
    public bool TryGetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc, float value);

}

}
