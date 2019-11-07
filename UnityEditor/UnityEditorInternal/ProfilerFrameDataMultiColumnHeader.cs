using System;
using UnityEngine;

namespace UnityEditorInternal
{

public class ProfilerFrameDataMultiColumnHeader : UnityEditor.IMGUI.Controls.MultiColumnHeader
{
    static public int GetMultiColumnHeaderIndex(Column[] columns, UnityEditorInternal.Profiling.ProfilerColumn profilerColumn);

    public Column[] columns { get; }
    public UnityEditorInternal.Profiling.ProfilerColumn sortedProfilerColumn { get; }
    public bool sortedProfilerColumnAscending { get; }

    public ProfilerFrameDataMultiColumnHeader(UnityEditor.IMGUI.Controls.MultiColumnHeaderState state, Column[] columns);

    public int GetMultiColumnHeaderIndex(UnityEditorInternal.Profiling.ProfilerColumn profilerColumn);
    public UnityEditorInternal.Profiling.ProfilerColumn GetProfilerColumn(int multiColumnHeaderIndex);

    public struct Column
    {
        public GUIContent headerLabel;
        public UnityEditorInternal.Profiling.ProfilerColumn profilerColumn;

    }

}

}
