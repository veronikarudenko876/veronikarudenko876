using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The nine berths of the shared quay as a chip ribbon, reused on HOME, on THE CREW and in
/// the harbour log. A filled chip is a berth some keeper has already taken.
/// </summary>
public sealed class _0x6e343b66
{
    private readonly Image[] _0x32c4b9b3 = new Image[_0x99c12d2e.BerthCount];
    /// <summary>Fill the first <paramref name = "filled"/> chips and update the tally line.</summary>
    public void _0xbdb52a90(int _0x01f8ad36, string _0xd19b3d18)
    {
        int _0xa85df87a = Mathf.Clamp(_0x01f8ad36, 0, _0x99c12d2e.BerthCount);
        for (int _0x5296473e = 0; _0x5296473e < this._0x32c4b9b3.Length; _0x5296473e++)
        {
            if (this._0x32c4b9b3[_0x5296473e] != null)
            {
                this._0x32c4b9b3[_0x5296473e].color = _0x5296473e < _0xa85df87a ? _0x857790a9.Teal : _0x857790a9.Tint(_0x857790a9.Slate, 0.4f);
            }
        }

        if (this._0xd1be9bd3 != null)
        {
            this._0xd1be9bd3.text = _0xa85df87a.ToString() + _0x9536f8a3._0xef551dd0(new byte[3] { 211, 220, 211 }, 243) + _0x99c12d2e.BerthCount.ToString() + _0x9536f8a3._0xef551dd0(new byte[1] { 179 }, 147) + _0xd19b3d18;
        }
    }

    /// <summary>A lantern just arrived: flash the chip that lit up, then settle it.</summary>
    public void _0x51cc9286(int _0xc7f21246)
    {
        if (_0xc7f21246 < 0 || _0xc7f21246 >= this._0x32c4b9b3.Length || this._0x32c4b9b3[_0xc7f21246] == null)
        {
            return;
        }

        Image _0x7c54d5b1 = this._0x32c4b9b3[_0xc7f21246];
        _0x7c54d5b1.color = _0x857790a9.Foam;
        _0x7c54d5b1.DOColor(_0x857790a9.Teal, 0.45f).SetEase(Ease.OutQuad).SetLink(_0x7c54d5b1.gameObject);
        _0x7c54d5b1.transform.DOScale(1.18f, 0.2f).SetLoops(2, LoopType.Yoyo).SetEase(Ease.OutBack).SetLink(_0x7c54d5b1.gameObject);
    }

    private TextMeshProUGUI _0xd1be9bd3;
    public void _0x4fe1d6c0()
    {
        for (int _0x76fbbf91 = 0; _0x76fbbf91 < this._0x32c4b9b3.Length; _0x76fbbf91++)
        {
            if (this._0x32c4b9b3[_0x76fbbf91] != null)
            {
                DOTween.Kill(this._0x32c4b9b3[_0x76fbbf91]);
                DOTween.Kill(this._0x32c4b9b3[_0x76fbbf91].transform);
            }
        }
    }

    public _0x6e343b66 _0x92f042b6(Transform _0x2184890d, _0xaed87db8 _0xe14ec360, Vector2 _0xafd4a2b9, Vector2 _0x0b5391a7, float _0x396d28c6, float _0x6f1b1340, bool _0x690dd06a)
    {
        const float _0x09d7d7d5 = 12f;
        float _0x173c727b = (_0x99c12d2e.BerthCount * _0x396d28c6) + ((_0x99c12d2e.BerthCount - 1) * _0x09d7d7d5);
        float _0xe285a926 = -(_0x173c727b * 0.5f) + (_0x396d28c6 * 0.5f);
        RectTransform _0x1f6ab53c = _0x253833cf.Node(_0x2184890d, _0x9536f8a3._0xef551dd0(new byte[6] { 80, 107, 96, 96, 109, 108 }, 2), _0xafd4a2b9, _0x0b5391a7, new Vector2(_0x173c727b, _0x6f1b1340));
        for (int _0xe5834d19 = 0; _0xe5834d19 < _0x99c12d2e.BerthCount; _0xe5834d19++)
        {
            float _0xa643913d = _0xe285a926 + (_0xe5834d19 * (_0x396d28c6 + _0x09d7d7d5));
            this._0x32c4b9b3[_0xe5834d19] = _0x253833cf.Plate(_0x1f6ab53c, _0x9536f8a3._0xef551dd0(new byte[4] { 86, 125, 124, 101 }, 21), _0x253833cf.Middle, new Vector2(_0xa643913d, 0f), new Vector2(_0x396d28c6, _0x6f1b1340), _0x857790a9.Tint(_0x857790a9.Slate, 0.4f), _0xe14ec360._0x0f6a08a7, 0.5f);
        }

        if (_0x690dd06a)
        {
            this._0xd1be9bd3 = _0x253833cf.Caption(_0x1f6ab53c, _0x9536f8a3._0xef551dd0(new byte[11] { 3, 56, 51, 51, 62, 63, 5, 48, 61, 61, 40 }, 81), _0x253833cf.Middle, new Vector2(0f, -(_0x6f1b1340 * 0.5f) - 34f), new Vector2(560f, 44f), _0x9536f8a3._0xef551dd0(new byte[12] { 85, 69, 74, 69, 92, 69, 39, 32, 55, 49, 45, 54 }, 101), 34f, _0x857790a9.Lantern, _0xe14ec360._0xed34cdf9, TextAlignmentOptions.Center);
            this._0xd1be9bd3.characterSpacing = 4f;
        }

        return this;
    }
}

internal static class _0x9536f8a3
{
    internal static string _0xef551dd0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}