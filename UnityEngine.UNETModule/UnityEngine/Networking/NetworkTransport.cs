using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Networking
{

public sealed class NetworkTransport
{
    static public bool IsStarted { get; }

    static public int AddHost(Networking.HostTopology topology);
    static public int AddHost(Networking.HostTopology topology, int port);
    static public int AddHost(Networking.HostTopology topology, int port, string ip);
    static public int AddHostWithSimulator(Networking.HostTopology topology, int minTimeout, int maxTimeout);
    static public int AddHostWithSimulator(Networking.HostTopology topology, int minTimeout, int maxTimeout, int port);
    static public int AddHostWithSimulator(Networking.HostTopology topology, int minTimeout, int maxTimeout, int port, string ip);
    static public void AddSceneId(int id);
    static public int AddWebsocketHost(Networking.HostTopology topology, int port);
    static public int AddWebsocketHost(Networking.HostTopology topology, int port, string ip);
    static public int Connect(int hostId, string address, int port, int exeptionConnectionId, out byte error);
    static public void ConnectAsNetworkHost(int hostId, string address, int port, Networking.Types.NetworkID network, Networking.Types.SourceID source, Networking.Types.NodeID node, out byte error);
    static public int ConnectEndPoint(int hostId, System.Net.EndPoint endPoint, int exceptionConnectionId, out byte error);
    static public int ConnectToNetworkPeer(int hostId, string address, int port, int exceptionConnectionId, int relaySlotId, Networking.Types.NetworkID network, Networking.Types.SourceID source, Networking.Types.NodeID node, out byte error);
    static public int ConnectToNetworkPeer(int hostId, string address, int port, int exceptionConnectionId, int relaySlotId, Networking.Types.NetworkID network, Networking.Types.SourceID source, Networking.Types.NodeID node, int bytesPerSec, float bucketSizeFactor, out byte error);
    static public int ConnectWithSimulator(int hostId, string address, int port, int exeptionConnectionId, out byte error, Networking.ConnectionSimulatorConfig conf);
    static public bool Disconnect(int hostId, int connectionId, out byte error);
    static public void DisconnectNetworkHost(int hostId, out byte error);
    static public bool FinishSendMulticast(int hostId, out byte error);
    static public int GetAckBufferCount(int hostId, int connectionId, out byte error);
    static public string GetAssetId(GameObject go);
    static public string GetBroadcastConnectionInfo(int hostId, out int port, out byte error);
    static public void GetBroadcastConnectionInfo(int hostId, out string address, out int port, out byte error);
    static public void GetBroadcastConnectionMessage(int hostId, byte[] buffer, int bufferSize, out int receivedSize, out byte error);
    static public string GetConnectionInfo(int hostId, int connectionId, out int port, out ulong network, out ushort dstNode, out byte error);
    static public void GetConnectionInfo(int hostId, int connectionId, out string address, out int port, out Networking.Types.NetworkID network, out Networking.Types.NodeID dstNode, out byte error);
    static public int GetCurrentIncomingMessageAmount();
    static public int GetCurrentOutgoingMessageAmount();
    static public int GetCurrentRTT(int hostId, int connectionId, out byte error);
    static public int GetCurrentRtt(int hostId, int connectionId, out byte error);
    static public int GetHostPort(int hostId);
    static public int GetIncomingMessageQueueSize(int hostId, out byte error);
    static public int GetIncomingPacketCount(int hostId, int connectionId, out byte error);
    static public int GetIncomingPacketCountForAllHosts();
    static public int GetIncomingPacketDropCountForAllHosts();
    static public int GetIncomingPacketLossCount(int hostId, int connectionId, out byte error);
    static public int GetMaxAllowedBandwidth(int hostId, int connectionId, out byte error);
    static public int GetNetIOTimeuS();
    static public int GetNetworkLostPacketNum(int hostId, int connectionId, out byte error);
    static public int GetNetworkTimestamp();
    static public int GetNextSceneId();
    static public int GetOutgoingFullBytesCount();
    static public int GetOutgoingFullBytesCountForConnection(int hostId, int connectionId, out byte error);
    static public int GetOutgoingFullBytesCountForHost(int hostId, out byte error);
    static public int GetOutgoingMessageCount();
    static public int GetOutgoingMessageCountForConnection(int hostId, int connectionId, out byte error);
    static public int GetOutgoingMessageCountForHost(int hostId, out byte error);
    static public int GetOutgoingMessageQueueSize(int hostId, out byte error);
    static public int GetOutgoingPacketCount();
    static public int GetOutgoingPacketCountForConnection(int hostId, int connectionId, out byte error);
    static public int GetOutgoingPacketCountForHost(int hostId, out byte error);
    static public int GetOutgoingPacketNetworkLossPercent(int hostId, int connectionId, out byte error);
    static public int GetOutgoingPacketOverflowLossPercent(int hostId, int connectionId, out byte error);
    static public int GetOutgoingSystemBytesCount();
    static public int GetOutgoingSystemBytesCountForConnection(int hostId, int connectionId, out byte error);
    static public int GetOutgoingSystemBytesCountForHost(int hostId, out byte error);
    static public int GetOutgoingUserBytesCount();
    static public int GetOutgoingUserBytesCountForConnection(int hostId, int connectionId, out byte error);
    static public int GetOutgoingUserBytesCountForHost(int hostId, out byte error);
    static public int GetPacketReceivedRate(int hostId, int connectionId, out byte error);
    static public int GetPacketSentRate(int hostId, int connectionId, out byte error);
    static public int GetRemoteDelayTimeMS(int hostId, int connectionId, int remoteTime, out byte error);
    static public int GetRemotePacketReceivedRate(int hostId, int connectionId, out byte error);
    static public void Init();
    static public void Init(Networking.GlobalConfig config);
    static public bool IsBroadcastDiscoveryRunning();
    static public bool NotifyWhenConnectionReadyForSend(int hostId, int connectionId, int notificationLevel, out byte error);
    static public bool QueueMessageForSending(int hostId, int connectionId, int channelId, byte[] buffer, int size, out byte error);
    static public Networking.NetworkEventType Receive(out int hostId, out int connectionId, out int channelId, byte[] buffer, int bufferSize, out int receivedSize, out byte error);
    static public Networking.NetworkEventType ReceiveFromHost(int hostId, out int connectionId, out int channelId, byte[] buffer, int bufferSize, out int receivedSize, out byte error);
    static public Networking.NetworkEventType ReceiveRelayEventFromHost(int hostId, out byte error);
    static public bool RemoveHost(int hostId);
    static public bool Send(int hostId, int connectionId, int channelId, byte[] buffer, int size, out byte error);
    static public bool SendMulticast(int hostId, int connectionId, out byte error);
    static public bool SendQueuedMessages(int hostId, int connectionId, out byte error);
    static public void SetBroadcastCredentials(int hostId, int key, int version, int subversion, out byte error);
    static public void SetPacketStat(int direction, int packetStatId, int numMsgs, int numBytes);
    static public void Shutdown();
    static public bool StartBroadcastDiscovery(int hostId, int broadcastPort, int key, int version, int subversion, byte[] buffer, int size, int timeout, out byte error);
    static public bool StartSendMulticast(int hostId, int channelId, byte[] buffer, int size, out byte error);
    static public void StopBroadcastDiscovery();

}

}
