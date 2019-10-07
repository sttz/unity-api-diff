using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class DropdownMenu
{
    public DropdownMenu();

    public void AppendAction(string actionName, Action<UIElements.DropdownMenuAction> action, Func<UIElements.DropdownMenuAction, Status> actionStatusCallback, object userData = null);
    public void AppendAction(string actionName, Action<UIElements.DropdownMenuAction> action, Status status = 1);
    public void AppendSeparator(string subMenuPath = null);
    public void InsertAction(int atIndex, string actionName, Action<UIElements.DropdownMenuAction> action, Func<UIElements.DropdownMenuAction, Status> actionStatusCallback, object userData = null);
    public void InsertAction(int atIndex, string actionName, Action<UIElements.DropdownMenuAction> action, Status status = 1);
    public void InsertSeparator(string subMenuPath, int atIndex);
    public System.Collections.Generic.List<UIElements.DropdownMenuItem> MenuItems();
    public void PrepareForDisplay(UIElements.EventBase e);
    public void RemoveItemAt(int index);

}

}
