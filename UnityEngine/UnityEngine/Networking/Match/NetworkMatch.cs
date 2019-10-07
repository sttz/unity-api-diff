using System;
using UnityEngine;

namespace UnityEngine.Networking.Match
{

public class NetworkMatch : MonoBehaviour
{
    public Uri baseUri { get; set; }

    public NetworkMatch();

    public Coroutine CreateMatch(string matchName, uint matchSize, bool matchAdvertise, string matchPassword, string publicClientAddress, string privateClientAddress, int eloScoreForMatch, int requestDomain, DataResponseDelegate<Networking.Match.MatchInfo> callback);
    public Coroutine DestroyMatch(Networking.Types.NetworkID netId, int requestDomain, BasicResponseDelegate callback);
    public Coroutine DropConnection(Networking.Types.NetworkID netId, Networking.Types.NodeID dropNodeId, int requestDomain, BasicResponseDelegate callback);
    public Coroutine JoinMatch(Networking.Types.NetworkID netId, string matchPassword, string publicClientAddress, string privateClientAddress, int eloScoreForClient, int requestDomain, DataResponseDelegate<Networking.Match.MatchInfo> callback);
    public Coroutine ListMatches(int startPageNumber, int resultPageSize, string matchNameFilter, bool filterOutPrivateMatchesFromResults, int eloScoreTarget, int requestDomain, DataResponseDelegate<System.Collections.Generic.List<Networking.Match.MatchInfoSnapshot>> callback);
    public Coroutine SetMatchAttributes(Networking.Types.NetworkID networkId, bool isListed, int requestDomain, BasicResponseDelegate callback);
    public void SetProgramAppID(Networking.Types.AppID programAppID);

    public delegate void BasicResponseDelegate(bool success, string extendedInfo);

    public delegate void DataResponseDelegate`1(bool success, string extendedInfo, T responseData);

}

}
