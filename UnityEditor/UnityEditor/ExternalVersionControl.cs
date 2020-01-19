using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public struct ExternalVersionControl
{
    static public string AssetServer;
    static public string AutoDetect;
    static public string Disabled;
    static public string Generic;

    public ExternalVersionControl(string value);

    public string ToString();

}

}
