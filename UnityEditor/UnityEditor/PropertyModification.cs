using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class PropertyModification
{
    public Object objectReference;
    public string propertyPath;
    public Object target;
    public string value;

    public PropertyModification();

}

}
