using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class GenericDropdownMenu : UIElements.IGenericMenu
{
    static public string checkmarkUssClassName;
    static public string containerInnerUssClassName;
    static public string containerOuterUssClassName;
    static public string itemUssClassName;
    static public string labelUssClassName;
    static public string separatorUssClassName;
    static public string ussClassName;

    public UIElements.VisualElement contentContainer { get; }

    public GenericDropdownMenu();

    public void AddDisabledItem(string itemName, bool isChecked);
    public void AddItem(string itemName, bool isChecked, Action action);
    public void AddItem(string itemName, bool isChecked, Action<object> action, object data);
    public void AddSeparator(string path);
    public void DropDown(Rect position, UIElements.VisualElement targetElement = null, bool anchored = false);

}

}
