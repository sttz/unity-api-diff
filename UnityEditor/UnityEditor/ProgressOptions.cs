using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public enum ProgressOptions
{
    None = 0,
    Sticky = 1,
    Indefinite = 2,
    Synchronous = 4,
    Managed = 8,
    Unmanaged = 16,
}

}
