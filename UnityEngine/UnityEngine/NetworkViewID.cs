using System;
using UnityEngine;

namespace UnityEngine
{

public struct NetworkViewID
{
    static public NetworkViewID unassigned { get; }

    public bool isMine { get; }
    public NetworkPlayer owner { get; }

}

}
