using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class UxmlLongAttributeDescription : Experimental.UIElements.UxmlAttributeDescription
{
    public long defaultValue { get; set; }
    public string defaultValueAsString { get; }

    public UxmlLongAttributeDescription();

    public long GetValueFromBag(Experimental.UIElements.IUxmlAttributes bag);
    public long GetValueFromBag(Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

}

}
