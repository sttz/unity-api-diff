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

    protected void DrawEventHeader(Rect headerRect);
    public float GetPropertyHeight(UnityEditor.SerializedProperty property, GUIContent label);
    public void OnGUI(Rect position);
    public void OnGUI(Rect position, UnityEditor.SerializedProperty property, GUIContent label);

    protected class State
    {
        public int lastSelectedIndex;

        public State();

    }

}

}
