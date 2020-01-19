using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public static class Social
{
    static public SocialPlatforms.ISocialPlatform Active { get; set; }
    static public SocialPlatforms.ILocalUser localUser { get; }

    static public SocialPlatforms.IAchievement CreateAchievement();
    static public SocialPlatforms.ILeaderboard CreateLeaderboard();
    static public void LoadAchievementDescriptions(Action<SocialPlatforms.IAchievementDescription[]> callback);
    static public void LoadAchievements(Action<SocialPlatforms.IAchievement[]> callback);
    static public void LoadScores(string leaderboardID, Action<SocialPlatforms.IScore[]> callback);
    static public void LoadUsers(string[] userIDs, Action<SocialPlatforms.IUserProfile[]> callback);
    static public void ReportProgress(string achievementID, double progress, Action<bool> callback);
    static public void ReportScore(long score, string board, Action<bool> callback);
    static public void ShowAchievementsUI();
    static public void ShowLeaderboardUI();

}

}
