using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.iOS
{

public sealed class RemoteNotification
{
    public string alertBody { get; }
    public string alertTitle { get; }
    public int applicationIconBadgeNumber { get; }
    public bool hasAction { get; }
    public string soundName { get; }
    public IDictionary userInfo { get; }

}

}
