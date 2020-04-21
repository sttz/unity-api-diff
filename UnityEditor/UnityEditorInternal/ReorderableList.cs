using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public class ReorderableList
{
    static public Defaults defaultBehaviours { get; }

    public bool displayAdd;
    public bool displayRemove;
    public ElementCallbackDelegate drawElementBackgroundCallback;
    public ElementCallbackDelegate drawElementCallback;
    public FooterCallbackDelegate drawFooterCallback;
    public HeaderCallbackDelegate drawHeaderCallback;
    public DrawNoneElementCallback drawNoneElementCallback;
    public float elementHeight;
    public ElementHeightCallbackDelegate elementHeightCallback;
    public float footerHeight;
    public float headerHeight;
    public AddCallbackDelegate onAddCallback;
    public AddDropdownCallbackDelegate onAddDropdownCallback;
    public CanAddCallbackDelegate onCanAddCallback;
    public CanRemoveCallbackDelegate onCanRemoveCallback;
    public ChangedCallbackDelegate onChangedCallback;
    public DragCallbackDelegate onMouseDragCallback;
    public SelectCallbackDelegate onMouseUpCallback;
    public RemoveCallbackDelegate onRemoveCallback;
    public ReorderCallbackDelegate onReorderCallback;
    public ReorderCallbackDelegateWithDetails onReorderCallbackWithDetails;
    public SelectCallbackDelegate onSelectCallback;
    public bool showDefaultBackground;

    public int count { get; }
    public bool draggable { get; set; }
    public int index { get; set; }
    public IList list { get; set; }
    public UnityEditor.SerializedProperty serializedProperty { get; set; }

    public ReorderableList(IList elements, Type elementType);
    public ReorderableList(UnityEditor.SerializedObject serializedObject, UnityEditor.SerializedProperty elements);
    public ReorderableList(IList elements, Type elementType, bool draggable, bool displayHeader, bool displayAddButton, bool displayRemoveButton);
    public ReorderableList(UnityEditor.SerializedObject serializedObject, UnityEditor.SerializedProperty elements, bool draggable, bool displayHeader, bool displayAddButton, bool displayRemoveButton);

    public void DoLayoutList();
    public void DoList(Rect rect);
    public float GetHeight();
    public void GrabKeyboardFocus();
    public bool HasKeyboardControl();
    public void ReleaseKeyboardFocus();

    public delegate void AddCallbackDelegate(UnityEditorInternal.ReorderableList list);

    public delegate void AddDropdownCallbackDelegate(Rect buttonRect, UnityEditorInternal.ReorderableList list);

    public delegate bool CanAddCallbackDelegate(UnityEditorInternal.ReorderableList list);

    public delegate bool CanRemoveCallbackDelegate(UnityEditorInternal.ReorderableList list);

    public delegate void ChangedCallbackDelegate(UnityEditorInternal.ReorderableList list);

    public class Defaults
    {
        static public int dragHandleWidth = 20;
        static public int padding = 6;

        public GUIStyle boxBackground;
        public GUIStyle draggingHandle;
        public GUIStyle elementBackground;
        public GUIStyle footerBackground;
        public GUIStyle headerBackground;
        public GUIContent iconToolbarMinus;
        public GUIContent iconToolbarPlus;
        public GUIContent iconToolbarPlusMore;
        public GUIStyle preButton;

        public Defaults();

        public void DoAddButton(UnityEditorInternal.ReorderableList list);
        public void DoRemoveButton(UnityEditorInternal.ReorderableList list);
        public void DrawElement(Rect rect, UnityEditor.SerializedProperty element, object listItem, bool selected, bool focused, bool draggable);
        public void DrawElementBackground(Rect rect, int index, bool selected, bool focused, bool draggable);
        public void DrawElementDraggingHandle(Rect rect, int index, bool selected, bool focused, bool draggable);
        public void DrawFooter(Rect rect, UnityEditorInternal.ReorderableList list);
        public void DrawHeader(Rect headerRect, UnityEditor.SerializedObject serializedObject, UnityEditor.SerializedProperty element, IList elementList);
        public void DrawHeaderBackground(Rect headerRect);
        public void DrawNoneElement(Rect rect, bool draggable);

    }

    public delegate void DragCallbackDelegate(UnityEditorInternal.ReorderableList list);

    public delegate void DrawNoneElementCallback(Rect rect);

    public delegate void ElementCallbackDelegate(Rect rect, int index, bool isActive, bool isFocused);

    public delegate float ElementHeightCallbackDelegate(int index);

    public delegate void FooterCallbackDelegate(Rect rect);

    public delegate void HeaderCallbackDelegate(Rect rect);

    public delegate void RemoveCallbackDelegate(UnityEditorInternal.ReorderableList list);

    public delegate void ReorderCallbackDelegate(UnityEditorInternal.ReorderableList list);

    public delegate void ReorderCallbackDelegateWithDetails(UnityEditorInternal.ReorderableList list, int oldIndex, int newIndex);

    public delegate void SelectCallbackDelegate(UnityEditorInternal.ReorderableList list);

}

}
