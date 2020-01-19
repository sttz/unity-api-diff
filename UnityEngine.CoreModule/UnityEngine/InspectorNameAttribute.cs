using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class InspectorNameAttribute : PropertyAttribute
{
    public string displayName;

    public InspectorNameAttribute(string displayName);

}

}
