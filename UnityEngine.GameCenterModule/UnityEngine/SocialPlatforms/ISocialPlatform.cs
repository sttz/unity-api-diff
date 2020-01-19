using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SocialPlatforms
{

public interface ISocialPlatform
{
    public SocialPlatforms.ILocalUser localUser { get; }

    public void Authenticate(SocialPlatforms.ILocalUser user, Action<bool> callback);
    public void Authenticate(SocialPlatforms.ILocalUser user, Action<bool, string> callback);
    public SocialPlatforms.IAchievement CreateAchievement();
    public SocialPlatforms.ILeaderboard CreateLeaderboard();
    public bool GetLoading(SocialPlatforms.ILeaderboard board);
    public void LoadAchievementDescriptions(Action<SocialPlatforms.IAchievementDescription[]> callback);
    public void LoadAchievements(Action<SocialPlatforms.IAchievement[]> callback);
    public void LoadFriends(SocialPlatforms.ILocalUser user, Action<bool> callback);
    public void LoadScores(SocialPlatforms.ILeaderboard board, Action<bool> callback);
    public void LoadScores(string leaderboardID, Action<SocialPlatforms.IScore[]> callback);
    public void LoadUsers(string[] userIDs, Action<SocialPlatforms.IUserProfile[]> callback);
    public void ReportProgress(string achievementID, double progress, Action<bool> callback);
    public void ReportScore(long score, string board, Action<bool> callback);
    public void ShowAchievementsUI();
    public void ShowLeaderboardUI();

}

}
