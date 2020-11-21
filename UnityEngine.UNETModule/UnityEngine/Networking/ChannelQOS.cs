using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Networking
{

public class ChannelQOS
{
    public bool BelongsToSharedOrderChannel { get; }
    public Networking.QosType QOS { get; }

    public ChannelQOS();
    public ChannelQOS(Networking.ChannelQOS channel);
    public ChannelQOS(Networking.QosType value);

}

}
