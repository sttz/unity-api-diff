using System;
using UnityEngine;

namespace UnityEditor
{

public class AssetSettingsProvider : UnityEditor.SettingsProvider
{
    static public UnityEditor.AssetSettingsProvider CreateProviderFromAssetPath(string settingsWindowPath, string assetPath, System.Collections.Generic.IEnumerable<string> keywords = null);
    static public UnityEditor.AssetSettingsProvider CreateProviderFromObject(string settingsWindowPath, Object settingsObj, System.Collections.Generic.IEnumerable<string> keywords = null);
    static public UnityEditor.AssetSettingsProvider CreateProviderFromResourcePath(string settingsWindowPath, string resourcePath, System.Collections.Generic.IEnumerable<string> keywords = null);

    public UnityEditor.Editor settingsEditor { get; private set; }

    public AssetSettingsProvider(string settingsWindowPath, Func<UnityEditor.Editor> editorCreator, System.Collections.Generic.IEnumerable<string> keywords = null);
    public AssetSettingsProvider(string settingsWindowPath, Func<Object> settingsGetter);

    public void OnActivate(string searchContext, Experimental.UIElements.VisualElement rootElement);
    public void OnDeactivate();
    public void OnFooterBarGUI();
    public void OnGUI(string searchContext);
    public void OnTitleBarGUI();

}

}
