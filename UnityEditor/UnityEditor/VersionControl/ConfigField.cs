using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.VersionControl
{

public class ConfigField
{
    public string description { get; }
    public bool isPassword { get; }
    public bool isRequired { get; }
    public string label { get; }
    public string name { get; }

    public void Dispose();

}

}
