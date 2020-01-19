using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public static class SettingsService
{
    static public void NotifySettingsProviderChanged();
    static public UnityEditor.EditorWindow OpenProjectSettings(string settingsPath = null);
    static public UnityEditor.EditorWindow OpenUserPreferences(string settingsPath = null);

}

}
