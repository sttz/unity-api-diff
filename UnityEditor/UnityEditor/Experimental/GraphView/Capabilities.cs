using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public enum Capabilities
{
    Selectable = 1,
    Collapsible = 2,
    Resizable = 4,
    Movable = 8,
    Deletable = 16,
    Droppable = 32,
    Ascendable = 64,
    Renamable = 128,
    Copiable = 256,
}

}
