using System;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public class WriteCommand
{
    public string fileName { get; set; }
    public string internalName { get; set; }
    public System.Collections.Generic.List<UnityEditor.Build.Content.SerializationInfo> serializeObjects { get; set; }

    public WriteCommand();

}

}
