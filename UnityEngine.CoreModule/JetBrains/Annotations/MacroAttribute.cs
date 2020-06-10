using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetBrains.Annotations
{

public sealed class MacroAttribute : Attribute
{
    public int Editable { get; set; }
    public string Expression { get; set; }
    public string Target { get; set; }

    public MacroAttribute();

}

}
