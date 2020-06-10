using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.MPE
{

public struct ChannelInfo : IEquatable<UnityEditor.MPE.ChannelInfo>
{
    static public UnityEditor.MPE.ChannelInfo invalidChannel;

    public int id { get; }
    public string name { get; }

    public bool Equals(object obj);
    public bool Equals(UnityEditor.MPE.ChannelInfo obj);
    public int GetHashCode();

}

}
