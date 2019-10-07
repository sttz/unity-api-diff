using System;
using UnityEngine;

namespace UnityEngine.SocialPlatforms
{

public interface ILeaderboard
{
    public string id { get; set; }
    public bool loading { get; }
    public SocialPlatforms.IScore localUserScore { get; }
    public uint maxRange { get; }
    public SocialPlatforms.Range range { get; set; }
    public SocialPlatforms.IScore[] scores { get; }
    public SocialPlatforms.TimeScope timeScope { get; set; }
    public string title { get; }
    public SocialPlatforms.UserScope userScope { get; set; }

    public void LoadScores(Action<bool> callback);
    public void SetUserFilter(string[] userIDs);

}

}
