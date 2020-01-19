using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public enum ChangeType
{
    Repaint = 1,
    StylesPath = 2,
    Transform = 4,
    Styles = 8,
    Layout = 16,
    PersistentDataPath = 32,
    PersistentData = 64,
    All = 127,
}

}
