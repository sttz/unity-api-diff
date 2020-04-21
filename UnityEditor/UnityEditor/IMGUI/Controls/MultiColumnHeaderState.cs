using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{

public class MultiColumnHeaderState
{
    static public bool CanOverwriteSerializedFields(UnityEditor.IMGUI.Controls.MultiColumnHeaderState source, UnityEditor.IMGUI.Controls.MultiColumnHeaderState destination);
    static public void OverwriteSerializedFields(UnityEditor.IMGUI.Controls.MultiColumnHeaderState source, UnityEditor.IMGUI.Controls.MultiColumnHeaderState destination);

    public Column[] columns { get; }
    public int maximumNumberOfSortedColumns { get; set; }
    public int sortedColumnIndex { get; set; }
    public int[] sortedColumns { get; set; }
    public int[] visibleColumns { get; set; }
    public float widthOfAllVisibleColumns { get; }

    public MultiColumnHeaderState(Column[] columns);

    public class Column
    {
        public bool allowToggleVisibility;
        public bool autoResize;
        public bool canSort;
        public string contextMenuText;
        public GUIContent headerContent;
        public TextAlignment headerTextAlignment;
        public float maxWidth;
        public float minWidth;
        public bool sortedAscending;
        public TextAlignment sortingArrowAlignment;
        public float width;

        public Column();

    }

}

}
