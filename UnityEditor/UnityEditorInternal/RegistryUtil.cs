using System;
using UnityEngine;

namespace UnityEditorInternal
{

public class RegistryUtil
{
    static public string GetRegistryStringValue(string subKey, string valueName, string defaultValue, UnityEditorInternal.RegistryView view);
    static public uint GetRegistryUInt32Value(string subKey, string valueName, uint defaultValue, UnityEditorInternal.RegistryView view);

    public RegistryUtil();

}

}
