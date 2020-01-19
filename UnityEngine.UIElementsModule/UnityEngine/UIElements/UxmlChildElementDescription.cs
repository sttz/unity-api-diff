using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlChildElementDescription
{
    public string elementName { get; protected set; }
    public string elementNamespace { get; protected set; }

    public UxmlChildElementDescription(Type t);

}

}
