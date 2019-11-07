using System;
using UnityEngine;

namespace UnityEditor
{

public enum AndroidETC2FallbackOverride
{
    UseBuildSettings = 0,
    Quality32Bit = 1,
    Quality16Bit = 2,
    Quality32BitDownscaled = 3,
}

}
