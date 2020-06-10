using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.MPE
{

public struct ChannelScope : IDisposable
{
    public ChannelScope(string channelName, Action<int, byte[]> handler, bool closeChannelOnExit = true);

    public void Dispose();

}

}
