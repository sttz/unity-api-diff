using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Reporting
{

public class StrippingInfo : ScriptableObject, ISerializationCallbackReceiver
{
    public IEnumerable<string> includedModules { get; }

    public StrippingInfo();

    public IEnumerable<string> GetReasonsForIncluding(string entityName);

}

}
