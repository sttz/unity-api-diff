using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class UxmlColorAttributeDescription : Experimental.UIElements.UxmlAttributeDescription
{
    public Color defaultValue { get; set; }
    public string defaultValueAsString { get; }

    public UxmlColorAttributeDescription();

    public Color GetValueFromBag(Experimental.UIElements.IUxmlAttributes bag);
    public Color GetValueFromBag(Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

}

}
