using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.ShortcutManagement
{

public interface IShortcutManager
{
    public string activeProfileId { get; set; }

    public event Action<UnityEditor.ShortcutManagement.ActiveProfileChangedEventArgs> activeProfileChanged;
    public event Action<UnityEditor.ShortcutManagement.ShortcutBindingChangedEventArgs> shortcutBindingChanged;

    public void ClearShortcutOverride(string shortcutId);
    public void CreateProfile(string profileId);
    public void DeleteProfile(string profileId);
    public IEnumerable<string> GetAvailableProfileIds();
    public IEnumerable<string> GetAvailableShortcutIds();
    public UnityEditor.ShortcutManagement.ShortcutBinding GetShortcutBinding(string shortcutId);
    public bool IsProfileIdValid(string profileId);
    public bool IsProfileReadOnly(string profileId);
    public bool IsShortcutOverridden(string shortcutId);
    public void RebindShortcut(string shortcutId, UnityEditor.ShortcutManagement.ShortcutBinding binding);
    public void RenameProfile(string profileId, string newProfileId);

}

}
