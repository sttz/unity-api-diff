using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.MPE
{

public static class ChannelService
{
    static public void Broadcast(int channelId, byte[] data);
    static public void Broadcast(int channelId, string data);
    static public void BroadcastBinary(int channelId, byte[] data);
    static public int ChannelNameToId(string channelName);
    static public void CloseChannel(string channelName);
    static public string GetAddress();
    static public UnityEditor.MPE.ChannelClientInfo[] GetChannelClientList();
    static public UnityEditor.MPE.ChannelInfo[] GetChannelList();
    static public Action GetOrCreateChannel(string channelName, Action<int, byte[]> handler);
    static public int GetPort();
    static public bool IsRunning();
    static public Action RegisterMessageHandler(string channelName, Action<int, byte[]> handler);
    static public void Send(int connectionId, byte[] data);
    static public void Send(int connectionId, string data);
    static public void Start();
    static public void Stop();
    static public void UnregisterMessageHandler(string channelName, Action<int, byte[]> handler);

}

}
