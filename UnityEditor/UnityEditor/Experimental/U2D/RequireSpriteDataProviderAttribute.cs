using System;
using UnityEngine;

namespace UnityEditor.Experimental.U2D
{

public class RequireSpriteDataProviderAttribute : Attribute
{
    public RequireSpriteDataProviderAttribute(Type[] types);

}

}
