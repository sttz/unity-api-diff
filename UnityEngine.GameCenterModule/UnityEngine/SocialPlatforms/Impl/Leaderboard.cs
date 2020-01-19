using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SocialPlatforms.Impl
{

public class Leaderboard : SocialPlatforms.ILeaderboard
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

    public Leaderboard();

    public string[] GetUserFilter();
    public void LoadScores(Action<bool> callback);
    public void SetLocalUserScore(SocialPlatforms.IScore score);
    public void SetMaxRange(uint maxRange);
    public void SetScores(SocialPlatforms.IScore[] scores);
    public void SetTitle(string title);
    public void SetUserFilter(string[] userIDs);
    public string ToString();

}

}
