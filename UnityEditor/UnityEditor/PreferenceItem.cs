using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class PreferenceItem : Attribute
{
    public string name;

    public PreferenceItem(string name);

}

}
