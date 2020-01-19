using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class RemoteNotification
{
    public string alertBody { get; }
    public int applicationIconBadgeNumber { get; }
    public bool hasAction { get; }
    public string soundName { get; }
    public IDictionary userInfo { get; }

    public RemoteNotification();

}

}
