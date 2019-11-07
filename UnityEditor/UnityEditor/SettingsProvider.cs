using System;
using UnityEngine;

namespace UnityEditor
{

public class SettingsProvider
{
    static public System.Collections.Generic.IEnumerable<string> GetSearchKeywordsFromGUIContentProperties();
    static public System.Collections.Generic.IEnumerable<string> GetSearchKeywordsFromPath(string path);
    static public System.Collections.Generic.IEnumerable<string> GetSearchKeywordsFromSerializedObject(UnityEditor.SerializedObject serializedObject);

    public Action<string, UIElements.VisualElement> activateHandler { get; set; }
    public Action deactivateHandler { get; set; }
    public Action footerBarGuiHandler { get; set; }
    public Action<string> guiHandler { get; set; }
    public Func<string, bool> hasSearchInterestHandler { get; set; }
    public Action inspectorUpdateHandler { get; set; }
    public System.Collections.Generic.IEnumerable<string> keywords { get; set; }
    public string label { get; set; }
    public UnityEditor.SettingsScope scope { get; }
    public string settingsPath { get; }
    public Action titleBarGuiHandler { get; set; }

    public SettingsProvider(string path, UnityEditor.SettingsScope scopes, System.Collections.Generic.IEnumerable<string> keywords = null);

    public bool HasSearchInterest(string searchContext);
    public void OnActivate(string searchContext, UIElements.VisualElement rootElement);
    public void OnDeactivate();
    public void OnFooterBarGUI();
    public void OnGUI(string searchContext);
    public void OnInspectorUpdate();
    public void OnTitleBarGUI();
    public void PopulateSearchKeywordsFromGUIContentProperties();
    public void Repaint();

}

}
