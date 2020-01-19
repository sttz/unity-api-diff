using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class UxmlBoolAttributeDescription : Experimental.UIElements.UxmlAttributeDescription
{
    public bool defaultValue { get; set; }
    public string defaultValueAsString { get; }

    public UxmlBoolAttributeDescription();

    public bool GetValueFromBag(Experimental.UIElements.IUxmlAttributes bag);
    public bool GetValueFromBag(Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

}

}
