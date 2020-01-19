using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Lumin
{

public sealed class UsesLuminPrivilegeAttribute : Attribute
{
    public string privilege { get; }

    public UsesLuminPrivilegeAttribute(string privilege);

}

}
