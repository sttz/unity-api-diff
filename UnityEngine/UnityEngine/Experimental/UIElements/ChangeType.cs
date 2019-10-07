using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public enum ChangeType
{
    PersistentData = 64,
    PersistentDataPath = 32,
    Layout = 16,
    Styles = 8,
    Transform = 4,
    StylesPath = 2,
    Repaint = 1,
    All = 127,
}

}
