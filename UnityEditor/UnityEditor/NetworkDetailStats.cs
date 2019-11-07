using System;
using UnityEngine;

namespace UnityEditor
{

public class NetworkDetailStats
{
    static public void IncrementStat(NetworkDirection direction, short msgId, string entryName, int amount);
    static public void NewProfilerTick(float newTime);
    static public void ResetAll();
    static public void SetStat(NetworkDirection direction, short msgId, string entryName, int amount);

    public NetworkDetailStats();

    public enum NetworkDirection
    {
        Incoming = 0,
        Outgoing = 1,
    }

}

}
