using System;
using UnityEngine;

namespace UnityEditor
{

public enum AndroidArchitecture : uint
{
    None = 0,
    ARMv7 = 1,
    ARM64 = 2,
    X86 = 4,
    All = 4294967295,
}

}
