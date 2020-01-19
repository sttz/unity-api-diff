using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SocialPlatforms
{

public interface IScore
{
    public DateTime date { get; }
    public string formattedValue { get; }
    public string leaderboardID { get; set; }
    public int rank { get; }
    public string userID { get; }
    public long value { get; set; }

    public void ReportScore(Action<bool> callback);

}

}
