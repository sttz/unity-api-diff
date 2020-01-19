using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class Network
{
    static public NetworkPlayer[] connections { get; }
    static public string connectionTesterIP { get; set; }
    static public int connectionTesterPort { get; set; }
    static public string incomingPassword { get; set; }
    static public bool isClient { get; }
    static public bool isMessageQueueRunning { get; set; }
    static public bool isServer { get; }
    static public NetworkLogLevel logLevel { get; set; }
    static public int maxConnections { get; set; }
    static public int minimumAllocatableViewIDs { get; set; }
    static public string natFacilitatorIP { get; set; }
    static public int natFacilitatorPort { get; set; }
    static public NetworkPeerType peerType { get; }
    static public NetworkPlayer player { get; }
    static public string proxyIP { get; set; }
    static public string proxyPassword { get; set; }
    static public int proxyPort { get; set; }
    static public float sendRate { get; set; }
    static public double time { get; }
    static public bool useNat { get; set; }
    static public bool useProxy { get; set; }

    static public NetworkViewID AllocateViewID();
    static public void CloseConnection(NetworkPlayer target, bool sendDisconnectionNotification);
    static public NetworkConnectionError Connect(string GUID);
    static public NetworkConnectionError Connect(HostData hostData);
    static public NetworkConnectionError Connect(string GUID, string password);
    static public NetworkConnectionError Connect(HostData hostData, string password);
    static public NetworkConnectionError Connect(string IP, int remotePort);
    static public NetworkConnectionError Connect(string[] IPs, int remotePort);
    static public NetworkConnectionError Connect(string IP, int remotePort, string password);
    static public NetworkConnectionError Connect(string[] IPs, int remotePort, string password);
    static public void Destroy(GameObject gameObject);
    static public void Destroy(NetworkViewID viewID);
    static public void DestroyPlayerObjects(NetworkPlayer playerID);
    static public void Disconnect();
    static public void Disconnect(int timeout);
    static public int GetAveragePing(NetworkPlayer player);
    static public int GetLastPing(NetworkPlayer player);
    static public bool HavePublicAddress();
    static public void InitializeSecurity();
    static public NetworkConnectionError InitializeServer(int connections, int listenPort);
    static public NetworkConnectionError InitializeServer(int connections, int listenPort, bool useNat);
    static public Object Instantiate(Object prefab, Vector3 position, Quaternion rotation, int group);
    static public void RemoveRPCs(NetworkPlayer playerID);
    static public void RemoveRPCs(NetworkViewID viewID);
    static public void RemoveRPCs(NetworkPlayer playerID, int group);
    static public void RemoveRPCsInGroup(int group);
    static public void SetLevelPrefix(int prefix);
    static public void SetReceivingEnabled(NetworkPlayer player, int group, bool enabled);
    static public void SetSendingEnabled(int group, bool enabled);
    static public void SetSendingEnabled(NetworkPlayer player, int group, bool enabled);
    static public ConnectionTesterStatus TestConnection();
    static public ConnectionTesterStatus TestConnection(bool forceTest);
    static public ConnectionTesterStatus TestConnectionNAT();
    static public ConnectionTesterStatus TestConnectionNAT(bool forceTest);

    public Network();

}

}
