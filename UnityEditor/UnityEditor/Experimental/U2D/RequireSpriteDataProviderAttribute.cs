using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.U2D
{

public class RequireSpriteDataProviderAttribute : Attribute
{
    public RequireSpriteDataProviderAttribute(Type[] types);

}

}
