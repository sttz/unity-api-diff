using System;
using UnityEngine;

namespace UnityEditor.Build.Reporting
{

public class StrippingInfo : ScriptableObject, ISerializationCallbackReceiver
{
    public System.Collections.Generic.IEnumerable<string> includedModules { get; }

    public StrippingInfo();

    public System.Collections.Generic.IEnumerable<string> GetReasonsForIncluding(string entityName);

}

}
