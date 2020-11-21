using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SearchService
{

public class ObjectSelectorHandlerAttribute : Attribute
{
    public Type attributeType { get; }

    public ObjectSelectorHandlerAttribute(Type attributeType);

}

}
