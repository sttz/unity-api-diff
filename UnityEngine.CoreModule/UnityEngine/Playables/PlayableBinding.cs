using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Playables
{

public struct PlayableBinding
{
    static public double DefaultDuration;
    static public Playables.PlayableBinding[] None;

    public Type outputTargetType { get; }
    public Type sourceBindingType { get; set; }
    public Object sourceObject { get; set; }
    public string streamName { get; set; }
    public Playables.DataStreamType streamType { get; set; }

}

}
