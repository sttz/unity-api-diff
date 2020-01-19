using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class AssetSettingsProvider : UnityEditor.SettingsProvider
{
    static public UnityEditor.AssetSettingsProvider CreateProviderFromAssetPath(string settingsWindowPath, string assetPath, IEnumerable<string> keywords = null);
    static public UnityEditor.AssetSettingsProvider CreateProviderFromObject(string settingsWindowPath, Object settingsObj, IEnumerable<string> keywords = null);
    static public UnityEditor.AssetSettingsProvider CreateProviderFromResourcePath(string settingsWindowPath, string resourcePath, IEnumerable<string> keywords = null);

    public UnityEditor.Editor settingsEditor { get; private set; }

    public AssetSettingsProvider(string settingsWindowPath, Func<Object> settingsGetter);
    public AssetSettingsProvider(string settingsWindowPath, Func<UnityEditor.Editor> editorCreator, IEnumerable<string> keywords = null);

    public void OnActivate(string searchContext, UIElements.VisualElement rootElement);
    public void OnDeactivate();
    public void OnFooterBarGUI();
    public void OnGUI(string searchContext);
    public void OnTitleBarGUI();

}

}
