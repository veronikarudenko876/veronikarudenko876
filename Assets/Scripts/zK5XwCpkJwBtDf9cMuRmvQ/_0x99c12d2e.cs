using System;
using UnityEngine;

/// <summary>
/// What survives between watches: the keeper's lifetime pennants, how many of the nine
/// shared berths the crew has filled, which day the free lantern was last sent, and the
/// cycle counter the run seed is derived from.
///
/// Keys are inline string LITERALS on purpose: they are persisted identifiers, so nameof is
/// forbidden (obfuscation renames the member and the saved data is orphaned).
/// Nothing here is a currency - the flag tally is a count of contributions.
/// </summary>
public static class _0x99c12d2e
{
    public static void StampLanternSent()
    {
        PlayerPrefs.SetInt(_0x8d62869d._0xbb2d8e3d(new byte[15] { 46, 33, 42, 108, 46, 35, 44, 54, 39, 48, 44, 108, 38, 35, 59 }, 66), _0x1999dd53);
        PlayerPrefs.Save();
    }

    /// <summary>Today as yyyyMMdd, the stamp the one free lantern a day is gated on.</summary>
    public static int _0x1999dd53
    {
        get
        {
            DateTime _0x8c91c98a = DateTime.Now;
            return (_0x8c91c98a.Year * 10000) + (_0x8c91c98a.Month * 100) + _0x8c91c98a.Day;
        }
    }

    /// <summary>What the last watch planted, so the menu's daily goal bar reads as live
    /// progress instead of a bar that is always empty.</summary>
    public static int _0x139e33cb
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(_0x8d62869d._0xbb2d8e3d(new byte[14] { 149, 154, 145, 215, 142, 152, 141, 154, 145, 215, 149, 152, 138, 141 }, 249), 0), 0, FlagsPerWatch);
        }

        set
        {
            PlayerPrefs.SetInt(_0x8d62869d._0xbb2d8e3d(new byte[14] { 17, 30, 21, 83, 10, 28, 9, 30, 21, 83, 17, 28, 14, 9 }, 125), Mathf.Clamp(value, 0, FlagsPerWatch));
        }
    }

    public static int _0x8ddd3d0d
    {
        get
        {
            return PlayerPrefs.GetInt(_0x8d62869d._0xbb2d8e3d(new byte[17] { 166, 169, 162, 228, 189, 171, 190, 169, 162, 228, 171, 190, 190, 175, 167, 186, 190 }, 202), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x8d62869d._0xbb2d8e3d(new byte[17] { 188, 179, 184, 254, 167, 177, 164, 179, 184, 254, 177, 164, 164, 181, 189, 160, 164 }, 208), Mathf.Max(0, value));
        }
    }

    public static int _0x06417839
    {
        get
        {
            return PlayerPrefs.GetInt(_0x8d62869d._0xbb2d8e3d(new byte[15] { 37, 42, 33, 103, 42, 48, 42, 37, 44, 103, 32, 39, 45, 44, 49 }, 73), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x8d62869d._0xbb2d8e3d(new byte[15] { 142, 129, 138, 204, 129, 155, 129, 142, 135, 204, 139, 140, 134, 135, 154 }, 226), Mathf.Max(0, value));
        }
    }

    /// <summary>Record a finished watch: the flags it planted and the berths it filled.</summary>
    public static void RecordWatch(int _0x0513f11f)
    {
        _0x66d19138 = _0x66d19138 + _0x0513f11f;
        _0xd64e3fc3 = _0xd64e3fc3 + _0x0513f11f;
        _0x06417839 = _0x06417839 + 1;
        _0x139e33cb = _0x0513f11f;
        PlayerPrefs.Save();
    }

    public static int _0x66d19138
    {
        get
        {
            return PlayerPrefs.GetInt(_0x8d62869d._0xbb2d8e3d(new byte[18] { 28, 19, 24, 94, 22, 28, 17, 23, 3, 94, 28, 25, 22, 21, 4, 25, 29, 21 }, 112), 12);
        }

        set
        {
            PlayerPrefs.SetInt(_0x8d62869d._0xbb2d8e3d(new byte[18] { 227, 236, 231, 161, 233, 227, 238, 232, 252, 161, 227, 230, 233, 234, 251, 230, 226, 234 }, 143), Mathf.Max(0, value));
        }
    }

    public const int FlagsPerWatch = 3;
    public static bool _0x91e38e58
    {
        get
        {
            return PlayerPrefs.GetInt(_0x8d62869d._0xbb2d8e3d(new byte[15] { 56, 55, 60, 122, 56, 53, 58, 32, 49, 38, 58, 122, 48, 53, 45 }, 84), 0) == _0x1999dd53;
        }
    }

    public const int BerthCount = 9;
    public static int _0xd64e3fc3
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(_0x8d62869d._0xbb2d8e3d(new byte[15] { 202, 197, 206, 136, 215, 211, 199, 223, 136, 192, 207, 202, 202, 195, 194 }, 166), 4), 0, BerthCount);
        }

        set
        {
            PlayerPrefs.SetInt(_0x8d62869d._0xbb2d8e3d(new byte[15] { 50, 61, 54, 112, 47, 43, 63, 39, 112, 56, 55, 50, 50, 59, 58 }, 94), Mathf.Clamp(value, 0, BerthCount));
        }
    }
}

internal static class _0x8d62869d
{
    internal static string _0xbb2d8e3d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}