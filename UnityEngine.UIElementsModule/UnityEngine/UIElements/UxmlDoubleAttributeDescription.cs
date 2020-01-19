using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlDoubleAttributeDescription : UIElements.TypedUxmlAttributeDescription<double>
{
    public string defaultValueAsString { get; }

    public UxmlDoubleAttributeDescription();

    public double GetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);
    public bool TryGetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc, double value);

}

}
