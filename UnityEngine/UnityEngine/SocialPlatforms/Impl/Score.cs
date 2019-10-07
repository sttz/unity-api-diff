using System;
using UnityEngine;

namespace UnityEngine.SocialPlatforms.Impl
{

public class Score : SocialPlatforms.IScore
{
    public DateTime date { get; }
    public string formattedValue { get; }
    public string leaderboardID { get; set; }
    public int rank { get; }
    public string userID { get; }
    public long value { get; set; }

    public Score();
    public Score(string leaderboardID, long value);
    public Score(string leaderboardID, long value, string userID, DateTime date, string formattedValue, int rank);

    public void ReportScore(Action<bool> callback);
    public void SetDate(DateTime date);
    public void SetFormattedValue(string value);
    public void SetRank(int rank);
    public void SetUserID(string userID);
    public string ToString();

}

}
