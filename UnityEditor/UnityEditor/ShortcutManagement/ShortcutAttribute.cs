using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.ShortcutManagement
{

public class ShortcutAttribute : UnityEditor.ShortcutManagement.ShortcutBaseAttribute
{
    public string displayName { get; set; }

    public ShortcutAttribute(string id, Type context = null);
    public ShortcutAttribute(string id, KeyCode defaultKeyCode, UnityEditor.ShortcutManagement.ShortcutModifiers defaultShortcutModifiers = 0);
    public ShortcutAttribute(string id, Type context, KeyCode defaultKeyCode, UnityEditor.ShortcutManagement.ShortcutModifiers defaultShortcutModifiers = 0);

}

}
