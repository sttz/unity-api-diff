using System;
using UnityEngine;

namespace UnityEngine
{

public class UnityEventQueueSystem
{
    static public string GenerateEventIdForPayload(string eventPayloadName);
    static public IntPtr GetGlobalEventQueue();

    public UnityEventQueueSystem();

}

}
