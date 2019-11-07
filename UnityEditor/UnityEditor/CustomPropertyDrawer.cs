using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class CustomPropertyDrawer : Attribute
{
    public CustomPropertyDrawer(Type type);
    public CustomPropertyDrawer(Type type, bool useForChildren);

}

}
