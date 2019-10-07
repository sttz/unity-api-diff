using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class DropdownMenuAction : UIElements.DropdownMenuItem
{
    static public Status AlwaysDisabled(UIElements.DropdownMenuAction a);
    static public Status AlwaysEnabled(UIElements.DropdownMenuAction a);

    public UIElements.DropdownMenuEventInfo eventInfo { get; private set; }
    public string name { get; }
    public Status status { get; private set; }
    public object userData { get; private set; }

    public DropdownMenuAction(string actionName, Action<UIElements.DropdownMenuAction> actionCallback, Func<UIElements.DropdownMenuAction, Status> actionStatusCallback, object userData = null);

    public void Execute();
    public void UpdateActionStatus(UIElements.DropdownMenuEventInfo eventInfo);

    public enum Status
    {
        None = 0,
        Normal = 1,
        Disabled = 2,
        Checked = 4,
        Hidden = 8,
    }

}

}
