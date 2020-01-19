using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.PackageManager
{

public enum PackageSource
{
    Unknown = 0,
    Registry = 1,
    BuiltIn = 2,
    Embedded = 3,
    Local = 4,
    Git = 5,
    LocalTarball = 6,
}

}
