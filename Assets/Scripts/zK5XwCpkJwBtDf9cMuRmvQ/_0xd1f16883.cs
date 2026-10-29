using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The card at the foot of the quay: which activity is running, what to do, how far along
/// it is, and - for CARGO SORT only - the crest to match.
///
/// The instruction column and the crest gutter never share an x band (C.25): the text sits
/// in [-500, +320] of the card and the crest in [+385, +495], 65 units clear.
/// </summary>
public sealed class _0xd1f16883
{
    /// <summary>Fill the step ribbon. A completed pip pops, so progress is visible in a frame.</summary>
    public void _0x8477c182(int _0xfb007370)
    {
        for (int _0xa51229f2 = 0; _0xa51229f2 < this._0x0ccffb7c.Length; _0xa51229f2++)
        {
            Image _0xba222ac8 = this._0x0ccffb7c[_0xa51229f2];
            if (_0xba222ac8 == null)
            {
                continue;
            }

            bool _0x2c968a89 = _0xa51229f2 < _0xfb007370;
            Color _0x136b97d8 = _0x2c968a89 ? _0x857790a9.Teal : _0x857790a9.Tint(_0x857790a9.Slate, 0.45f);
            if (_0x2c968a89 && _0xba222ac8.color != _0x136b97d8)
            {
                _0xba222ac8.transform.localScale = Vector3.one * 0.7f;
                _0xba222ac8.transform.DOScale(1f, 0.22f).SetEase(Ease.OutBack).SetLink(_0xba222ac8.gameObject);
            }

            _0xba222ac8.color = _0x136b97d8;
        }
    }

    private const int PipCount = 3;
    private TextMeshProUGUI _0x151c617d;
    private const float CardHeight = 520f;
    private const float CardWidth = 1120f;
    private _0xaed87db8 _0xe61d0b1e;
    /// <summary>Re-dress the card for the activity that just started.</summary>
    public void _0x9d0dbc1e(int _0xe95793b2, int _0x8fba908f, string _0x85f7068a, int _0x00bbcfeb)
    {
        if (this._0xe84b8629 != null)
        {
            this._0xe84b8629.text = _0x73275764._0xea6696ee(new byte[9] { 144, 146, 133, 152, 135, 152, 133, 136, 241 }, 209) + _0xe95793b2.ToString() + _0x73275764._0xea6696ee(new byte[3] { 220, 211, 220 }, 252) + _0x8fba908f.ToString();
        }

        if (this._0x7c3486cd != null)
        {
            this._0x7c3486cd.text = _0x85f7068a;
        }

        if (this._0x772ec343 != null)
        {
            bool _0x2187cacc = _0x00bbcfeb >= 0 && this._0xe61d0b1e != null;
            this._0x772ec343.sprite = _0x2187cacc ? this._0xe61d0b1e._0x9a3eb911(_0x00bbcfeb) : null;
            this._0x772ec343.preserveAspect = true;
            this._0x772ec343.enabled = _0x2187cacc;
        }

        this._0x8477c182(0);
    }

    private Sequence _0x8e795fa5;
    private TextMeshProUGUI _0x7c3486cd;
    private TextMeshProUGUI _0xe84b8629;
    private Image _0x772ec343;
    public _0xd1f16883 _0x011de731(Transform _0x22a4a8ef, _0xaed87db8 _0x64ba5d41, float _0xb24fa425)
    {
        this._0xe61d0b1e = _0x64ba5d41;
        float _0xe67b731b = _0xb24fa425 - 360f;
        RectTransform _0xd7fb033f = _0x253833cf.Node(_0x22a4a8ef, _0x73275764._0xea6696ee(new byte[8] { 83, 102, 116, 108, 68, 102, 117, 99 }, 7), _0x253833cf.TopCentre, new Vector2(0f, -_0xe67b731b), new Vector2(CardWidth, CardHeight));
        _0x253833cf.Plate(_0xd7fb033f, _0x73275764._0xea6696ee(new byte[10] { 132, 166, 181, 163, 148, 175, 166, 163, 168, 176 }, 199), _0x253833cf.Middle, new Vector2(0f, -10f), new Vector2(CardWidth, CardHeight), _0x857790a9.Tint(_0x857790a9.Ink, 0.42f), _0x64ba5d41._0x0f6a08a7, 0.34f);
        _0x253833cf.Plate(_0xd7fb033f, _0x73275764._0xea6696ee(new byte[8] { 105, 75, 88, 78, 104, 69, 78, 83 }, 42), _0x253833cf.Middle, Vector2.zero, new Vector2(CardWidth, CardHeight), _0x857790a9.Tint(_0x857790a9.Harbour, 0.97f), _0x64ba5d41._0x0f6a08a7, 0.34f);
        _0x253833cf.Plate(_0xd7fb033f, _0x73275764._0xea6696ee(new byte[9] { 24, 58, 41, 63, 8, 51, 62, 62, 53 }, 91), _0x253833cf.Middle, new Vector2(0f, 150f), new Vector2(CardWidth - 24f, 210f), _0x857790a9.Tint(_0x857790a9.Slate, 0.28f), _0x64ba5d41._0x0f6a08a7, 0.4f);
        _0x253833cf.Plate(_0xd7fb033f, _0x73275764._0xea6696ee(new byte[8] { 255, 221, 206, 216, 249, 216, 219, 217 }, 188), _0x253833cf.Middle, new Vector2(0f, 252f), new Vector2(CardWidth - 120f, 6f), _0x857790a9.Tint(_0x857790a9.Teal, 0.55f), _0x64ba5d41._0x0f6a08a7, 1.4f);
        this._0xe84b8629 = _0x253833cf.Caption(_0xd7fb033f, _0x73275764._0xea6696ee(new byte[12] { 217, 251, 236, 241, 238, 241, 236, 225, 212, 241, 246, 253 }, 152), _0x253833cf.Middle, new Vector2(-270f, 200f), new Vector2(560f, 44f), _0x73275764._0xea6696ee(new byte[14] { 23, 21, 2, 31, 0, 31, 2, 15, 118, 103, 118, 121, 118, 101 }, 86), 32f, _0x857790a9.Mist, _0x64ba5d41._0xed34cdf9, TextAlignmentOptions.Left);
        this._0xe84b8629.characterSpacing = 6f;
        this._0x7c3486cd = _0x253833cf.Caption(_0xd7fb033f, _0x73275764._0xea6696ee(new byte[11] { 21, 50, 47, 40, 46, 41, 63, 40, 53, 51, 50 }, 92), _0x253833cf.Middle, new Vector2(-90f, 78f), new Vector2(820f, 150f), _0x73275764._0xea6696ee(new byte[39] { 136, 158, 139, 156, 151, 255, 139, 151, 154, 255, 157, 154, 158, 146, 213, 139, 151, 154, 145, 255, 139, 158, 143, 255, 139, 151, 154, 255, 140, 158, 146, 154, 255, 157, 154, 141, 139, 151, 140 }, 223), 50f, _0x857790a9.Foam, _0x64ba5d41._0xed34cdf9, TextAlignmentOptions.Left);
        this._0x772ec343 = _0x253833cf.Picture(_0xd7fb033f, _0x73275764._0xea6696ee(new byte[11] { 74, 127, 108, 121, 123, 106, 93, 108, 123, 109, 106 }, 30), _0x253833cf.Middle, new Vector2(440f, 78f), 110f, null, _0x857790a9.Foam);
        this._0x772ec343.enabled = false;
        for (int _0xe94b787b = 0; _0xe94b787b < PipCount; _0xe94b787b++)
        {
            float _0x6ac5ed18 = -166f + (_0xe94b787b * 76f);
            this._0x0ccffb7c[_0xe94b787b] = _0x253833cf.Plate(_0xd7fb033f, _0x73275764._0xea6696ee(new byte[3] { 109, 84, 77 }, 61), _0x253833cf.Middle, new Vector2(_0x6ac5ed18, -72f), new Vector2(56f, 56f), _0x857790a9.Tint(_0x857790a9.Slate, 0.45f), _0x64ba5d41._0x0f6a08a7, 0.4f);
        }

        this._0x151c617d = _0x253833cf.Caption(_0xd7fb033f, _0x73275764._0xea6696ee(new byte[10] { 84, 102, 102, 124, 102, 97, 89, 124, 123, 112 }, 21), _0x253833cf.Middle, new Vector2(0f, -182f), new Vector2(900f, 44f), _0x73275764._0xea6696ee(new byte[19] { 166, 175, 188, 172, 161, 187, 188, 206, 173, 188, 171, 185, 206, 175, 189, 189, 167, 189, 186 }, 238), 34f, _0x857790a9.Lantern, _0x64ba5d41._0xed34cdf9, TextAlignmentOptions.Center);
        this._0x151c617d.characterSpacing = 6f;
        this._0x151c617d.alpha = 0f;
        return this;
    }

    public void _0x72b9ed3e()
    {
        if (this._0x8e795fa5 != null)
        {
            this._0x8e795fa5.Kill();
            this._0x8e795fa5 = null;
        }
    }

    private readonly Image[] _0x0ccffb7c = new Image[PipCount];
    /// <summary>The crew stepping in for an idle keeper. Fades in, holds, fades out.</summary>
    public void _0x31602348()
    {
        if (this._0x151c617d == null)
        {
            return;
        }

        // Keep the handle: a DOTween.To has no target, so DOTween.Kill(label) would find
        // nothing. The sequence owns the two fades, so linking it is enough (C.56).
        if (this._0x8e795fa5 != null)
        {
            this._0x8e795fa5.Kill();
        }

        this._0x151c617d.alpha = 0f;
        Sequence _0xdd6b90ad = DOTween.Sequence().SetLink(this._0x151c617d.gameObject);
        _0xdd6b90ad.Append(DOTween.To(() => this._0x151c617d.alpha, _0x81743a1a => this._0x151c617d.alpha = _0x81743a1a, 1f, 0.25f));
        _0xdd6b90ad.AppendInterval(0.7f);
        _0xdd6b90ad.Append(DOTween.To(() => this._0x151c617d.alpha, _0x81743a1a => this._0x151c617d.alpha = _0x81743a1a, 0f, 0.25f));
        this._0x8e795fa5 = _0xdd6b90ad;
    }
}

internal static class _0x73275764
{
    internal static string _0xea6696ee(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}