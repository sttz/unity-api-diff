using System;
using UnityEngine;

namespace UnityEngine.Networking
{

public class ChannelQOS
{
    public bool BelongsToSharedOrderChannel { get; }
    public Networking.QosType QOS { get; }

    public ChannelQOS(Networking.QosType value);
    public ChannelQOS();
    public ChannelQOS(Networking.ChannelQOS channel);

}

}
