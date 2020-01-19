using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class UxmlDoubleAttributeDescription : Experimental.UIElements.UxmlAttributeDescription
{
    public double defaultValue { get; set; }
    public string defaultValueAsString { get; }

    public UxmlDoubleAttributeDescription();

    public double GetValueFromBag(Experimental.UIElements.IUxmlAttributes bag);
    public double GetValueFromBag(Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

}

}
