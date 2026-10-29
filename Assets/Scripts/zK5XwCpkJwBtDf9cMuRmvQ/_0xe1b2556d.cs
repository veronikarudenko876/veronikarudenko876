using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The menu scene: the loader's mark, the HOME screen and THE CREW screen, swapped by
/// CanvasGroup rather than by inventing panel indices the template does not guarantee.
///
/// The screens are built into the template's own DefaultPanel/Content, reached by INDEX
/// (SETTINGS.PANELS.DEFAULT), and they go in as TWO hosts: a backdrop that must draw UNDER
/// the template's PLAY button, and a front host for everything that must draw over it.
/// The PLAY button itself is the template's instance - it is resized in the scene file per
/// rule G.3 and given a face here, never duplicated.
///
/// Set-up lives in Start, never Awake: the template's controllers claim their singletons in
/// Awake and a generated Awake would race them (C.59).
/// </summary>
public sealed class _0xe1b2556d : MonoBehaviour
{
    private const float PanelWidth = 1242f;
    private _0x239c595c _0x361f27c0;
    private _0xa6e3970b _0x5a941397(int _0x2bb909b1)
    {
        if (_0xd705b3c4.Instance == null || _0xd705b3c4.Instance.Panels == null)
        {
            return null;
        }

        if (_0x2bb909b1 < 0 || _0x2bb909b1 >= _0xd705b3c4.Instance.Panels.Count)
        {
            return null;
        }

        return _0xd705b3c4.Instance.Panels[_0x2bb909b1];
    }

    // -- THE CREW ----------------------------------------------------------------
    private void _0xc803c07c(Transform _0xe55e0530)
    {
        RectTransform _0x7ac4b737 = this._0xa17daa46(_0xe55e0530, 620f, 200f, _0x8a1da21f._0x453d7280(new byte[10] { 79, 126, 105, 123, 68, 105, 109, 104, 105, 126 }, 12));
        _0x253833cf.Caption(_0x7ac4b737, _0x8a1da21f._0x453d7280(new byte[9] { 139, 186, 173, 191, 156, 161, 188, 164, 173 }, 200), _0x253833cf.Middle, new Vector2(0f, 34f), new Vector2(900f, 62f), _0x8a1da21f._0x453d7280(new byte[8] { 154, 134, 139, 238, 141, 156, 139, 153 }, 206), 48f, _0x857790a9.Foam, this._art._0xed34cdf9, TextAlignmentOptions.Center);
        TextMeshProUGUI _0xe84ead3d = _0x253833cf.Caption(_0x7ac4b737, _0x8a1da21f._0x453d7280(new byte[7] { 65, 112, 103, 117, 81, 119, 96 }, 2), _0x253833cf.Middle, new Vector2(0f, -34f), new Vector2(900f, 44f), _0x8a1da21f._0x453d7280(new byte[15] { 250, 225, 232, 251, 236, 237, 137, 249, 251, 230, 238, 251, 236, 250, 250 }, 169), 32f, _0x857790a9.Mist, this._art._0xed34cdf9, TextAlignmentOptions.Center);
        _0xe84ead3d.characterSpacing = 6f;
        this._0xdc058d2f = new _0x6e343b66()._0x92f042b6(_0xe55e0530, this._art, _0x253833cf.TopCentre, new Vector2(0f, -880f), 100f, 56f, true);
        this._0xdc058d2f._0xbdb52a90(_0x99c12d2e._0xd64e3fc3, _0x8a1da21f._0x453d7280(new byte[13] { 203, 204, 219, 221, 193, 218, 169, 207, 192, 197, 197, 204, 205 }, 137));
        this._0xfae83cd7 = new _0x5955c251()._0xee4f2380(_0xe55e0530, this._art, 1150f);
        this._0x361f27c0 = new _0x239c595c()._0xc1890956(_0xe55e0530, this._art, 1960f, this._0xdc058d2f, () => this._0xe9916b22());
    }

    private const float PanelHeight = 2688f;
    private CanvasGroup _0x6c902049;
    private TextMeshProUGUI _0x3fef0186;
    private void _0xdb6095da(CanvasGroup _0xa557cb9b, bool _0x55d21b65)
    {
        if (_0xa557cb9b == null)
        {
            return;
        }

        _0xa557cb9b.alpha = _0x55d21b65 ? 1f : 0f;
        _0xa557cb9b.interactable = _0x55d21b65;
        _0xa557cb9b.blocksRaycasts = _0x55d21b65;
        if (!_0x55d21b65)
        {
            return;
        }

        RectTransform _0x995b2fea = _0xa557cb9b.GetComponent<RectTransform>();
        if (_0x995b2fea != null)
        {
            _0x995b2fea.anchoredPosition = new Vector2(0f, -24f);
            _0x995b2fea.DOAnchorPos(Vector2.zero, 0.18f).SetEase(Ease.OutCubic).SetLink(_0x995b2fea.gameObject);
        }
    }

    /// <summary>
    /// The menu backdrop: the generated BG_main texture SEEN THROUGH a scrim, with this
    /// game's own dusk harbour drawn on top of it - a lantern-lit horizon, the water below
    /// it, and the lighthouse standing on the far quay. It is also what fills the band under
    /// the CTA, so the lower third of the menu is a view and not an empty slab.
    ///
    /// The scrim is a SCRIM, not a cover. The menu background is a generated image (when
    /// Codex draws only one background the import reuses it for BG_main), and washing it out
    /// at alpha 0.96 - which is what this did while the art contract was believed to have no
    /// bg_main - threw away every pixel of it and left the frame darker than the design
    /// intends. 0.62 keeps the text contrast and the dusk mood while the texture still
    /// reads. It also stays clear of the splash's own scrim so the two screens cannot hash
    /// alike (rule 14): splash is 0.82 over a lone centred mark, this is 0.62 under a full
    /// composition of cards, ribbon and CTA.
    /// </summary>
    private void _0xc28258a1(Transform _0x1d0cffa0)
    {
        RectTransform _0xb5d314cf = _0x253833cf.Stretch(_0x1d0cffa0, _0x8a1da21f._0x453d7280(new byte[8] { 90, 114, 121, 98, 85, 118, 116, 124 }, 23));
        _0xb5d314cf.SetAsFirstSibling();
        _0x253833cf.Wash(_0xb5d314cf, _0x8a1da21f._0x453d7280(new byte[3] { 141, 181, 167 }, 222), _0x857790a9.Tint(_0x857790a9.Ink, 0.62f));
        _0x253833cf.Plate(_0xb5d314cf, _0x8a1da21f._0x453d7280(new byte[7] { 20, 44, 62, 0, 43, 40, 48 }, 71), _0x253833cf.TopCentre, new Vector2(0f, -240f), new Vector2(1500f, 980f), _0x857790a9.Tint(_0x857790a9.Slate, 0.3f), this._art._0x0f6a08a7, 0.08f);
        _0x253833cf.Plate(_0xb5d314cf, _0x8a1da21f._0x453d7280(new byte[8] { 198, 228, 247, 225, 194, 233, 234, 242 }, 133), _0x253833cf.TopCentre, new Vector2(0f, -760f), new Vector2(1000f, 700f), _0x857790a9.Tint(_0x857790a9.Teal, 0.1f), this._art._0x0f6a08a7, 0.1f);
        // Everything below the horizon is water.
        float _0x56fce336 = PanelHeight - Horizon;
        _0x253833cf.Plate(_0xb5d314cf, _0x8a1da21f._0x453d7280(new byte[3] { 112, 70, 66 }, 35), _0x253833cf.TopCentre, new Vector2(0f, -(Horizon + (_0x56fce336 * 0.5f))), new Vector2(PanelWidth, _0x56fce336), _0x857790a9.Tint(_0x857790a9.TealDeep, 0.78f), this._art._0x0f6a08a7, 0.1f);
        _0x253833cf.Plate(_0xb5d314cf, _0x8a1da21f._0x453d7280(new byte[8] { 77, 123, 127, 77, 118, 123, 123, 112 }, 30), _0x253833cf.TopCentre, new Vector2(0f, -(Horizon + 170f)), new Vector2(1100f, 240f), _0x857790a9.Tint(_0x857790a9.Teal, 0.22f), this._art._0x0f6a08a7, 0.16f);
        _0x253833cf.Plate(_0xb5d314cf, _0x8a1da21f._0x453d7280(new byte[7] { 180, 147, 142, 149, 134, 147, 146 }, 252), _0x253833cf.TopCentre, new Vector2(0f, -Horizon), new Vector2(PanelWidth, 5f), _0x857790a9.Tint(_0x857790a9.Lantern, 0.45f), this._art._0x0f6a08a7, 1.6f);
        // The lighthouse stands ON the horizon, in its own column 65 units clear of the
        // hint and footnote text (C.25).
        _0x253833cf.Plate(_0xb5d314cf, _0x8a1da21f._0x453d7280(new byte[10] { 87, 112, 116, 118, 122, 123, 82, 121, 122, 98 }, 21), _0x253833cf.TopCentre, new Vector2(420f, -2050f), new Vector2(170f, 170f), _0x857790a9.Tint(_0x857790a9.Lantern, 0.26f), this._art._0x0f6a08a7, 0.1f);
        Image _0x137654e7 = _0x253833cf.Picture(_0xb5d314cf, _0x8a1da21f._0x453d7280(new byte[13] { 213, 242, 225, 223, 250, 244, 251, 231, 251, 252, 230, 224, 246 }, 147), _0x253833cf.TopCentre, new Vector2(420f, -2135f), 230f, this._art._0x8aad929c, _0x857790a9.Tint(_0x857790a9.Harbour, 0.92f));
        _0x137654e7.DOFade(0.72f, 3.4f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(_0x137654e7.gameObject);
        this._0xd2e2d48f = _0x137654e7;
    }

    // -- PLAY --------------------------------------------------------------------
    //
    // The template's EMPTY_BASE_BUTTON renders nothing: every BASE_PANEL layer under it is
    // switched off and the one survivor, Fade, is multiplied to transparent by the Button's
    // normal colour. It IS pressable though (Fade keeps raycastTarget 1 with negative
    // padding), so the face below is drawn with raycastTarget off and the tap falls through
    // to the driver that already carries LoadSceneId 1.
    private void _0xf4ce6e61()
    {
        if (this._playSlot == null)
        {
            return;
        }

        Vector2 _0xf8e3aea7 = new Vector2(760f, 168f);
        _0x253833cf.Plate(this._playSlot, _0x8a1da21f._0x453d7280(new byte[10] { 183, 139, 134, 158, 180, 143, 134, 131, 136, 144 }, 231), _0x253833cf.Middle, new Vector2(0f, -12f), _0xf8e3aea7, _0x857790a9.Tint(_0x857790a9.Ink, 0.45f), this._art._0x0f6a08a7, 0.3f);
        _0x253833cf.Plate(this._playSlot, _0x8a1da21f._0x453d7280(new byte[8] { 52, 8, 5, 29, 54, 13, 10, 3 }, 100), _0x253833cf.Middle, Vector2.zero, new Vector2(_0xf8e3aea7.x + 8f, _0xf8e3aea7.y + 8f), _0x857790a9.Tint(_0x857790a9.Lantern, 0.5f), this._art._0x0f6a08a7, 0.3f);
        _0x253833cf.Plate(this._playSlot, _0x8a1da21f._0x453d7280(new byte[8] { 251, 199, 202, 210, 233, 196, 207, 210 }, 171), _0x253833cf.Middle, Vector2.zero, _0xf8e3aea7, _0x857790a9.Teal, this._art._0x0f6a08a7, 0.3f);
        _0x253833cf.Plate(this._playSlot, _0x8a1da21f._0x453d7280(new byte[8] { 247, 203, 198, 222, 224, 213, 198, 195 }, 167), _0x253833cf.Middle, new Vector2(0f, -40f), new Vector2(_0xf8e3aea7.x - 10f, 84f), _0x857790a9.Tint(_0x857790a9.TealDeep, 0.85f), this._art._0x0f6a08a7, 0.34f);
        TextMeshProUGUI _0xf127f909 = _0x253833cf.Caption(this._playSlot, _0x8a1da21f._0x453d7280(new byte[9] { 89, 101, 104, 112, 69, 104, 107, 108, 101 }, 9), _0x253833cf.Middle, Vector2.zero, new Vector2(700f, 96f), _0x8a1da21f._0x453d7280(new byte[11] { 28, 27, 14, 29, 27, 111, 24, 14, 27, 12, 7 }, 79), 58f, _0x857790a9.Foam, this._art._0xed34cdf9, TextAlignmentOptions.Center);
        _0xf127f909.characterSpacing = 6f;
    }

    private void Start()
    {
        if (this._art == null || _0xd705b3c4.Instance == null)
        {
            return;
        }

        this._0x036827e8();
        _0xa6e3970b _0x1ae9d4c8 = this._0x5a941397(_0xd9957943._0x23baba46.DEFAULT);
        if (_0x1ae9d4c8 == null || _0x1ae9d4c8.Content == null)
        {
            return;
        }

        Transform _0x5610976f = _0x1ae9d4c8.Content.transform;
        this._0xc28258a1(_0x5610976f);
        RectTransform _0xc21e5433 = _0x253833cf.Stretch(_0x5610976f, _0x8a1da21f._0x453d7280(new byte[9] { 14, 38, 45, 54, 5, 49, 44, 45, 55 }, 67));
        _0xc21e5433.SetAsLastSibling();
        this._0x55b9eb1a(_0xc21e5433);
        this._0xa14d7d6c = _0x253833cf.Group(_0xc21e5433, _0x8a1da21f._0x453d7280(new byte[9] { 154, 189, 191, 183, 149, 160, 189, 167, 162 }, 210));
        this._0x6c902049 = _0x253833cf.Group(_0xc21e5433, _0x8a1da21f._0x453d7280(new byte[9] { 249, 200, 223, 205, 253, 200, 213, 207, 202 }, 186));
        this._0x12a8e7c5(this._0xa14d7d6c.transform);
        this._0xc803c07c(this._0x6c902049.transform);
        this._0xf4ce6e61();
        this._0x93443819(false);
        this._0x46bb909d();
        this._0x6ca8fa71();
    }

    private _0x6e343b66 _0x9d2fb8fe;
    // -- tabs --------------------------------------------------------------------
    private void _0x55b9eb1a(Transform _0xceeb823e)
    {
        this._0x293b46e2 = this._0xbb4419e3(_0xceeb823e, -282f, _0x8a1da21f._0x453d7280(new byte[7] { 245, 252, 239, 255, 242, 232, 239 }, 189), false);
        this._0xc36145f7 = this._0x293b46e2.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        this._0x7cf24079 = this._0xbb4419e3(_0xceeb823e, 282f, _0x8a1da21f._0x453d7280(new byte[8] { 95, 67, 78, 43, 72, 89, 78, 92 }, 11), true);
        this._0x3fef0186 = this._0x7cf24079.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
    }

    // -- HOME --------------------------------------------------------------------
    private void _0x12a8e7c5(Transform _0x702b6f0d)
    {
        // Profile card. x bands: avatar [-485,-335] | text [-300,+120] | pennant [+198,+262]
        // | tally [+325,+475] - every gap above the 24-unit floor of C.25.
        RectTransform _0xb028464e = this._0xa17daa46(_0x702b6f0d, 660f, 340f, _0x8a1da21f._0x453d7280(new byte[11] { 46, 12, 17, 24, 23, 18, 27, 61, 31, 12, 26 }, 126));
        _0x253833cf.Plate(_0xb028464e, _0x8a1da21f._0x453d7280(new byte[10] { 247, 192, 215, 194, 215, 196, 228, 223, 216, 209 }, 182), _0x253833cf.Middle, new Vector2(-410f, 0f), new Vector2(168f, 168f), _0x857790a9.Tint(_0x857790a9.Teal, 0.85f), this._art._0x0f6a08a7, 0.12f);
        _0x253833cf.Picture(_0xb028464e, _0x8a1da21f._0x453d7280(new byte[6] { 176, 135, 144, 133, 144, 131 }, 241), _0x253833cf.Middle, new Vector2(-410f, 0f), 150f, this._art._0x00afe793, _0x857790a9.Foam);
        _0x253833cf.Caption(_0xb028464e, _0x8a1da21f._0x453d7280(new byte[10] { 4, 42, 42, 63, 42, 61, 1, 46, 34, 42 }, 79), _0x253833cf.Middle, new Vector2(-90f, 44f), new Vector2(420f, 58f), _0x8a1da21f._0x453d7280(new byte[14] { 231, 238, 253, 237, 224, 250, 253, 143, 228, 234, 234, 255, 234, 253 }, 175), 46f, _0x857790a9.Foam, this._art._0xed34cdf9, TextAlignmentOptions.Left);
        _0x253833cf.Caption(_0xb028464e, _0x8a1da21f._0x453d7280(new byte[10] { 237, 195, 195, 214, 195, 212, 244, 199, 200, 205 }, 166), _0x253833cf.Middle, new Vector2(-90f, -26f), new Vector2(420f, 46f), _0x8a1da21f._0x453d7280(new byte[12] { 30, 8, 29, 10, 1, 105, 27, 8, 7, 2, 105, 123 }, 73), 34f, _0x857790a9.Mist, this._art._0xed34cdf9, TextAlignmentOptions.Left);
        _0x253833cf.Picture(_0xb028464e, _0x8a1da21f._0x453d7280(new byte[9] { 29, 40, 37, 37, 48, 0, 42, 38, 39 }, 73), _0x253833cf.Middle, new Vector2(230f, 0f), 64f, this._art._0x32988354, _0x857790a9.Lantern);
        _0x253833cf.Caption(_0xb028464e, _0x8a1da21f._0x453d7280(new byte[10] { 59, 14, 3, 3, 22, 44, 0, 26, 1, 27 }, 111), _0x253833cf.Middle, new Vector2(400f, 0f), new Vector2(150f, 70f), _0x99c12d2e._0x66d19138.ToString(), 52f, _0x857790a9.Lantern, this._art._0xed34cdf9, TextAlignmentOptions.Center);
        // Daily goal card. Bar band [-500,+240], counter band [+325,+475]: 85 clear.
        RectTransform _0xfb1aac24 = this._0xa17daa46(_0x702b6f0d, 1070f, 320f, _0x8a1da21f._0x453d7280(new byte[8] { 139, 163, 173, 160, 143, 173, 190, 168 }, 204));
        TextMeshProUGUI _0x1403ba78 = _0x253833cf.Caption(_0xfb1aac24, _0x8a1da21f._0x453d7280(new byte[9] { 24, 48, 62, 51, 11, 54, 43, 51, 58 }, 95), _0x253833cf.Middle, new Vector2(-250f, 100f), new Vector2(500f, 44f), _0x8a1da21f._0x453d7280(new byte[10] { 122, 97, 106, 111, 119, 14, 105, 97, 111, 98 }, 46), 32f, _0x857790a9.Mist, this._art._0xed34cdf9, TextAlignmentOptions.Left);
        _0x1403ba78.characterSpacing = 6f;
        _0x253833cf.Caption(_0xfb1aac24, _0x8a1da21f._0x453d7280(new byte[8] { 3, 43, 37, 40, 6, 43, 32, 61 }, 68), _0x253833cf.Middle, new Vector2(-150f, 26f), new Vector2(700f, 70f), _0x8a1da21f._0x453d7280(new byte[13] { 12, 16, 29, 31, 25, 124, 111, 124, 26, 16, 29, 27, 15 }, 92), 56f, _0x857790a9.Foam, this._art._0xed34cdf9, TextAlignmentOptions.Left);
        Image _0x225a2483 = _0x253833cf.Bar(_0xfb1aac24, _0x8a1da21f._0x453d7280(new byte[4] { 168, 128, 142, 131 }, 239), _0x253833cf.Middle, new Vector2(-130f, -74f), new Vector2(740f, 26f), _0x857790a9.Tint(_0x857790a9.Ink, 0.7f), _0x857790a9.Teal, this._art._0x0f6a08a7);
        int _0x319c7f04 = _0x99c12d2e._0x139e33cb;
        _0x225a2483.rectTransform.sizeDelta = new Vector2(740f * ((float)_0x319c7f04 / _0x99c12d2e.FlagsPerWatch), 26f);
        _0x253833cf.Caption(_0xfb1aac24, _0x8a1da21f._0x453d7280(new byte[9] { 216, 240, 254, 243, 220, 240, 234, 241, 235 }, 159), _0x253833cf.Middle, new Vector2(400f, -40f), new Vector2(150f, 50f), _0x319c7f04.ToString() + _0x8a1da21f._0x453d7280(new byte[3] { 219, 212, 219 }, 251) + _0x99c12d2e.FlagsPerWatch.ToString(), 34f, _0x857790a9.Lantern, this._art._0xed34cdf9, TextAlignmentOptions.Center);
        // Shared quay strip.
        RectTransform _0x873cfc44 = this._0xa17daa46(_0x702b6f0d, 1480f, 300f, _0x8a1da21f._0x453d7280(new byte[9] { 196, 245, 226, 240, 212, 243, 245, 238, 247 }, 135));
        TextMeshProUGUI _0x883b96eb = _0x253833cf.Caption(_0x873cfc44, _0x8a1da21f._0x453d7280(new byte[10] { 54, 17, 23, 12, 21, 49, 12, 17, 9, 0 }, 101), _0x253833cf.Middle, new Vector2(-250f, 105f), new Vector2(540f, 44f), _0x8a1da21f._0x453d7280(new byte[13] { 20, 27, 2, 21, 119, 7, 5, 24, 16, 5, 18, 4, 4 }, 87), 32f, _0x857790a9.Mist, this._art._0xed34cdf9, TextAlignmentOptions.Left);
        _0x883b96eb.characterSpacing = 6f;
        this._0x9d2fb8fe = new _0x6e343b66()._0x92f042b6(_0x873cfc44, this._art, _0x253833cf.Middle, new Vector2(0f, -20f), 96f, 44f, true);
        this._0x9d2fb8fe._0xbdb52a90(_0x99c12d2e._0xd64e3fc3, _0x8a1da21f._0x453d7280(new byte[6] { 17, 22, 1, 7, 27, 0 }, 83));
        _0x253833cf.Caption(_0x702b6f0d, _0x8a1da21f._0x453d7280(new byte[8] { 196, 248, 245, 237, 220, 253, 250, 224 }, 148), _0x253833cf.TopCentre, new Vector2(-140f, -2080f), new Vector2(760f, 44f), _0x8a1da21f._0x453d7280(new byte[44] { 112, 101, 116, 4, 102, 97, 118, 112, 108, 119, 4, 112, 107, 4, 98, 109, 106, 109, 119, 108, 4, 101, 4, 112, 101, 119, 111, 4, 101, 106, 96, 4, 116, 104, 101, 106, 112, 4, 101, 4, 98, 104, 101, 99 }, 36), 30f, _0x857790a9.Mist, this._art._0xed34cdf9, TextAlignmentOptions.Center);
        TextMeshProUGUI _0x23fba344 = _0x253833cf.Caption(_0x702b6f0d, _0x8a1da21f._0x453d7280(new byte[12] { 226, 222, 211, 203, 244, 221, 221, 198, 220, 221, 198, 215 }, 178), _0x253833cf.TopCentre, new Vector2(-140f, -2160f), new Vector2(760f, 40f), _0x8a1da21f._0x453d7280(new byte[46] { 173, 172, 195, 161, 166, 183, 176, 195, 204, 195, 173, 172, 195, 179, 177, 170, 185, 166, 176, 195, 204, 195, 167, 166, 160, 172, 177, 162, 183, 170, 181, 166, 195, 179, 177, 172, 164, 177, 166, 176, 176, 195, 172, 173, 175, 186 }, 227), 28f, _0x857790a9.Mist, this._art._0xed34cdf9, TextAlignmentOptions.Center);
        _0x23fba344.alpha = 0.8f;
    }

    /// <summary>
    /// The template ships five tutorial panels this game does not use, and every label in
    /// them still carries the template's own copy. The tutorial is disabled, so they are
    /// never shown - but an unused panel full of someone else's words is exactly what C.15
    /// is about, so their labels are emptied. The panels themselves stay in place: the
    /// controller addresses panels by index and a removed one breaks navigation.
    /// </summary>
    private void _0x46bb909d()
    {
        // Named one by one on purpose: the template declares seven tutorial slots and a
        // loop over a range leaves no trace that THIS panel was handled. ANDROID-3578
        // dressed two of five and shipped the template's copy on the other three.
        int[] _0x7cdabcca =
        {
            _0xd9957943._0x23baba46.TUTORIAL0,
            _0xd9957943._0x23baba46.TUTORIAL1,
            _0xd9957943._0x23baba46.TUTORIAL2,
            _0xd9957943._0x23baba46.TUTORIAL3,
            _0xd9957943._0x23baba46.TUTORIAL4,
            _0xd9957943._0x23baba46.TUTORIAL5,
            _0xd9957943._0x23baba46.TUTORIAL6,
        };
        for (int _0x7f53a980 = 0; _0x7f53a980 < _0x7cdabcca.Length; _0x7f53a980++)
        {
            int _0xdc03e8bd = _0x7cdabcca[_0x7f53a980];
            _0xa6e3970b _0xb59db888 = this._0x5a941397(_0xdc03e8bd);
            if (_0xb59db888 == null)
            {
                continue;
            }

            TMP_Text[] _0x1eac4f73 = _0xb59db888.GetComponentsInChildren<TMP_Text>(true);
            for (int _0xa9a9fe04 = 0; _0xa9a9fe04 < _0x1eac4f73.Length; _0xa9a9fe04++)
            {
                if (_0x1eac4f73[_0xa9a9fe04] != null)
                {
                    _0x1eac4f73[_0xa9a9fe04].text = string.Empty;
                }
            }
        }
    }

    private RectTransform _0xa17daa46(Transform _0xa9ea193f, float _0xd2fd63c9, float height, string _0x23439f6e)
    {
        RectTransform _0xd7ebb36e = _0x253833cf.Node(_0xa9ea193f, _0x23439f6e, _0x253833cf.TopCentre, new Vector2(0f, -_0xd2fd63c9), new Vector2(1060f, height));
        _0x253833cf.Plate(_0xd7ebb36e, _0x8a1da21f._0x453d7280(new byte[10] { 111, 77, 94, 72, 127, 68, 77, 72, 67, 91 }, 44), _0x253833cf.Middle, new Vector2(0f, -10f), new Vector2(1060f, height), _0x857790a9.Tint(_0x857790a9.Ink, 0.42f), this._art._0x0f6a08a7, 0.32f);
        _0x253833cf.Plate(_0xd7ebb36e, _0x8a1da21f._0x453d7280(new byte[8] { 156, 190, 173, 187, 157, 176, 187, 166 }, 223), _0x253833cf.Middle, Vector2.zero, new Vector2(1060f, height), _0x857790a9.Tint(_0x857790a9.Harbour, 0.96f), this._art._0x0f6a08a7, 0.32f);
        _0x253833cf.Plate(_0xd7ebb36e, _0x8a1da21f._0x453d7280(new byte[9] { 160, 130, 145, 135, 176, 139, 134, 134, 141 }, 227), _0x253833cf.Middle, new Vector2(0f, height * 0.24f), new Vector2(1036f, height * 0.46f), _0x857790a9.Tint(_0x857790a9.Slate, 0.3f), this._art._0x0f6a08a7, 0.38f);
        _0x253833cf.Plate(_0xd7ebb36e, _0x8a1da21f._0x453d7280(new byte[8] { 90, 120, 107, 125, 92, 125, 126, 124 }, 25), _0x253833cf.Middle, new Vector2(-524f, 0f), new Vector2(6f, height - 44f), _0x857790a9.Tint(_0x857790a9.Teal, 0.55f), this._art._0x0f6a08a7, 1.4f);
        return _0xd7ebb36e;
    }

    private CanvasGroup _0xa14d7d6c;
    private Image _0x293b46e2;
    private Image _0x7cf24079;
    private _0x6e343b66 _0xdc058d2f;
    private Image _0xbb4419e3(Transform _0xe066c018, float _0x310bcf46, string _0x4954aef7, bool _0xbe89ac16)
    {
        RectTransform _0x1266d486 = _0x253833cf.Node(_0xe066c018, _0x8a1da21f._0x453d7280(new byte[7] { 156, 169, 170, 139, 160, 161, 184 }, 200), _0x253833cf.TopCentre, new Vector2(_0x310bcf46, -340f), new Vector2(540f, 92f));
        Button _0x5f20c1b6 = _0x253833cf.Touchable(_0x1266d486, this._art._0x0f6a08a7);
        Image _0x07a2e339 = _0x1266d486.gameObject.GetComponent<Image>();
        if (_0x07a2e339 != null)
        {
            _0x07a2e339.pixelsPerUnitMultiplier = 0.34f;
        }

        TextMeshProUGUI _0xb9482280 = _0x253833cf.Caption(_0x1266d486, _0x8a1da21f._0x453d7280(new byte[8] { 160, 149, 150, 184, 149, 150, 145, 152 }, 244), _0x253833cf.Middle, Vector2.zero, new Vector2(480f, 56f), _0x4954aef7, 32f, _0x857790a9.Foam, this._art._0xed34cdf9, TextAlignmentOptions.Center);
        _0xb9482280.characterSpacing = 6f;
        _0x5f20c1b6.onClick.AddListener(() => this._0x93443819(_0xbe89ac16));
        return _0x07a2e339;
    }

    private void OnDestroy()
    {
        if (this._0x9d2fb8fe != null)
        {
            this._0x9d2fb8fe._0x4fe1d6c0();
        }

        if (this._0xdc058d2f != null)
        {
            this._0xdc058d2f._0x4fe1d6c0();
        }

        if (this._0xfae83cd7 != null)
        {
            this._0xfae83cd7._0xc1eb2f6d();
        }

        if (this._0x361f27c0 != null)
        {
            this._0x361f27c0._0xe1eb73ea();
        }

        if (this._playSlot != null)
        {
            DOTween.Kill(this._playSlot);
        }

        if (this._0xd2e2d48f != null)
        {
            DOTween.Kill(this._0xd2e2d48f);
        }
    }

    private void _0xcb2cc938(Image _0x965f99ec, TextMeshProUGUI _0x1b1371c2, bool _0x0a1e48fc)
    {
        if (_0x965f99ec != null)
        {
            _0x965f99ec.color = _0x0a1e48fc ? _0x857790a9.Teal : _0x857790a9.Tint(_0x857790a9.Slate, 0.4f);
        }

        if (_0x1b1371c2 != null)
        {
            _0x1b1371c2.color = _0x0a1e48fc ? _0x857790a9.Foam : _0x857790a9.Mist;
        }
    }

    private bool _0xe320727d;
    /// <summary>The lantern landed: HOME's copy of the ribbon has to agree with THE CREW's.</summary>
    private void _0xe9916b22()
    {
        if (this._0x9d2fb8fe != null)
        {
            this._0x9d2fb8fe._0xbdb52a90(_0x99c12d2e._0xd64e3fc3, _0x8a1da21f._0x453d7280(new byte[6] { 86, 81, 70, 64, 92, 71 }, 20));
        }
    }

    private const float Horizon = 2250f;
    // -- loader ------------------------------------------------------------------
    //
    // The loader must not hash as the same screen as HOME, so it takes the same backdrop
    // at a much heavier scrim (0.82 against HOME's 0.62), carries an ABSTRACT mark - never
    // the app name, never a slogan - and has none of HOME's cards, ribbon or CTA.
    private void _0x036827e8()
    {
        _0xa6e3970b _0x43551d40 = this._0x5a941397(_0xd9957943._0x23baba46.SPLASH);
        if (_0x43551d40 == null || _0x43551d40.Content == null)
        {
            return;
        }

        Transform _0x2081517b = _0x43551d40.Content.transform;
        RectTransform _0x624c1402 = _0x253833cf.Stretch(_0x2081517b, _0x8a1da21f._0x453d7280(new byte[10] { 16, 51, 47, 34, 48, 43, 1, 34, 32, 40 }, 67));
        _0x624c1402.SetAsFirstSibling();
        _0x253833cf.Wash(_0x624c1402, _0x8a1da21f._0x453d7280(new byte[11] { 205, 238, 242, 255, 237, 246, 205, 253, 236, 247, 243 }, 158), _0x857790a9.Tint(_0x857790a9.Ink, 0.82f));
        RectTransform _0x2f0c7df7 = _0x253833cf.Node(_0x2081517b, _0x8a1da21f._0x453d7280(new byte[10] { 95, 124, 96, 109, 127, 100, 65, 109, 126, 103 }, 12), _0x253833cf.TopCentre, new Vector2(0f, -980f), new Vector2(360f, 360f));
        _0x253833cf.Plate(_0x2f0c7df7, _0x8a1da21f._0x453d7280(new byte[8] { 45, 1, 18, 11, 40, 1, 12, 15 }, 96), _0x253833cf.Middle, Vector2.zero, new Vector2(360f, 360f), _0x857790a9.Tint(_0x857790a9.Teal, 0.16f), this._art._0x0f6a08a7, 0.1f);
        Image _0x7b987efe = _0x253833cf.Picture(_0x2f0c7df7, _0x8a1da21f._0x453d7280(new byte[9] { 161, 141, 158, 135, 171, 128, 149, 156, 132 }, 236), _0x253833cf.Middle, Vector2.zero, 300f, this._art._0x39a19e84, _0x857790a9.Foam);
        TextMeshProUGUI _0x0519a468 = _0x253833cf.Caption(_0x2081517b, _0x8a1da21f._0x453d7280(new byte[13] { 165, 134, 154, 151, 133, 158, 186, 153, 151, 146, 159, 152, 145 }, 246), _0x253833cf.TopCentre, new Vector2(0f, -1340f), new Vector2(900f, 70f), _0x8a1da21f._0x453d7280(new byte[7] { 153, 154, 148, 145, 156, 155, 146 }, 213), 48f, _0x857790a9.Foam, this._art._0xed34cdf9, TextAlignmentOptions.Center);
        _0x0519a468.characterSpacing = 10f;
        _0x253833cf.Caption(_0x2081517b, _0x8a1da21f._0x453d7280(new byte[10] { 47, 12, 16, 29, 15, 20, 50, 19, 8, 25 }, 124), _0x253833cf.TopCentre, new Vector2(0f, -1420f), new Vector2(1000f, 46f), _0x8a1da21f._0x453d7280(new byte[18] { 132, 134, 145, 132, 149, 134, 157, 154, 147, 244, 128, 156, 145, 244, 133, 129, 149, 141 }, 212), 30f, _0x857790a9.Mist, this._art._0xed34cdf9, TextAlignmentOptions.Center);
        _0x2f0c7df7.localScale = Vector3.one * 0.78f;
        _0x2f0c7df7.DOScale(1f, 0.6f).SetEase(Ease.OutBack, 1.15f).SetLink(_0x2f0c7df7.gameObject);
        _0x7b987efe.transform.DOLocalRotate(new Vector3(0f, 0f, -360f), 4f, RotateMode.LocalAxisAdd).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear).SetLink(_0x7b987efe.gameObject);
    }

    /// <summary>The template's PLAY button instance (an EMPTY_BASE_BUTTON carrying
    /// LoadSceneButton with LoadSceneId 1). We draw its face and never load the scene
    /// ourselves - the driver already does that, and doing both would double-load.</summary>
    [SerializeField]
    private RectTransform _playSlot;
    private Image _0xd2e2d48f;
    private void _0x6ca8fa71()
    {
        if (this._playSlot != null)
        {
            this._playSlot.localScale = Vector3.one * 0.92f;
            this._playSlot.DOScale(1f, 0.34f).SetEase(Ease.OutBack, 1.1f).SetDelay(0.21f).SetLink(this._playSlot.gameObject);
        }
    }

    /// <summary>Swap the two screens. Both the chip styling and the PLAY button's presence
    /// change, so the tap is unmistakable on a screenshot (C.7).</summary>
    private void _0x93443819(bool _0xa9854843)
    {
        this._0xe320727d = _0xa9854843;
        this._0xdb6095da(this._0xa14d7d6c, !_0xa9854843);
        this._0xdb6095da(this._0x6c902049, _0xa9854843);
        this._0xcb2cc938(this._0x293b46e2, this._0xc36145f7, !_0xa9854843);
        this._0xcb2cc938(this._0x7cf24079, this._0x3fef0186, _0xa9854843);
        if (this._playSlot != null)
        {
            this._playSlot.gameObject.SetActive(!_0xa9854843);
        }
    }

    private TextMeshProUGUI _0xc36145f7;
    private _0x5955c251 _0xfae83cd7;
    [SerializeField]
    private _0xaed87db8 _art;
}

internal static class _0x8a1da21f
{
    internal static string _0x453d7280(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}