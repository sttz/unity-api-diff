using System;
using UnityEngine;

namespace UnityEditor
{

public enum StrippingLevel
{
    Disabled = 0,
    StripAssemblies = 1,
    StripByteCode = 2,
    UseMicroMSCorlib = 3,
}

}
