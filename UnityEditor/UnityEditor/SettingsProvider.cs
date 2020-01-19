using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class SettingsProvider
{
    static public IEnumerable<string> GetSearchKeywordsFromGUIContentProperties<T>();
    static public IEnumerable<string> GetSearchKeywordsFromPath(string path);
    static public IEnumerable<string> GetSearchKeywordsFromSerializedObject(UnityEditor.SerializedObject serializedObject);

    public Action<string, Experimental.UIElements.VisualElement> activateHandler { get; set; }
    public Action deactivateHandler { get; set; }
    public Action footerBarGuiHandler { get; set; }
    public Action<string> guiHandler { get; set; }
    public Func<string, bool> hasSearchInterestHandler { get; set; }
    public IEnumerable<string> keywords { get; set; }
    public string label { get; set; }
    public UnityEditor.SettingsScope scope { get; private set; }
    public UnityEditor.SettingsScopes scopes { get; set; }
    public string settingsPath { get; }
    public Action titleBarGuiHandler { get; set; }

    public SettingsProvider(string path, UnityEditor.SettingsScope scopes = 1, IEnumerable<string> keywords = null);

    public bool HasSearchInterest(string searchContext);
    public void OnActivate(string searchContext, Experimental.UIElements.VisualElement rootElement);
    public void OnDeactivate();
    public void OnFooterBarGUI();
    public void OnGUI(string searchContext);
    public void OnTitleBarGUI();
    public void PopulateSearchKeywordsFromGUIContentProperties<T>();
    public void Repaint();

}

}
