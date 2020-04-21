using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class PreferenceItem : Attribute
{
    public string name;

    public PreferenceItem(string name);

}

}
