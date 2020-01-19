using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{

public abstract class TreeView
{
    static protected List<UnityEditor.IMGUI.Controls.TreeViewItem> CreateChildListForCollapsedParent();
    static protected bool IsChildListForACollapsedParent(IList<UnityEditor.IMGUI.Controls.TreeViewItem> childList);
    static protected void SetupDepthsFromParentsAndChildren(UnityEditor.IMGUI.Controls.TreeViewItem root);
    static protected void SetupParentsAndChildrenFromDepths(UnityEditor.IMGUI.Controls.TreeViewItem root, IList<UnityEditor.IMGUI.Controls.TreeViewItem> rows);

    protected float baseIndent { get; set; }
    protected float cellMargin { get; set; }
    protected int columnIndexForTreeFoldouts { get; set; }
    protected float customFoldoutYOffset { get; set; }
    protected float depthIndentWidth { get; set; }
    protected float extraSpaceBeforeIconAndLabel { get; set; }
    protected DoFoldoutCallback foldoutOverride { get; set; }
    protected float foldoutWidth { get; }
    protected GetNewSelectionFunction getNewSelectionOverride { set; }
    public bool hasSearch { get; }
    protected bool isDragging { get; }
    protected bool isInitialized { get; }
    public UnityEditor.IMGUI.Controls.MultiColumnHeader multiColumnHeader { get; set; }
    protected UnityEditor.IMGUI.Controls.TreeViewItem rootItem { get; }
    protected float rowHeight { get; set; }
    public string searchString { get; set; }
    protected bool showAlternatingRowBackgrounds { get; set; }
    protected bool showBorder { get; set; }
    protected bool showingHorizontalScrollBar { get; }
    protected bool showingVerticalScrollBar { get; }
    public UnityEditor.IMGUI.Controls.TreeViewState state { get; }
    public float totalHeight { get; }
    public int treeViewControlID { get; set; }
    protected Rect treeViewRect { get; set; }
    protected bool useScrollView { get; set; }

    public TreeView(UnityEditor.IMGUI.Controls.TreeViewState state);
    public TreeView(UnityEditor.IMGUI.Controls.TreeViewState state, UnityEditor.IMGUI.Controls.MultiColumnHeader multiColumnHeader);

    protected void AddExpandedRows(UnityEditor.IMGUI.Controls.TreeViewItem root, IList<UnityEditor.IMGUI.Controls.TreeViewItem> rows);
    protected void AfterRowsGUI();
    protected void BeforeRowsGUI();
    public bool BeginRename(UnityEditor.IMGUI.Controls.TreeViewItem item);
    public bool BeginRename(UnityEditor.IMGUI.Controls.TreeViewItem item, float delay);
    protected UnityEditor.IMGUI.Controls.TreeViewItem BuildRoot();
    protected IList<UnityEditor.IMGUI.Controls.TreeViewItem> BuildRows(UnityEditor.IMGUI.Controls.TreeViewItem root);
    protected bool CanBeParent(UnityEditor.IMGUI.Controls.TreeViewItem item);
    protected bool CanChangeExpandedState(UnityEditor.IMGUI.Controls.TreeViewItem item);
    protected bool CanMultiSelect(UnityEditor.IMGUI.Controls.TreeViewItem item);
    protected bool CanRename(UnityEditor.IMGUI.Controls.TreeViewItem item);
    protected bool CanStartDrag(CanStartDragArgs args);
    protected void CenterRectUsingSingleLineHeight(Rect rect);
    public void CollapseAll();
    protected void CommandEventHandling();
    protected void ContextClicked();
    protected void ContextClickedItem(int id);
    protected bool DoesItemMatchSearch(UnityEditor.IMGUI.Controls.TreeViewItem item, string search);
    protected void DoubleClickedItem(int id);
    public void EndRename();
    public void ExpandAll();
    protected void ExpandedStateChanged();
    protected UnityEditor.IMGUI.Controls.TreeViewItem FindItem(int id, UnityEditor.IMGUI.Controls.TreeViewItem searchFromThisItem);
    protected int FindRowOfItem(UnityEditor.IMGUI.Controls.TreeViewItem item);
    protected IList<UnityEditor.IMGUI.Controls.TreeViewItem> FindRows(IList<int> ids);
    public void FrameItem(int id);
    protected IList<int> GetAncestors(int id);
    protected Rect GetCellRectForTreeFoldouts(Rect rowRect);
    protected float GetContentIndent(UnityEditor.IMGUI.Controls.TreeViewItem item);
    protected float GetCustomRowHeight(int row, UnityEditor.IMGUI.Controls.TreeViewItem item);
    protected IList<int> GetDescendantsThatHaveChildren(int id);
    public IList<int> GetExpanded();
    protected void GetFirstAndLastVisibleRows(out int firstRowVisible, out int lastRowVisible);
    protected float GetFoldoutIndent(UnityEditor.IMGUI.Controls.TreeViewItem item);
    protected Rect GetRenameRect(Rect rowRect, int row, UnityEditor.IMGUI.Controls.TreeViewItem item);
    protected Rect GetRowRect(int row);
    public IList<UnityEditor.IMGUI.Controls.TreeViewItem> GetRows();
    public IList<int> GetSelection();
    protected UnityEditor.DragAndDropVisualMode HandleDragAndDrop(DragAndDropArgs args);
    public bool HasFocus();
    public bool HasSelection();
    public bool IsExpanded(int id);
    public bool IsSelected(int id);
    protected void KeyEvent();
    public void OnGUI(Rect rect);
    protected void RefreshCustomRowHeights();
    public void Reload();
    protected void RenameEnded(RenameEndedArgs args);
    public void Repaint();
    protected void RowGUI(RowGUIArgs args);
    protected void SearchChanged(string newSearch);
    public void SelectAllRows();
    protected void SelectionChanged(IList<int> selectedIds);
    protected void SelectionClick(UnityEditor.IMGUI.Controls.TreeViewItem item, bool keepMultiSelection);
    public void SetExpanded(IList<int> ids);
    public bool SetExpanded(int id, bool expanded);
    public void SetExpandedRecursive(int id, bool expanded);
    public void SetFocus();
    public void SetFocusAndEnsureSelectedItem();
    public void SetSelection(IList<int> selectedIDs);
    public void SetSelection(IList<int> selectedIDs, UnityEditor.IMGUI.Controls.TreeViewSelectionOptions options);
    protected void SetupDragAndDrop(SetupDragAndDropArgs args);
    protected void SingleClickedItem(int id);
    protected IList<int> SortItemIDsInRowOrder(IList<int> ids);

    protected struct CanStartDragArgs
    {
        public UnityEditor.IMGUI.Controls.TreeViewItem draggedItem;
        public IList<int> draggedItemIDs;

    }

    public static class DefaultGUI
    {
        static public void BoldLabel(Rect rect, string label, bool selected, bool focused);
        static public void BoldLabelRightAligned(Rect rect, string label, bool selected, bool focused);
        static public void FoldoutLabel(Rect rect, string label, bool selected, bool focused);
        static public void Label(Rect rect, string label, bool selected, bool focused);
        static public void LabelRightAligned(Rect rect, string label, bool selected, bool focused);

    }

    public static class DefaultStyles
    {
        static public GUIStyle backgroundEven;
        static public GUIStyle backgroundOdd;
        static public GUIStyle boldLabel;
        static public GUIStyle boldLabelRightAligned;
        static public GUIStyle foldoutLabel;
        static public GUIStyle label;
        static public GUIStyle labelRightAligned;

    }

    public delegate bool DoFoldoutCallback(Rect position, bool expandedState, GUIStyle style);

    protected struct DragAndDropArgs
    {
        public DragAndDropPosition dragAndDropPosition;
        public int insertAtIndex;
        public UnityEditor.IMGUI.Controls.TreeViewItem parentItem;
        public bool performDrop;

    }

    protected enum DragAndDropPosition
    {
        UponItem = 0,
        BetweenItems = 1,
        OutsideItems = 2,
    }

    public delegate List<int> GetNewSelectionFunction(UnityEditor.IMGUI.Controls.TreeViewItem clickedItem, bool keepMultiSelection, bool useActionKeyAsShift);

    protected struct RenameEndedArgs
    {
        public bool acceptedRename;
        public int itemID;
        public string newName;
        public string originalName;

    }

    protected struct RowGUIArgs
    {
        public bool focused;
        public bool isRenaming;
        public UnityEditor.IMGUI.Controls.TreeViewItem item;
        public string label;
        public int row;
        public Rect rowRect;
        public bool selected;

        public Rect GetCellRect(int visibleColumnIndex);
        public int GetColumn(int visibleColumnIndex);
        public int GetNumVisibleColumns();

    }

    protected struct SetupDragAndDropArgs
    {
        public IList<int> draggedItemIDs;

    }

}

}
