using UnityEngine;

/// <summary>
/// The one colour table for the app. Raw values are declared FIRST and derived ones after:
/// obfuscation turns a const into a runtime static readonly and C# runs static field
/// initialisers in textual order, so a derived value declared above its source would read
/// null (CLAUDE-unity.md C.52).
/// Every colour meant for TEXT is light, because the shared font material carries a dark
/// Ink outline (C.14): Foam, Mist, Lantern and Teal only.
/// </summary>
public static class _0x857790a9
{
    public static readonly Color Harbour = new Color(0.1608f, 0.2196f, 0.2627f, 1f); // #293843
    public static readonly Color Ink = new Color(0.0863f, 0.1255f, 0.1686f, 1f); // #16202B
    public static readonly Color Mist = new Color(0.8431f, 0.8941f, 0.9098f, 1f); // #D7E4E8
    /// <summary>The same colour at a different alpha. Returns a value, so it is safe to
    /// pass around; nothing here is a void method group.</summary>
    public static Color Tint(Color _0xba80e799, float _0x16c79558)
    {
        return new Color(_0xba80e799.r, _0xba80e799.g, _0xba80e799.b, _0x16c79558);
    }

    /// <summary>Relative luminance, used to decide an outline colour for runtime text.</summary>
    public static float Luma(Color _0xd73d7b97)
    {
        return (0.299f * _0xd73d7b97.r) + (0.587f * _0xd73d7b97.g) + (0.114f * _0xd73d7b97.b);
    }

    public static readonly Color Slate = new Color(0.3098f, 0.4157f, 0.5020f, 1f); // #4F6A80
    public static readonly Color Teal = new Color(0.3843f, 0.6627f, 0.6392f, 1f); // #62A9A3
    public static readonly Color TealLift = new Color(0.4980f, 0.7608f, 0.7333f, 1f); // #7FC2BB
    public static readonly Color LanternDeep = new Color(0.7804f, 0.6039f, 0.2706f, 1f); // #C79A45
    public static readonly Color TealDeep = new Color(0.2431f, 0.4784f, 0.4706f, 1f); // #3E7A78
    public static readonly Color Abyss = new Color(0.1020f, 0.1412f, 0.1765f, 1f); // #1A242D
    public static readonly Color Foam = new Color(0.9569f, 0.9686f, 0.9725f, 1f); // #F4F7F8
    public static readonly Color Lantern = new Color(0.8784f, 0.7059f, 0.3569f, 1f); // #E0B45B
}