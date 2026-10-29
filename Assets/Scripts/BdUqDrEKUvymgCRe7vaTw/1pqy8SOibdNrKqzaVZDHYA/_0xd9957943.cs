using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xd9957943
{
    public static class _0x4f88f6a3
    {
        public static int _0x385b7ed3
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x9cd1d481._0xbe51f507(new byte[5] { 164, 136, 142, 137, 148 }, 231)))
                    PlayerPrefs.SetInt(_0x9cd1d481._0xbe51f507(new byte[5] { 54, 26, 28, 27, 6 }, 117), 0);
                return PlayerPrefs.GetInt(_0x9cd1d481._0xbe51f507(new byte[5] { 160, 140, 138, 141, 144 }, 227));
            }

            set
            {
                PlayerPrefs.SetInt(_0x9cd1d481._0xbe51f507(new byte[5] { 104, 68, 66, 69, 88 }, 43), value);
                _0x83b8da7d.Instance._0x7bae8038();
            }
        }
    }

    public class _0x9fc666e6
    {
        private static readonly _0x9fc666e6 _0x6c999ed0 = new();
        public static readonly _0x9fc666e6[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x6c999ed0,
            _0x6c999ed0,
            _0x6c999ed0,
        };
        private int _0xa9a7e219 => 0;
        private int _0x88dd1167 => 10;
        private string _0xb9f13657 => _0x9cd1d481._0xbe51f507(new byte[4] { 250, 210, 217, 194 }, 183);
        private string _0xd4640192 => _0x9cd1d481._0xbe51f507(new byte[8] { 173, 164, 183, 164, 173, 154, 209, 156 }, 225);

        private int _0x7143ea6a
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x9cd1d481._0xbe51f507(new byte[25] { 58, 12, 11, 11, 28, 23, 13, 62, 21, 22, 27, 24, 21, 58, 17, 24, 9, 13, 28, 11, 48, 23, 29, 28, 1 }, 121)))
                    PlayerPrefs.SetInt(_0x9cd1d481._0xbe51f507(new byte[25] { 174, 152, 159, 159, 136, 131, 153, 170, 129, 130, 143, 140, 129, 174, 133, 140, 157, 153, 136, 159, 164, 131, 137, 136, 149 }, 237), 0);
                return PlayerPrefs.GetInt(_0x9cd1d481._0xbe51f507(new byte[25] { 64, 118, 113, 113, 102, 109, 119, 68, 111, 108, 97, 98, 111, 64, 107, 98, 115, 119, 102, 113, 74, 109, 103, 102, 123 }, 3));
            }

            set => PlayerPrefs.SetInt(_0x9cd1d481._0xbe51f507(new byte[25] { 74, 124, 123, 123, 108, 103, 125, 78, 101, 102, 107, 104, 101, 74, 97, 104, 121, 125, 108, 123, 64, 103, 109, 108, 113 }, 9), value);
        }

        public int _0x4f1b1f4c
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xb9f13657}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0xb9f13657}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0xb9f13657}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0xb9f13657}CurrentLevelIndex", value);
        }

        public int _0xb7a8879d
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xb9f13657}BestScore"))
                    this._0xb7a8879d = 0;
                return PlayerPrefs.GetInt($"{this._0xb9f13657}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0xb9f13657}BestScore", value);
        }

        public bool _0xde325621
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xb9f13657}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0xb9f13657}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0xb9f13657}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0xb9f13657}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x23baba46
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0x38608dc2
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x35830778
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }
}

internal static class _0x9cd1d481
{
    internal static string _0xbe51f507(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}