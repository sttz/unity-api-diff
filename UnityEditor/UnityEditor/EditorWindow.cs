using System;
using UnityEngine;

namespace UnityEditor
{

public class EditorWindow : ScriptableObject
{
    static public UnityEditor.EditorWindow focusedWindow { get; }
    static public UnityEditor.EditorWindow mouseOverWindow { get; }

    static public T CreateWindow(Type[] desiredDockNextTo);
    static public T CreateWindow(string title, Type[] desiredDockNextTo);
    static public void FocusWindowIfItsOpen(Type t);
    static public void FocusWindowIfItsOpen();
    static public UnityEditor.EditorWindow GetWindow(Type t, bool utility, string title, bool focus);
    static public UnityEditor.EditorWindow GetWindow(Type t, bool utility, string title);
    static public UnityEditor.EditorWindow GetWindow(Type t, bool utility);
    static public UnityEditor.EditorWindow GetWindow(Type t);
    static public T GetWindow();
    static public T GetWindow(bool utility);
    static public T GetWindow(bool utility, string title);
    static public T GetWindow(string title);
    static public T GetWindow(string title, bool focus);
    static public T GetWindow(bool utility, string title, bool focus);
    static public T GetWindow(Type[] desiredDockNextTo);
    static public T GetWindow(string title, Type[] desiredDockNextTo);
    static public T GetWindow(string title, bool focus, Type[] desiredDockNextTo);
    static public UnityEditor.EditorWindow GetWindowWithRect(Type t, Rect rect, bool utility, string title);
    static public UnityEditor.EditorWindow GetWindowWithRect(Type t, Rect rect, bool utility);
    static public UnityEditor.EditorWindow GetWindowWithRect(Type t, Rect rect);
    static public T GetWindowWithRect(Rect rect);
    static public T GetWindowWithRect(Rect rect, bool utility);
    static public T GetWindowWithRect(Rect rect, bool utility, string title);
    static public T GetWindowWithRect(Rect rect, bool utility, string title, bool focus);
    static public bool HasOpenInstances();

    public int antiAlias { get; set; }
    public bool autoRepaintOnSceneChange { get; set; }
    public int depthBufferBits { get; set; }
    public bool docked { get; }
    public bool hasFocus { get; }
    public bool maximized { get; set; }
    public Vector2 maxSize { get; set; }
    public Vector2 minSize { get; set; }
    public Rect position { get; set; }
    public UIElements.VisualElement rootVisualElement { get; }
    public string title { get; set; }
    public GUIContent titleContent { get; set; }
    public bool wantsMouseEnterLeaveWindow { get; set; }
    public bool wantsMouseMove { get; set; }

    public EditorWindow();

    public void BeginWindows();
    public void Close();
    public void EndWindows();
    public void Focus();
    public System.Collections.Generic.IEnumerable<Type> GetExtraPaneTypes();
    public void RemoveNotification();
    public void Repaint();
    public bool SendEvent(Event e);
    public void Show();
    public void Show(bool immediateDisplay);
    public void ShowAsDropDown(Rect buttonRect, Vector2 windowSize);
    public void ShowAuxWindow();
    public void ShowModal();
    public void ShowModalUtility();
    public void ShowNotification(GUIContent notification);
    public void ShowNotification(GUIContent notification, double fadeoutWait);
    public void ShowPopup();
    public void ShowTab();
    public void ShowUtility();

}

}
