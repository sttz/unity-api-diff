using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public class WriteCommand
{
    public string fileName { get; set; }
    public string internalName { get; set; }
    public List<UnityEditor.Build.Content.SerializationInfo> serializeObjects { get; set; }

    public WriteCommand();

}

}
