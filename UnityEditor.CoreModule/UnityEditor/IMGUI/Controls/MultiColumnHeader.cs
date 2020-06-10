using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{

public class MultiColumnHeader
{
    public bool canSort { get; set; }
    public float height { get; set; }
    public int sortedColumnIndex { get; set; }
    public UnityEditor.IMGUI.Controls.MultiColumnHeaderState state { get; set; }

    public event HeaderCallback sortingChanged;
    public event HeaderCallback visibleColumnsChanged;

    public MultiColumnHeader(UnityEditor.IMGUI.Controls.MultiColumnHeaderState state);

    protected void AddColumnHeaderContextMenuItems(UnityEditor.GenericMenu menu);
    protected void ColumnHeaderClicked(Column column, int columnIndex);
    protected void ColumnHeaderGUI(Column column, Rect headerRect, int columnIndex);
    public Rect GetCellRect(int visibleColumnIndex, Rect rowRect);
    public Column GetColumn(int columnIndex);
    public Rect GetColumnRect(int visibleColumnIndex);
    public int GetVisibleColumnIndex(int columnIndex);
    public bool IsColumnVisible(int columnIndex);
    public bool IsSortedAscending(int columnIndex);
    public void OnGUI(Rect rect, float xScroll);
    protected void OnSortingChanged();
    protected void OnVisibleColumnsChanged();
    public void Repaint();
    public void ResizeToFit();
    public void SetSortDirection(int columnIndex, bool sortAscending);
    public void SetSorting(int columnIndex, bool sortAscending);
    public void SetSortingColumns(int[] columnIndices, bool[] sortAscending);
    protected void SortingButton(Column column, Rect headerRect, int columnIndex);
    protected void ToggleVisibility(int columnIndex);

    public static class DefaultGUI
    {
        static public float columnContentMargin { get; }
        static public float defaultHeight { get; }
        static public float minimumHeight { get; }

    }

    public static class DefaultStyles
    {
        static public GUIStyle background;
        static public GUIStyle columnHeader;
        static public GUIStyle columnHeaderCenterAligned;
        static public GUIStyle columnHeaderRightAligned;

    }

    public delegate void HeaderCallback(UnityEditor.IMGUI.Controls.MultiColumnHeader multiColumnHeader);

}

}
