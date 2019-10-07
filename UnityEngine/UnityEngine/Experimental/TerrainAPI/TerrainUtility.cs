using System;
using UnityEngine;

namespace UnityEngine.Experimental.TerrainAPI
{

public static class TerrainUtility
{
    static public void AutoConnect();

    public class TerrainMap
    {
        static public TerrainMap CreateFromPlacement(Terrain originTerrain, TerrainFilter filter = null, bool fullValidation = true);
        static public TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, TerrainFilter filter = null, bool fullValidation = true);

        public ErrorCode m_errorCode;
        public System.Collections.Generic.Dictionary<TileCoord, Terrain> m_terrainTiles;

        public TerrainMap();

        public Terrain GetTerrain(int tileX, int tileZ);

        public delegate bool TerrainFilter(Terrain terrain);

        public struct TileCoord
        {
            public int tileX;
            public int tileZ;

            public TileCoord(int tileX, int tileZ);

        }

        public enum ErrorCode
        {
            OK = 0,
            Overlapping = 1,
            SizeMismatch = 4,
            EdgeAlignmentMismatch = 8,
        }

    }

    public class TerrainGroups : System.Collections.Generic.Dictionary<int, TerrainMap>
    {
        public TerrainGroups();

    }

}

}
