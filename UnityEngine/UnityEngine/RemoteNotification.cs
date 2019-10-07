using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class RemoteNotification
{
    public string alertBody { get; }
    public int applicationIconBadgeNumber { get; }
    public bool hasAction { get; }
    public string soundName { get; }
    public System.Collections.IDictionary userInfo { get; }

    public RemoteNotification();

}

}
