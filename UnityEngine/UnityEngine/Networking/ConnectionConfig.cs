using System;
using UnityEngine;

namespace UnityEngine.Networking
{

public class ConnectionConfig
{
    static public void Validate(Networking.ConnectionConfig config);

    public uint AckDelay { get; set; }
    public Networking.ConnectionAcksType AcksType { get; set; }
    public uint AllCostTimeout { get; set; }
    public float BandwidthPeakFactor { get; set; }
    public int ChannelCount { get; }
    public System.Collections.Generic.List<Networking.ChannelQOS> Channels { get; }
    public uint ConnectTimeout { get; set; }
    public uint DisconnectTimeout { get; set; }
    public ushort FragmentSize { get; set; }
    public uint InitialBandwidth { get; set; }
    public bool IsAcksLong { get; set; }
    public ushort MaxCombinedReliableMessageCount { get; set; }
    public ushort MaxCombinedReliableMessageSize { get; set; }
    public byte MaxConnectionAttempt { get; set; }
    public ushort MaxSentMessageQueueSize { get; set; }
    public uint MinUpdateTimeout { get; set; }
    public byte NetworkDropThreshold { get; set; }
    public byte OverflowDropThreshold { get; set; }
    public ushort PacketSize { get; set; }
    public uint PingTimeout { get; set; }
    public uint ReducedPingTimeout { get; set; }
    public uint ResendTimeout { get; set; }
    public uint SendDelay { get; set; }
    public int SharedOrderChannelCount { get; }
    public string SSLCAFilePath { get; set; }
    public string SSLCertFilePath { get; set; }
    public string SSLPrivateKeyFilePath { get; set; }
    public uint UdpSocketReceiveBufferMaxSize { get; set; }
    public bool UsePlatformSpecificProtocols { get; set; }
    public ushort WebSocketReceiveBufferMaxSize { get; set; }

    public ConnectionConfig();
    public ConnectionConfig(Networking.ConnectionConfig config);

    public byte AddChannel(Networking.QosType value);
    public Networking.QosType GetChannel(byte idx);
    public System.Collections.Generic.IList<byte> GetSharedOrderChannels(byte idx);
    public void MakeChannelsSharedOrder(System.Collections.Generic.List<byte> channelIndices);

}

}
