using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class GenericMenu
{
    public bool allowDuplicateNames { get; set; }

    public GenericMenu();

    public void AddDisabledItem(GUIContent content);
    public void AddDisabledItem(GUIContent content, bool on);
    public void AddItem(GUIContent content, bool on, MenuFunction func);
    public void AddItem(GUIContent content, bool on, MenuFunction2 func, object userData);
    public void AddSeparator(string path);
    public void DropDown(Rect position);
    public int GetItemCount();
    public void ShowAsContext();

    public delegate void MenuFunction();

    public delegate void MenuFunction2(object userData);

}

}
