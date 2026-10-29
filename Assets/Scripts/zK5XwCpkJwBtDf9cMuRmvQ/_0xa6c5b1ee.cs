using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The bar across the top of the quay: BACK, the pennant tally, the tide meter and PAUSE.
///
/// These are codegen's OWN objects. The template HUD (TopPanel, LEFT_BUTTON, RIGHT_BUTTON,
/// TimerContainer, ScoreText, MoneyContainer) is switched off at run time and nothing here
/// is wired onto it - rule H option 2, which is the only one that survives stage 5da.
///
/// x bands, so nothing shares a column (C.25):
///   BACK  [-556,-444]   pennant [-338,-282]   FLAGS [-245,-55]
///   TIDE  [ +40, +340]  PAUSE   [+444,+556]
/// </summary>
public sealed class _0xa6c5b1ee
{
    private Button _0xed92b23b;
    /// <summary>Glide the tide bar to its true value so the meter reads as a tide, not a jump.</summary>
    public void _0x53086e3d(float _0x1ce8de40)
    {
        if (this._0x5195680d == null)
        {
            return;
        }

        RectTransform _0x7212359c = this._0x5195680d.rectTransform;
        float _0x8887f3ee = Mathf.Clamp01(_0x1ce8de40) * this._0xa26e31ba;
        _0x7212359c.DOSizeDelta(new Vector2(_0x8887f3ee, _0x7212359c.sizeDelta.y), 0.25f).SetEase(Ease.OutQuad).SetLink(_0x7212359c.gameObject);
        this._0x5195680d.color = Color.Lerp(_0x857790a9.Lantern, _0x857790a9.Teal, Mathf.Clamp01(_0x1ce8de40));
    }

    public void _0xb2f5aa49()
    {
        if (this._0x5195680d != null)
        {
            DOTween.Kill(this._0x5195680d.rectTransform);
        }
    }

    private const float BarHeight = 250f;
    /// <summary>A visible press, so a tap is confirmed on a screenshot (C.7).</summary>
    public void _0x7faf7244(Button _0x4b939bf6)
    {
        if (_0x4b939bf6 != null)
        {
            _0x4b939bf6.transform.DOScale(0.94f, 0.09f).SetLoops(2, LoopType.Yoyo).SetEase(Ease.OutQuad).SetLink(_0x4b939bf6.gameObject);
        }
    }

    public void _0x50359e10(int _0x8e015e94, int _0xa69cd23e)
    {
        if (this._0x0a2346ca != null)
        {
            this._0x0a2346ca.text = _0x3f9df512._0x157ae2a9(new byte[6] { 231, 237, 224, 230, 242, 129 }, 161) + _0x8e015e94.ToString() + _0x3f9df512._0x157ae2a9(new byte[3] { 5, 10, 5 }, 37) + _0xa69cd23e.ToString();
        }
    }

    public Button _0x38603c26 => this._0x5bd77109;

    public _0xa6c5b1ee _0xd28e815e(Transform _0x1ab11c44, _0xaed87db8 _0x1b3ddb7f)
    {
        RectTransform _0x1b70ecfa = _0x253833cf.Node(_0x1ab11c44, _0x3f9df512._0x157ae2a9(new byte[8] { 158, 168, 189, 170, 161, 129, 188, 173 }, 201), _0x253833cf.TopCentre, new Vector2(0f, -BarHeight * 0.5f), new Vector2(1242f, BarHeight));
        _0x253833cf.Wash(_0x1b70ecfa, _0x3f9df512._0x157ae2a9(new byte[7] { 80, 109, 124, 94, 113, 116, 116 }, 24), _0x857790a9.Tint(_0x857790a9.Abyss, 0.88f));
        _0x253833cf.Plate(_0x1b70ecfa, _0x3f9df512._0x157ae2a9(new byte[7] { 3, 62, 47, 14, 47, 44, 46 }, 75), _0x253833cf.BottomCentre, new Vector2(0f, 1f), new Vector2(1242f, 3f), _0x857790a9.Tint(_0x857790a9.Teal, 0.35f), _0x1b3ddb7f._0x0f6a08a7, 1.6f);
        this._0x5bd77109 = this._0x84341c88(_0x1b70ecfa, _0x3f9df512._0x157ae2a9(new byte[10] { 40, 11, 9, 1, 40, 31, 30, 30, 5, 4 }, 106), -500f, _0x1b3ddb7f._0x93cf757b, _0x1b3ddb7f);
        this._0xed92b23b = this._0x84341c88(_0x1b70ecfa, _0x3f9df512._0x157ae2a9(new byte[11] { 249, 200, 220, 218, 204, 235, 220, 221, 221, 198, 199 }, 169), 500f, _0x1b3ddb7f._0x37d7a6c8, _0x1b3ddb7f);
        _0x253833cf.Picture(_0x1b70ecfa, _0x3f9df512._0x157ae2a9(new byte[9] { 215, 226, 239, 239, 250, 202, 224, 236, 237 }, 131), _0x253833cf.TopCentre, new Vector2(-310f, -RowY), 56f, _0x1b3ddb7f._0x32988354, _0x857790a9.Lantern);
        this._0x0a2346ca = _0x253833cf.Caption(_0x1b70ecfa, _0x3f9df512._0x157ae2a9(new byte[9] { 177, 132, 137, 137, 156, 177, 128, 157, 145 }, 229), _0x253833cf.TopCentre, new Vector2(-150f, -RowY), new Vector2(190f, 56f), _0x3f9df512._0x157ae2a9(new byte[11] { 228, 238, 227, 229, 241, 130, 146, 130, 141, 130, 145 }, 162), 40f, _0x857790a9.Lantern, _0x1b3ddb7f._0xed34cdf9, TextAlignmentOptions.Left);
        // The TIDE label sits ABOVE its bar, so the two never fight for the same x band.
        TextMeshProUGUI _0xb21d2b33 = _0x253833cf.Caption(_0x1b70ecfa, _0x3f9df512._0x157ae2a9(new byte[9] { 28, 33, 44, 45, 4, 41, 42, 45, 36 }, 72), _0x253833cf.TopCentre, new Vector2(190f, -140f), new Vector2(300f, 36f), _0x3f9df512._0x157ae2a9(new byte[4] { 240, 237, 224, 225 }, 164), 28f, _0x857790a9.Mist, _0x1b3ddb7f._0xed34cdf9, TextAlignmentOptions.Center);
        _0xb21d2b33.characterSpacing = 8f;
        this._0xa26e31ba = 300f;
        this._0x5195680d = _0x253833cf.Bar(_0x1b70ecfa, _0x3f9df512._0x157ae2a9(new byte[4] { 245, 200, 197, 196 }, 161), _0x253833cf.TopCentre, new Vector2(190f, -190f), new Vector2(this._0xa26e31ba, 22f), _0x857790a9.Tint(_0x857790a9.Ink, 0.7f), _0x857790a9.Teal, _0x1b3ddb7f._0x0f6a08a7);
        return this;
    }

    private Button _0x84341c88(Transform _0xb1da898e, string _0x43664d9f, float _0x5bf95fcf, Sprite _0x19f31e8f, _0xaed87db8 _0xe8f67dcc)
    {
        RectTransform _0x3e49f793 = _0x253833cf.Node(_0xb1da898e, _0x43664d9f, _0x253833cf.TopCentre, new Vector2(_0x5bf95fcf, -RowY), new Vector2(112f, 112f));
        Button _0x4d8069e5 = _0x253833cf.Touchable(_0x3e49f793, _0xe8f67dcc._0x0f6a08a7);
        Image _0xf8283f51 = _0x3e49f793.gameObject.GetComponent<Image>();
        if (_0xf8283f51 != null)
        {
            _0xf8283f51.color = _0x857790a9.Tint(_0x857790a9.Slate, 0.45f);
            _0xf8283f51.pixelsPerUnitMultiplier = 0.42f;
        }

        _0x253833cf.Picture(_0x3e49f793, _0x3f9df512._0x157ae2a9(new byte[5] { 185, 146, 135, 142, 150 }, 254), _0x253833cf.Middle, Vector2.zero, 58f, _0x19f31e8f, _0x857790a9.Mist);
        return _0x4d8069e5;
    }

    private float _0xa26e31ba = 300f;
    private TextMeshProUGUI _0x0a2346ca;
    private const float RowY = 175f;
    private Button _0x5bd77109;
    public Button _0x6ca53d89 => this._0xed92b23b;

    private Image _0x5195680d;
}

internal static class _0x3f9df512
{
    internal static string _0x157ae2a9(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}