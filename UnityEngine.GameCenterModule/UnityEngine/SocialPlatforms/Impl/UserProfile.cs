using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SocialPlatforms.Impl
{

public class UserProfile : SocialPlatforms.IUserProfile
{
    protected string m_ID;
    protected Texture2D m_Image;
    protected bool m_IsFriend;
    protected SocialPlatforms.UserState m_State;
    protected string m_UserName;

    public string gameId { get; }
    public string id { get; }
    public Texture2D image { get; }
    public bool isFriend { get; }
    public SocialPlatforms.UserState state { get; }
    public string userName { get; }

    public UserProfile();
    public UserProfile(string name, string id, bool friend);
    public UserProfile(string name, string id, bool friend, SocialPlatforms.UserState state, Texture2D image);
    public UserProfile(string name, string teamId, string gameId, bool friend, SocialPlatforms.UserState state, Texture2D image);

    public void SetImage(Texture2D image);
    public void SetIsFriend(bool value);
    public void SetState(SocialPlatforms.UserState state);
    public void SetUserGameID(string id);
    public void SetUserID(string id);
    public void SetUserName(string name);
    public string ToString();

}

}
