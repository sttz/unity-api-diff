using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.ShortcutManagement
{

public struct ShortcutBinding : IEquatable<UnityEditor.ShortcutManagement.ShortcutBinding>
{
    static public UnityEditor.ShortcutManagement.ShortcutBinding empty { get; }

    public IEnumerable<UnityEditor.ShortcutManagement.KeyCombination> keyCombinationSequence { get; }

    public ShortcutBinding(UnityEditor.ShortcutManagement.KeyCombination keyCombination);

    public bool Equals(object obj);
    public bool Equals(UnityEditor.ShortcutManagement.ShortcutBinding other);
    public int GetHashCode();
    public string ToString();

}

}
