using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class HelpURLAttribute : Attribute
{
    public string URL { get; }

    public HelpURLAttribute(string url);

}

}
