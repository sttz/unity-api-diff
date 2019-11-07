using System;
using UnityEngine;

namespace UnityEditor.ShortcutManagement
{

public struct ShortcutBinding : IEquatable<UnityEditor.ShortcutManagement.ShortcutBinding>
{
    static public UnityEditor.ShortcutManagement.ShortcutBinding empty { get; }

    public System.Collections.Generic.IEnumerable<UnityEditor.ShortcutManagement.KeyCombination> keyCombinationSequence { get; }

    public ShortcutBinding(UnityEditor.ShortcutManagement.KeyCombination keyCombination);

    public bool Equals(UnityEditor.ShortcutManagement.ShortcutBinding other);
    public bool Equals(object obj);
    public int GetHashCode();
    public string ToString();

}

}
