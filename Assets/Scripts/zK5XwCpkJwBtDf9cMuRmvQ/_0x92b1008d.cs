using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The quay: a 3x3 grid of berths drawn as UGUI, plus the water sheet behind it and the
/// stone frame around it.
///
/// Draw order matters and is set by SIBLING order (C.13 / C.63): the water goes down first,
/// then the FRAME, and only then the berths - so even if the frame art comes back with an
/// opaque centre it sits underneath the plates instead of hiding them.
///
/// There is no physics here and none is wanted: a tap is a UGUI button on the berth itself.
/// </summary>
public sealed class _0x92b1008d
{
    public void _0x71810f49()
    {
        for (int _0x2e3c9606 = 0; _0x2e3c9606 < this._0x4c369d9e.Length; _0x2e3c9606++)
        {
            if (this._0x4c369d9e[_0x2e3c9606] != null)
            {
                this._0x4c369d9e[_0x2e3c9606]._0xf8923cfb(false);
            }
        }
    }

    public const int Rows = 3;
    private RectTransform _0xb02a2f70;
    public void _0x4b95c86b()
    {
        if (this._0xc3ebf5aa != null)
        {
            DOTween.Kill(this._0xc3ebf5aa);
            DOTween.Kill(this._0xc3ebf5aa.transform);
        }

        for (int _0x4c244359 = 0; _0x4c244359 < this._0x4c369d9e.Length; _0x4c244359++)
        {
            if (this._0x4c369d9e[_0x4c244359] != null)
            {
                this._0x4c369d9e[_0x4c244359]._0x056f613b();
            }
        }
    }

    /// <summary>The slow sweep that keeps the quay alive while nothing else moves. Endless,
    /// linked, and killed again in <see cref = "StopAmbience"/> (C.56).</summary>
    public void _0xe6fdc845(float _0x4909a4cc)
    {
        if (this._0xc3ebf5aa == null)
        {
            return;
        }

        this._0xc3ebf5aa.transform.localEulerAngles = new Vector3(0f, 0f, _0x4909a4cc * Mathf.Rad2Deg);
        this._0xc3ebf5aa.transform.DOLocalRotate(new Vector3(0f, 0f, -360f), 14f, RotateMode.LocalAxisAdd).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear).SetLink(this._0xc3ebf5aa.gameObject);
        this._0xc3ebf5aa.DOFade(0.14f, 3.2f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._0xc3ebf5aa.gameObject);
    }

    public RectTransform _0xc98837e5 => this._0xb02a2f70;

    /// <summary>
    /// Build the quay under <paramref name = "parent"/>. <paramref name = "boardSize"/> is the
    /// side of the grid in canvas units; the plate pitch and tile size are derived from it,
    /// never written as separate constants that could drift apart.
    /// </summary>
    public _0x92b1008d _0x963f25a0(Transform _0x7be7c115, _0xaed87db8 _0xd311f40b, Vector2 _0xcb21286d, Vector2 _0xb744410a, float _0x3e99c161)
    {
        float _0xa0e6818f = _0x3e99c161 / Columns;
        float _0xf1c1c279 = _0xa0e6818f - 46f;
        this._0xb02a2f70 = _0x253833cf.Node(_0x7be7c115, _0xf42cb332._0xa628defc(new byte[4] { 60, 24, 12, 20 }, 109), _0xcb21286d, _0xb744410a, new Vector2(_0x3e99c161, _0x3e99c161));
        // 1 - the stone quay ring, 2 - the water it encloses, 3.. - the plates. The frame
        // is created BEFORE the content it frames, so it can never cover it (C.13 / C.63).
        _0x253833cf.Plate(this._0xb02a2f70, _0xf42cb332._0xa628defc(new byte[9] { 220, 248, 236, 244, 203, 255, 236, 224, 232 }, 141), _0x253833cf.Middle, Vector2.zero, new Vector2(_0x3e99c161 + 104f, _0x3e99c161 + 104f), _0x857790a9.Tint(_0x857790a9.Slate, 0.95f), _0xd311f40b._0x0f6a08a7, 0.22f);
        _0x253833cf.Plate(this._0xb02a2f70, _0xf42cb332._0xa628defc(new byte[7] { 198, 226, 246, 238, 219, 254, 231 }, 151), _0x253833cf.Middle, Vector2.zero, new Vector2(_0x3e99c161 + 72f, _0x3e99c161 + 72f), _0x857790a9.Tint(_0x857790a9.Abyss, 0.9f), _0xd311f40b._0x0f6a08a7, 0.24f);
        _0x253833cf.Plate(this._0xb02a2f70, _0xf42cb332._0xa628defc(new byte[5] { 208, 230, 243, 226, 245 }, 135), _0x253833cf.Middle, Vector2.zero, new Vector2(_0x3e99c161 + 48f, _0x3e99c161 + 48f), _0x857790a9.Tint(_0x857790a9.TealDeep, 0.85f), _0xd311f40b._0x0f6a08a7, 0.26f);
        _0x253833cf.Plate(this._0xb02a2f70, _0xf42cb332._0xa628defc(new byte[10] { 120, 78, 91, 74, 93, 124, 71, 74, 74, 65 }, 47), _0x253833cf.Middle, new Vector2(0f, _0x3e99c161 * 0.2f), new Vector2(_0x3e99c161 - 40f, _0x3e99c161 * 0.42f), _0x857790a9.Tint(_0x857790a9.Teal, 0.4f), _0xd311f40b._0x0f6a08a7, 0.3f);
        for (int _0xd96f77b6 = 0; _0xd96f77b6 < _0x99c12d2e.BerthCount; _0xd96f77b6++)
        {
            int _0xe07c4085 = _0xd96f77b6 % Columns;
            int _0xdb0b4af3 = _0xd96f77b6 / Columns;
            Vector2 _0x9ddcd87a = new Vector2((_0xe07c4085 - 1) * _0xa0e6818f, (1 - _0xdb0b4af3) * _0xa0e6818f);
            this._0x4c369d9e[_0xd96f77b6] = this._0xfa5e513e(this._0xb02a2f70, _0xd311f40b, _0x9ddcd87a, _0xf1c1c279);
        }

        // The lighthouse beam sweeps over the quay; it is the LAST sibling on purpose,
        // because it is a low-alpha highlight and belongs on top (C.13).
        this._0xc3ebf5aa = _0x253833cf.Plate(this._0xb02a2f70, _0xf42cb332._0xa628defc(new byte[4] { 116, 83, 87, 91 }, 54), _0x253833cf.Middle, Vector2.zero, new Vector2(_0x3e99c161 * 0.94f, _0x3e99c161 * 0.3f), _0x857790a9.Tint(_0x857790a9.Lantern, 0.08f), _0xd311f40b._0x0f6a08a7, 0.2f);
        return this;
    }

    private _0x0a86433d _0xfa5e513e(Transform _0xf0213558, _0xaed87db8 _0x21ebc5dd, Vector2 _0x3cf3282f, float _0x36635596)
    {
        RectTransform _0x1c6d18ae = _0x253833cf.Node(_0xf0213558, _0xf42cb332._0xa628defc(new byte[5] { 242, 213, 194, 196, 216 }, 176), _0x253833cf.Middle, _0x3cf3282f, new Vector2(_0x36635596, _0x36635596));
        Button _0x30365683 = _0x253833cf.Touchable(_0x1c6d18ae, _0x21ebc5dd._0x0f6a08a7);
        Image _0x5143ba51 = _0x253833cf.Plate(_0x1c6d18ae, _0xf42cb332._0xa628defc(new byte[4] { 41, 18, 21, 28 }, 123), _0x253833cf.Middle, Vector2.zero, new Vector2(_0x36635596 + 22f, _0x36635596 + 22f), _0x857790a9.Tint(_0x857790a9.Teal, 0.95f), _0x21ebc5dd._0x0f6a08a7, 0.45f);
        _0x5143ba51.enabled = false;
        Image _0x8e878bc7 = _0x253833cf.Picture(_0x1c6d18ae, _0xf42cb332._0xa628defc(new byte[5] { 197, 249, 244, 225, 240 }, 149), _0x253833cf.Middle, Vector2.zero, _0x36635596, _0x21ebc5dd._0x34fba6fe, _0x857790a9.Tint(_0x857790a9.Foam, 0.96f));
        float _0x10399a65 = _0x36635596 * 0.22f;
        Image _0xcc9bd536 = _0x253833cf.Picture(_0x1c6d18ae, _0xf42cb332._0xa628defc(new byte[7] { 98, 79, 64, 90, 75, 92, 64 }, 46), _0x253833cf.Middle, new Vector2(0f, _0x36635596 * 0.34f), _0x10399a65, _0x21ebc5dd._0x3a3815eb, _0x857790a9.Tint(_0x857790a9.Mist, 0.85f));
        Image _0x7e8db051 = _0x253833cf.Picture(_0x1c6d18ae, _0xf42cb332._0xa628defc(new byte[5] { 108, 93, 74, 92, 91 }, 47), _0x253833cf.Middle, new Vector2(0f, -_0x36635596 * 0.06f), _0x36635596 * 0.36f, null, _0x857790a9.Foam);
        _0x7e8db051.enabled = false;
        Image _0x0f0e9cd2 = _0x253833cf.Picture(_0x1c6d18ae, _0xf42cb332._0xa628defc(new byte[4] { 171, 129, 140, 138 }, 237), _0x253833cf.Middle, new Vector2(0f, -_0x36635596 * 0.04f), _0x36635596 * 0.39f, null, _0x857790a9.Foam);
        _0x0f0e9cd2.enabled = false;
        return new _0x0a86433d()._0x5407f921(_0x1c6d18ae, _0x8e878bc7, _0xcc9bd536, _0x5143ba51, _0x7e8db051, _0x0f0e9cd2, _0x30365683, _0x857790a9.Tint(_0x857790a9.Mist, 0.85f));
    }

    public void _0xce37e2ff()
    {
        for (int _0xae3909bb = 0; _0xae3909bb < this._0x4c369d9e.Length; _0xae3909bb++)
        {
            if (this._0x4c369d9e[_0xae3909bb] != null)
            {
                this._0x4c369d9e[_0xae3909bb]._0x5eb7a3ea(null);
            }
        }
    }

    private readonly _0x0a86433d[] _0x4c369d9e = new _0x0a86433d[_0x99c12d2e.BerthCount];
    public const int Columns = 3;
    public _0x0a86433d[] _0xb15a11e0 => this._0x4c369d9e;

    private Image _0xc3ebf5aa;
}

internal static class _0xf42cb332
{
    internal static string _0xa628defc(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}