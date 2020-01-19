using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetBrains.Annotations
{

public enum ImplicitUseKindFlags
{
    Access = 1,
    Assign = 2,
    InstantiatedWithFixedConstructorSignature = 4,
    Default = 7,
    InstantiatedNoFixedConstructorSignature = 8,
}

}
