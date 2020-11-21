using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public class UnityEventDrawer : UnityEditor.PropertyDrawer
{
    static public bool IsPersistantListenerValid(Events.UnityEventBase dummyEvent, string methodName, Object uObject, Events.PersistentListenerMode modeEnum, Type argumentType);

    public UnityEventDrawer();

    protected void DrawEvent(Rect rect, int index, bool isActive, bool isFocused);
    protected void DrawEventHeader(Rect headerRect);
    public float GetPropertyHeight(UnityEditor.SerializedProperty property, GUIContent label);
    protected void OnAddEvent(UnityEditorInternal.ReorderableList list);
    public void OnGUI(Rect position);
    public void OnGUI(Rect position, UnityEditor.SerializedProperty property, GUIContent label);
    protected void OnRemoveEvent(UnityEditorInternal.ReorderableList list);
    protected void OnReorderEvent(UnityEditorInternal.ReorderableList list);
    protected void OnSelectEvent(UnityEditorInternal.ReorderableList list);
    protected void SetupReorderableList(UnityEditorInternal.ReorderableList list);

    protected class State
    {
        public int lastSelectedIndex;

        public State();

    }

}

}
