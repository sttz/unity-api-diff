using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Networking
{

public enum NetworkEventType
{
    DataEvent = 0,
    ConnectEvent = 1,
    DisconnectEvent = 2,
    Nothing = 3,
    BroadcastEvent = 4,
}

}
