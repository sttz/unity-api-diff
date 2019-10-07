using System;
using UnityEngine;

namespace UnityEngine
{

public class InspectorNameAttribute : PropertyAttribute
{
    public string displayName;

    public InspectorNameAttribute(string displayName);

}

}
