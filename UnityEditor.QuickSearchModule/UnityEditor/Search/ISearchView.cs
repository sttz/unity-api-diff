using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public interface ISearchView : IDisposable
{
    public UnityEditor.Search.SearchContext context { get; }
    public UnityEditor.Search.DisplayMode displayMode { get; }
    public Func<UnityEditor.Search.SearchItem, bool> filterCallback { get; }
    public float itemIconSize { get; set; }
    public bool multiselect { get; set; }
    public UnityEditor.Search.ISearchList results { get; }
    public Action<UnityEditor.Search.SearchItem, bool> selectCallback { get; }
    public UnityEditor.Search.SearchSelection selection { get; }
    public Action<UnityEditor.Search.SearchItem> trackingCallback { get; }

    public void AddSelection(int[] selection);
    public void Close();
    public void ExecuteAction(UnityEditor.Search.SearchAction action, UnityEditor.Search.SearchItem[] items, bool endSearch = true);
    public void Focus();
    public void Refresh(UnityEditor.Search.RefreshFlags reason = 1);
    public void Repaint();
    public void SelectSearch();
    public void SetSearchText(string searchText, UnityEditor.Search.TextCursorPlacement moveCursor = 1);
    public void SetSelection(int[] selection);
    public void ShowItemContextualMenu(UnityEditor.Search.SearchItem item, Rect contextualActionPosition);

}

}
