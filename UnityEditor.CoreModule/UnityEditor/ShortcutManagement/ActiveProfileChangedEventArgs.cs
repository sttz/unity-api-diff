using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.ShortcutManagement
{

public struct ActiveProfileChangedEventArgs
{
    public string currentActiveProfileId { get; }
    public string previousActiveProfileId { get; }

    public ActiveProfileChangedEventArgs(string previousActiveProfileId, string currentActiveProfileId);

}

}
