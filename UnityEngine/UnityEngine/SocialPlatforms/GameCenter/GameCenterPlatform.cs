using System;
using UnityEngine;

namespace UnityEngine.SocialPlatforms.GameCenter
{

public class GameCenterPlatform : SocialPlatforms.ISocialPlatform
{
    static public void ResetAllAchievements(Action<bool> callback);
    static public void ShowDefaultAchievementCompletionBanner(bool value);
    static public void ShowLeaderboardUI(string leaderboardID, SocialPlatforms.TimeScope timeScope);

    public SocialPlatforms.ILocalUser localUser { get; }

    public GameCenterPlatform();

    public SocialPlatforms.IAchievement CreateAchievement();
    public SocialPlatforms.ILeaderboard CreateLeaderboard();
    public bool GetLoading(SocialPlatforms.ILeaderboard board);
    public void LoadAchievementDescriptions(Action<SocialPlatforms.IAchievementDescription[]> callback);
    public void LoadAchievements(Action<SocialPlatforms.IAchievement[]> callback);
    public void LoadScores(string category, Action<SocialPlatforms.IScore[]> callback);
    public void LoadScores(SocialPlatforms.ILeaderboard board, Action<bool> callback);
    public void LoadUsers(string[] userIds, Action<SocialPlatforms.IUserProfile[]> callback);
    public void ReportProgress(string id, double progress, Action<bool> callback);
    public void ReportScore(long score, string board, Action<bool> callback);
    public void ShowAchievementsUI();
    public void ShowLeaderboardUI();

}

}
