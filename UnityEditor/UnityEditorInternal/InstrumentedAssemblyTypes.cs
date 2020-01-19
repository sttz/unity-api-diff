using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public enum InstrumentedAssemblyTypes
{
    None = 0,
    System = 1,
    Unity = 2,
    Plugins = 4,
    Script = 8,
    All = 2147483647,
}

}
