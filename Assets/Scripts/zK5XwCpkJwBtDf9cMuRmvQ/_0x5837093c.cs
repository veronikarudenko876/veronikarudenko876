using TMPro;
using UnityEngine;

/// <summary>
/// Text created from code never reaches the scene files, so the pipeline's contrast stage
/// cannot see it (CLAUDE-unity.md C.10). Every runtime label therefore gets its own material
/// instance with an outline chosen against its own face colour.
/// </summary>
public static class _0x5837093c
{
    /// <summary>
    /// Give a label an outline that contrasts with its face. Reading fontMaterial creates a
    /// per-label INSTANCE, so the shared asset is untouched.
    /// </summary>
    public static void ApplyOutline(TMP_Text _0xdc13f984, float width)
    {
        if (_0xdc13f984 == null)
        {
            return;
        }

        Material _0x72e2a0e4 = _0xdc13f984.fontMaterial;
        if (_0x72e2a0e4 == null)
        {
            return;
        }

        Color _0xb91a5a03 = _0xdc13f984.color;
        Color _0x848ba760 = _0x857790a9.Luma(_0xb91a5a03) < 0.5f ? _0x857790a9.Foam : _0x857790a9.Ink;
        _0x72e2a0e4.EnableKeyword(_0x2ebc413f._0xde98e281(new byte[10] { 136, 146, 147, 139, 142, 137, 130, 152, 136, 137 }, 199));
        _0x72e2a0e4.SetColor(ShaderUtilities.ID_OutlineColor, _0x848ba760);
        _0x72e2a0e4.SetFloat(ShaderUtilities.ID_OutlineWidth, width);
    }
}

internal static class _0x2ebc413f
{
    internal static string _0xde98e281(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}