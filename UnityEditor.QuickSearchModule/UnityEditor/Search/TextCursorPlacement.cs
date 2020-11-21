using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public enum TextCursorPlacement
{
    None = 0,
    MoveLineEnd = 1,
    Default = 1,
    MoveLineStart = 2,
    MoveToEndOfPreviousWord = 3,
    MoveToStartOfNextWord = 4,
    MoveWordLeft = 5,
    MoveWordRight = 6,
    MoveAutoComplete = 7,
}

}
