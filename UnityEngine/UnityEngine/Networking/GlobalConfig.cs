using System;
using UnityEngine;

namespace UnityEngine.Networking
{

public class GlobalConfig
{
    public Action<int, int> ConnectionReadyForSend { get; set; }
    public ushort MaxHosts { get; set; }
    public uint MaxNetSimulatorTimeout { get; set; }
    public ushort MaxPacketSize { get; set; }
    public uint MaxTimerTimeout { get; set; }
    public uint MinNetSimulatorTimeout { get; set; }
    public uint MinTimerTimeout { get; set; }
    public Action<int> NetworkEventAvailable { get; set; }
    public ushort ReactorMaximumReceivedMessages { get; set; }
    public ushort ReactorMaximumSentMessages { get; set; }
    public Networking.ReactorModel ReactorModel { get; set; }
    public uint ThreadAwakeTimeout { get; set; }
    public byte ThreadPoolSize { get; set; }

    public GlobalConfig();

}

}
