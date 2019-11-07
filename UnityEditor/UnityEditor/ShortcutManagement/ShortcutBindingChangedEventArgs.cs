using System;
using UnityEngine;

namespace UnityEditor.ShortcutManagement
{

public struct ShortcutBindingChangedEventArgs
{
    public UnityEditor.ShortcutManagement.ShortcutBinding newBinding { get; }
    public UnityEditor.ShortcutManagement.ShortcutBinding oldBinding { get; }
    public string shortcutId { get; }

    public ShortcutBindingChangedEventArgs(string shortcutId, UnityEditor.ShortcutManagement.ShortcutBinding oldBinding, UnityEditor.ShortcutManagement.ShortcutBinding newBinding);

}

}
