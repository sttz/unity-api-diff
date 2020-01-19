using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class DropdownMenu
{
    public DropdownMenu();

    public void AppendAction(string actionName, Action<MenuAction> action, Func<MenuAction, StatusFlags> actionStatusCallback, object userData = null);
    public void AppendSeparator(string subMenuPath = null);
    public void InsertAction(int atIndex, string actionName, Action<MenuAction> action, Func<MenuAction, StatusFlags> actionStatusCallback, object userData = null);
    public void InsertSeparator(string subMenuPath, int atIndex);
    public List<MenuItem> MenuItems();
    public void PrepareForDisplay(Experimental.UIElements.EventBase e);
    public void RemoveItemAt(int index);

    public class EventInfo
    {
        public Vector2 localMousePosition { get; }
        public EventModifiers modifiers { get; }
        public Vector2 mousePosition { get; }

        public EventInfo(Experimental.UIElements.EventBase e);

    }

    public class MenuAction : MenuItem
    {
        static public StatusFlags AlwaysDisabled(MenuAction a);
        static public StatusFlags AlwaysEnabled(MenuAction a);

        public string name;

        public EventInfo eventInfo { get; private set; }
        public StatusFlags status { get; private set; }
        public object userData { get; private set; }

        public MenuAction(string actionName, Action<MenuAction> actionCallback, Func<MenuAction, StatusFlags> actionStatusCallback, object userData = null);

        public void Execute();
        public void UpdateActionStatus(EventInfo eventInfo);

        public enum StatusFlags
        {
            Normal = 0,
            Disabled = 1,
            Checked = 2,
            Hidden = 4,
        }

    }

    public abstract class MenuItem
    {
        protected MenuItem();

    }

    public class Separator : MenuItem
    {
        public string subMenuPath;

        public Separator(string subMenuPath);

    }

}

}
