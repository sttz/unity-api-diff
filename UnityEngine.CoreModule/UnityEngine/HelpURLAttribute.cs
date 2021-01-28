using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class HelpURLAttribute : Attribute
{
    public string URL { get; }

    public HelpURLAttribute(string url);

}

}
