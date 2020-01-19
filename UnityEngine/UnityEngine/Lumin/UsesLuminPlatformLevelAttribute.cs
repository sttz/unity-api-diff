using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Lumin
{

public sealed class UsesLuminPlatformLevelAttribute : Attribute
{
    public uint platformLevel { get; }

    public UsesLuminPlatformLevelAttribute(uint platformLevel);

}

}
