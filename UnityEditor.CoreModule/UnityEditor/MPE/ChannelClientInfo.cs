using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.MPE
{

public struct ChannelClientInfo : IEquatable<UnityEditor.MPE.ChannelClientInfo>
{
    static public UnityEditor.MPE.ChannelClientInfo invalidClient;

    public int clientId { get; }
    public int connectionId { get; }
    public string name { get; }

    public bool Equals(object obj);
    public bool Equals(UnityEditor.MPE.ChannelClientInfo obj);
    public int GetHashCode();

}

}
