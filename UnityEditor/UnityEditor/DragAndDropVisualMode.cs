using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public enum DragAndDropVisualMode
{
    None = 0,
    Copy = 1,
    Link = 2,
    Generic = 4,
    Move = 16,
    Rejected = 32,
}

}
