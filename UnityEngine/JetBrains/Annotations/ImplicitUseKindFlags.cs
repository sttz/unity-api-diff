using System;
using UnityEngine;

namespace JetBrains.Annotations
{

public enum ImplicitUseKindFlags
{
    Default = 7,
    Access = 1,
    Assign = 2,
    InstantiatedWithFixedConstructorSignature = 4,
    InstantiatedNoFixedConstructorSignature = 8,
}

}
