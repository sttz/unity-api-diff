using System;
using UnityEngine;

namespace UnityEngine
{

public class MasterServer
{
    static public bool dedicatedServer { get; set; }
    static public string ipAddress { get; set; }
    static public int port { get; set; }
    static public int updateRate { get; set; }

    static public void ClearHostList();
    static public HostData[] PollHostList();
    static public void RegisterHost(string gameTypeName, string gameName);
    static public void RegisterHost(string gameTypeName, string gameName, string comment);
    static public void RequestHostList(string gameTypeName);
    static public void UnregisterHost();

    public MasterServer();

}

}
