using System;
using UnityEngine;

namespace UnityEngine.Lumin
{

public sealed class UsesLuminPlatformLevelAttribute : Attribute
{
    public uint platformLevel { get; }

    public UsesLuminPlatformLevelAttribute(uint platformLevel);

}

}
