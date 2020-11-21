using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.MPE
{

public class ChannelClient
{
    static public void Close(string channelName);
    static public UnityEditor.MPE.ChannelClientInfo GetChannelClientInfo(string channelName);
    static public UnityEditor.MPE.ChannelClientInfo GetChannelClientInfo(int clientId);
    static public UnityEditor.MPE.ChannelClientInfo[] GetChannelClientList();
    static public UnityEditor.MPE.ChannelClient GetOrCreateClient(string channelName);
    static public int NewRequestId(int clientId);
    static public void Send(int connectionId, byte[] data);
    static public void Shutdown();

    public string channelName { get; }
    public int clientId { get; }
    public bool isAutoTick { get; private set; }

    public void Close();
    public UnityEditor.MPE.ChannelClientInfo GetChannelClientInfo();
    public bool IsConnected();
    public int NewRequestId();
    public Action RegisterMessageHandler(Action<byte[]> handler);
    public Action RegisterMessageHandler(Action<string> handler);
    public void Send(byte[] data);
    public void Send(string data);
    public void Start(bool autoTick);
    public void Stop();
    public void Tick();
    public void UnregisterMessageHandler(Action<byte[]> handler);
    public void UnregisterMessageHandler(Action<string> handler);

}

}
