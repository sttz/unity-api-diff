using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Scripting
{

public class RequiredInterfaceAttribute : Attribute
{
    public RequiredInterfaceAttribute(Type interfaceType);

}

}
