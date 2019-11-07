using System;
using UnityEngine;

namespace UnityEditor.ShortcutManagement
{

public class ClutchShortcutAttribute : UnityEditor.ShortcutManagement.ShortcutAttribute
{
    public ClutchShortcutAttribute(string id, Type context = null);
    public ClutchShortcutAttribute(string id, Type context, KeyCode defaultKeyCode, UnityEditor.ShortcutManagement.ShortcutModifiers defaultShortcutModifiers = 0);
    public ClutchShortcutAttribute(string id, KeyCode defaultKeyCode, UnityEditor.ShortcutManagement.ShortcutModifiers defaultShortcutModifiers = 0);

}

}
