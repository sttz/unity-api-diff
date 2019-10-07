using System;
using UnityEngine;

namespace UnityEngine.SocialPlatforms
{

public class Local : SocialPlatforms.ISocialPlatform
{
    public SocialPlatforms.ILocalUser localUser { get; }

    public Local();

    public SocialPlatforms.IAchievement CreateAchievement();
    public SocialPlatforms.ILeaderboard CreateLeaderboard();
    public void LoadAchievementDescriptions(Action<SocialPlatforms.IAchievementDescription[]> callback);
    public void LoadAchievements(Action<SocialPlatforms.IAchievement[]> callback);
    public void LoadScores(string leaderboardID, Action<SocialPlatforms.IScore[]> callback);
    public void LoadUsers(string[] userIDs, Action<SocialPlatforms.IUserProfile[]> callback);
    public void ReportProgress(string id, double progress, Action<bool> callback);
    public void ReportScore(long score, string board, Action<bool> callback);
    public void ShowAchievementsUI();
    public void ShowLeaderboardUI();

}

}
