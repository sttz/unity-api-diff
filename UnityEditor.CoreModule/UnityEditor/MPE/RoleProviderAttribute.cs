using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.MPE
{

public sealed class RoleProviderAttribute : Attribute
{
    public UnityEditor.MPE.ProcessEvent eventType;
    public UnityEditor.MPE.ProcessLevel level;
    public string name;

    public RoleProviderAttribute(UnityEditor.MPE.ProcessLevel level, UnityEditor.MPE.ProcessEvent eventType);
    public RoleProviderAttribute(string name, UnityEditor.MPE.ProcessEvent eventType);

}

}
