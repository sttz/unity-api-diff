using System;
using UnityEngine;

namespace UnityEngine.Networking
{

public class HostTopology
{
    public Networking.ConnectionConfig DefaultConfig { get; }
    public int MaxDefaultConnections { get; }
    public float MessagePoolSizeGrowthFactor { get; set; }
    public ushort ReceivedMessagePoolSize { get; set; }
    public ushort SentMessagePoolSize { get; set; }
    public System.Collections.Generic.List<Networking.ConnectionConfig> SpecialConnectionConfigs { get; }
    public int SpecialConnectionConfigsCount { get; }

    public HostTopology(Networking.ConnectionConfig defaultConfig, int maxDefaultConnections);

    public int AddSpecialConnectionConfig(Networking.ConnectionConfig config);
    public Networking.ConnectionConfig GetSpecialConnectionConfig(int i);

}

}
