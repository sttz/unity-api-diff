using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class CustomPreviewAttribute : Attribute
{
    public CustomPreviewAttribute(Type type);

}

}
