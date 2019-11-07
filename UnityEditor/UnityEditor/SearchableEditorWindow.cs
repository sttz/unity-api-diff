using System;
using UnityEngine;

namespace UnityEditor
{

public class SearchableEditorWindow : UnityEditor.EditorWindow
{
    protected int m_SearchGroup;

    public SearchableEditorWindow();

    public void OnDisable();
    public void OnEnable();

    public enum SearchMode
    {
        All = 0,
        Name = 1,
        Type = 2,
        Label = 3,
        AssetBundleName = 4,
    }

    public enum SearchModeHierarchyWindow
    {
        All = 0,
        Name = 1,
        Type = 2,
    }

}

}
