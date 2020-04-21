using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.MPE
{

public sealed class RoleProviderAttribute : Attribute
{
    public Unity.MPE.ProcessEvent eventType;
    public Unity.MPE.ProcessLevel level;
    public string name;

    public RoleProviderAttribute(Unity.MPE.ProcessLevel level, Unity.MPE.ProcessEvent eventType);
    public RoleProviderAttribute(string name, Unity.MPE.ProcessEvent eventType);

}

}
