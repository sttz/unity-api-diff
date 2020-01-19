using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.WSA
{

public sealed class Tile
{
    static public WSA.Tile main { get; }

    static public WSA.Tile CreateOrUpdateSecondary(WSA.SecondaryTileData data);
    static public WSA.Tile CreateOrUpdateSecondary(WSA.SecondaryTileData data, Rect area);
    static public WSA.Tile CreateOrUpdateSecondary(WSA.SecondaryTileData data, Vector2 pos);
    static public void DeleteSecondary(string tileId);
    static public void DeleteSecondary(string tileId, Rect area);
    static public void DeleteSecondary(string tileId, Vector2 pos);
    static public bool Exists(string tileId);
    static public WSA.Tile[] GetSecondaries();
    static public WSA.Tile GetSecondary(string tileId);
    static public string GetTemplate(WSA.TileTemplate templ);

    public bool exists { get; }
    public bool hasUserConsent { get; }
    public string id { get; }

    public void Delete();
    public void Delete(Rect area);
    public void Delete(Vector2 pos);
    public void PeriodicBadgeUpdate(string uri, float interval);
    public void PeriodicUpdate(string uri, float interval);
    public void RemoveBadge();
    public void StopPeriodicBadgeUpdate();
    public void StopPeriodicUpdate();
    public void Update(string xml);
    public void Update(string medium, string wide, string large, string text);
    public void UpdateBadgeImage(string image);
    public void UpdateBadgeNumber(float number);

}

}
