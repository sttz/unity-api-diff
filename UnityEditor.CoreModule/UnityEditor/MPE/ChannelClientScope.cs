using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.MPE
{

public struct ChannelClientScope : IDisposable
{
    public UnityEditor.MPE.ChannelClient client { get; private set; }

    public ChannelClientScope(bool autoTick, string channelName, Action<byte[]> handler, bool closeClientOnExit = true);
    public ChannelClientScope(bool autoTick, string channelName, Action<string> handler, bool closeClientOnExit = true);

    public void Dispose();

}

}
