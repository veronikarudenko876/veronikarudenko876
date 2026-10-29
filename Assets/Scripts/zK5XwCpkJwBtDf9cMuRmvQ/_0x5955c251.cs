using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The crew list, and the single ready-made reaction the brief allows: SALUTE. There is no
/// text field and no message list anywhere in this view - the app has no free chat.
///
/// Each row holds THREE x bands that never overlap (C.25):
///   avatar gutter [-490,-370]   handle / flags text [-304,+256]   SALUTE [+335,+525]
/// </summary>
public sealed class _0x5955c251
{
    private readonly TextMeshProUGUI[] _0x7c228785 = new TextMeshProUGUI[4];
    private const float RowPitch = 190f;
    private static readonly string[] _0x912419d6 =
    {
        _0x31c1d37d._0xa69e38e4(new byte[11] { 123, 117, 117, 96, 117, 98, 16, 125, 113, 98, 113 }, 48),
        _0x31c1d37d._0xa69e38e4(new byte[11] { 106, 97, 109, 101, 14, 121, 111, 124, 106, 107, 96 }, 46),
        _0x31c1d37d._0xa69e38e4(new byte[9] { 48, 41, 37, 50, 64, 33, 46, 46, 33 }, 96),
        _0x31c1d37d._0xa69e38e4(new byte[10] { 95, 94, 67, 69, 89, 49, 93, 80, 92, 65 }, 17)
    };
    private const float RowWidth = 1060f;
    private static readonly int[] _0xcae7526b =
    {
        3,
        5,
        2,
        4
    };
    private void _0x6b707f2b(Transform _0x57877f48, _0xaed87db8 _0xbb758f6a, int _0x8e5f1d2e, float _0x6846155c)
    {
        RectTransform _0xd4868e2b = _0x253833cf.Node(_0x57877f48, _0x31c1d37d._0xa69e38e4(new byte[7] { 146, 163, 180, 166, 131, 190, 166 }, 209), _0x253833cf.TopCentre, new Vector2(0f, -_0x6846155c), new Vector2(RowWidth, RowHeight));
        _0x253833cf.Plate(_0xd4868e2b, _0x31c1d37d._0xa69e38e4(new byte[7] { 249, 196, 220, 233, 196, 207, 210 }, 171), _0x253833cf.Middle, Vector2.zero, new Vector2(RowWidth, RowHeight), _0x857790a9.Tint(_0x857790a9.Abyss, 0.78f), _0xbb758f6a._0x0f6a08a7, 0.38f);
        _0x253833cf.Plate(_0xd4868e2b, _0x31c1d37d._0xa69e38e4(new byte[7] { 3, 62, 38, 20, 53, 54, 52 }, 81), _0x253833cf.Middle, new Vector2(-520f, 0f), new Vector2(6f, RowHeight - 40f), _0x857790a9.Tint(_0x857790a9.Teal, 0.6f), _0xbb758f6a._0x0f6a08a7, 1.4f);
        // Indicator gutter: the avatar and its rank pip, alone in their own column.
        _0x253833cf.Plate(_0xd4868e2b, _0x31c1d37d._0xa69e38e4(new byte[10] { 73, 126, 105, 124, 105, 122, 90, 97, 102, 111 }, 8), _0x253833cf.Middle, new Vector2(-430f, 0f), new Vector2(128f, 128f), _0x857790a9.Tint(_0x857790a9.Teal, 0.85f), _0xbb758f6a._0x0f6a08a7, 0.16f);
        _0x253833cf.Picture(_0xd4868e2b, _0x31c1d37d._0xa69e38e4(new byte[6] { 215, 224, 247, 226, 247, 228 }, 150), _0x253833cf.Middle, new Vector2(-430f, 0f), 112f, _0xbb758f6a._0x00afe793, _0x857790a9.Foam);
        this._0x30b81afb[_0x8e5f1d2e] = _0x253833cf.Plate(_0xd4868e2b, _0x31c1d37d._0xa69e38e4(new byte[7] { 215, 228, 235, 238, 213, 236, 245 }, 133), _0x253833cf.Middle, new Vector2(-385f, -44f), new Vector2(34f, 34f), _0x857790a9.Lantern, _0xbb758f6a._0x0f6a08a7, 0.16f);
        // Text column: left edge -304, i.e. 66 units clear of the gutter.
        _0x253833cf.Caption(_0xd4868e2b, _0x31c1d37d._0xa69e38e4(new byte[6] { 219, 242, 253, 247, 255, 246 }, 147), _0x253833cf.Middle, new Vector2(-24f, 28f), new Vector2(560f, 48f), _0x912419d6[_0x8e5f1d2e], 38f, _0x857790a9.Foam, _0xbb758f6a._0xed34cdf9, TextAlignmentOptions.Left);
        this._0x7c228785[_0x8e5f1d2e] = _0x253833cf.Caption(_0xd4868e2b, _0x31c1d37d._0xa69e38e4(new byte[8] { 207, 242, 234, 219, 241, 252, 250, 238 }, 157), _0x253833cf.Middle, new Vector2(-24f, -28f), new Vector2(560f, 40f), _0x31c1d37d._0xa69e38e4(new byte[6] { 47, 37, 40, 46, 58, 73 }, 105) + _0xcae7526b[_0x8e5f1d2e].ToString(), 30f, _0x857790a9.Mist, _0xbb758f6a._0xed34cdf9, TextAlignmentOptions.Left);
        // Action column: left edge +335, 79 units clear of the text.
        RectTransform _0x7f7e6680 = _0x253833cf.Node(_0xd4868e2b, _0x31c1d37d._0xa69e38e4(new byte[6] { 4, 54, 59, 34, 35, 50 }, 87), _0x253833cf.Middle, new Vector2(430f, 0f), new Vector2(190f, 96f));
        Button _0xd7244c40 = _0x253833cf.Touchable(_0x7f7e6680, _0xbb758f6a._0x0f6a08a7);
        Image _0xd4a84700 = _0x7f7e6680.gameObject.GetComponent<Image>();
        if (_0xd4a84700 != null)
        {
            _0xd4a84700.color = _0x857790a9.Teal;
            _0xd4a84700.pixelsPerUnitMultiplier = 0.4f;
        }

        this._0xdf1a6e86[_0x8e5f1d2e] = _0x253833cf.Caption(_0x7f7e6680, _0x31c1d37d._0xa69e38e4(new byte[11] { 160, 146, 159, 134, 135, 150, 191, 146, 145, 150, 159 }, 243), _0x253833cf.Middle, Vector2.zero, new Vector2(170f, 56f), _0x31c1d37d._0xa69e38e4(new byte[6] { 222, 204, 193, 216, 217, 200 }, 141), 30f, _0x857790a9.Foam, _0xbb758f6a._0xed34cdf9, TextAlignmentOptions.Center);
        this._0xe895d913[_0x8e5f1d2e] = _0xd7244c40;
        int _0x041e1ab4 = _0x8e5f1d2e;
        _0xd7244c40.onClick.AddListener(() => this._0x431b1f1a(_0x041e1ab4));
    }

    private readonly Button[] _0xe895d913 = new Button[4];
    public _0x5955c251 _0xee4f2380(Transform _0x693c74e7, _0xaed87db8 _0x7d507fb2, float _0x165336bf)
    {
        // Any list that can come up empty shows a themed line instead of a blank area.
        if (_0x912419d6.Length == 0)
        {
            _0x253833cf.Caption(_0x693c74e7, _0x31c1d37d._0xa69e38e4(new byte[9] { 103, 86, 65, 83, 97, 73, 84, 80, 93 }, 36), _0x253833cf.TopCentre, new Vector2(0f, -(_0x165336bf + 200f)), new Vector2(900f, 60f), _0x31c1d37d._0xa69e38e4(new byte[20] { 213, 212, 187, 216, 201, 222, 204, 187, 212, 213, 187, 204, 218, 207, 216, 211, 187, 194, 222, 207 }, 155), 34f, _0x857790a9.Mist, _0x7d507fb2._0xed34cdf9, TextAlignmentOptions.Center);
            return this;
        }

        for (int _0x01e8f316 = 0; _0x01e8f316 < _0x912419d6.Length; _0x01e8f316++)
        {
            this._0x6b707f2b(_0x693c74e7, _0x7d507fb2, _0x01e8f316, _0x165336bf + (_0x01e8f316 * RowPitch));
        }

        return this;
    }

    private readonly TextMeshProUGUI[] _0xdf1a6e86 = new TextMeshProUGUI[4];
    private readonly Image[] _0x30b81afb = new Image[4];
    private readonly bool[] _0x4a07365c = new bool[4];
    public void _0xc1eb2f6d()
    {
        for (int _0xdd9fb101 = 0; _0xdd9fb101 < this._0x30b81afb.Length; _0xdd9fb101++)
        {
            if (this._0x30b81afb[_0xdd9fb101] != null)
            {
                DOTween.Kill(this._0x30b81afb[_0xdd9fb101].transform);
            }

            if (this._0xe895d913[_0xdd9fb101] != null)
            {
                DOTween.Kill(this._0xe895d913[_0xdd9fb101].transform);
            }
        }
    }

    /// <summary>
    /// One tap, three visible confirmations (C.7): the rank pip punches, the row's flag line
    /// gains a +1 SALUTE suffix, and the button itself locks into its SALUTED state. A
    /// caption change on its own would not be enough.
    /// </summary>
    private void _0x431b1f1a(int _0x9e24cb2b)
    {
        if (_0x9e24cb2b < 0 || _0x9e24cb2b >= this._0x4a07365c.Length || this._0x4a07365c[_0x9e24cb2b])
        {
            return;
        }

        this._0x4a07365c[_0x9e24cb2b] = true;
        Image _0xa12ec40a = this._0x30b81afb[_0x9e24cb2b];
        if (_0xa12ec40a != null)
        {
            _0xa12ec40a.color = _0x857790a9.Lantern;
            _0xa12ec40a.transform.DOPunchScale(Vector3.one * 0.3f, 0.35f, 8, 0.6f).SetLink(_0xa12ec40a.gameObject);
        }

        TextMeshProUGUI _0x806bd49d = this._0x7c228785[_0x9e24cb2b];
        if (_0x806bd49d != null)
        {
            _0x806bd49d.text = _0x31c1d37d._0xa69e38e4(new byte[6] { 241, 251, 246, 240, 228, 151 }, 183) + _0xcae7526b[_0x9e24cb2b].ToString() + _0x31c1d37d._0xa69e38e4(new byte[11] { 136, 136, 131, 153, 136, 251, 233, 228, 253, 252, 237 }, 168);
            _0x806bd49d.color = _0x857790a9.Lantern;
        }

        Button _0x579a5288 = this._0xe895d913[_0x9e24cb2b];
        if (_0x579a5288 != null)
        {
            _0x579a5288.interactable = false;
            Image _0xe981d5df = _0x579a5288.gameObject.GetComponent<Image>();
            if (_0xe981d5df != null)
            {
                _0xe981d5df.color = _0x857790a9.TealDeep;
            }

            _0x579a5288.transform.DOScale(0.95f, 0.09f).SetLoops(2, LoopType.Yoyo).SetEase(Ease.OutQuad).SetLink(_0x579a5288.gameObject);
        }

        TextMeshProUGUI _0xcfe9282a = this._0xdf1a6e86[_0x9e24cb2b];
        if (_0xcfe9282a != null)
        {
            _0xcfe9282a.text = _0x31c1d37d._0xa69e38e4(new byte[7] { 170, 184, 181, 172, 173, 188, 189 }, 249);
        }
    }

    private const float RowHeight = 180f;
}

internal static class _0x31c1d37d
{
    internal static string _0xa69e38e4(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}