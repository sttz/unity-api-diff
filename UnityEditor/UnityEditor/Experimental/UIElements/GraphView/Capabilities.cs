using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
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
}

}
