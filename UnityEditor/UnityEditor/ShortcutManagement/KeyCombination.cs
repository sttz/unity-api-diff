using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.ShortcutManagement
{

public struct KeyCombination : IEquatable<UnityEditor.ShortcutManagement.KeyCombination>
{
    public bool action { get; }
    public bool alt { get; }
    public KeyCode keyCode { get; }
    public UnityEditor.ShortcutManagement.ShortcutModifiers modifiers { get; }
    public bool shift { get; }

    public KeyCombination(KeyCode keyCode, UnityEditor.ShortcutManagement.ShortcutModifiers shortcutModifiers = 0);

    public bool Equals(object obj);
    public bool Equals(UnityEditor.ShortcutManagement.KeyCombination other);
    public int GetHashCode();
    public string ToString();

}

}
