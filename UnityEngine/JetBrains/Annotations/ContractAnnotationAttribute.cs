using System;
using UnityEngine;

namespace JetBrains.Annotations
{

public sealed class ContractAnnotationAttribute : Attribute
{
    public string Contract { get; private set; }
    public bool ForceFullStates { get; private set; }

    public ContractAnnotationAttribute(string contract);
    public ContractAnnotationAttribute(string contract, bool forceFullStates);

}

}
