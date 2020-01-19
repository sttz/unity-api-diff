using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public class ProfilerFrameDataMultiColumnHeader : UnityEditor.IMGUI.Controls.MultiColumnHeader
{
    static public int GetMultiColumnHeaderIndex(Column[] columns, int profilerColumn);

    public Column[] columns { get; }
    public int sortedProfilerColumn { get; }
    public bool sortedProfilerColumnAscending { get; }

    public ProfilerFrameDataMultiColumnHeader(UnityEditor.IMGUI.Controls.MultiColumnHeaderState state, Column[] columns);

    public int GetMultiColumnHeaderIndex(int profilerColumn);
    public int GetProfilerColumn(int multiColumnHeaderIndex);

    public struct Column
    {
        public GUIContent headerLabel;
        public int profilerColumn;

    }

}

}
