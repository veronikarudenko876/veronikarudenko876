using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dresses the three template pops - WIN (7), LOSE (8) and PAUSE (6) - reached by INDEX,
/// never by name.
///
/// The template body of each pop (BGS, Container, BOT_BTNS_LEFT, TOP_BTNS, BOT_BTNS_RIGHT)
/// is switched off and one card of our own goes into the same Content. That is what removes
/// the template's "Score:" / "Reward:" rows and the close button whose Image has no sprite -
/// Unity draws that as a solid white rectangle (B.1 / C.3). The scrim is already there:
/// PopsController.BlurBackground is wired and dims the quay by itself, so this card adds
/// none of its own.
///
/// The card is rebuilt on every raise, never cached: captions and handlers are captured when
/// it is built, and a stale card would offer the wrong action.
/// </summary>
public sealed class _0xdd00bb9b : MonoBehaviour
{
    private const float CardHeight = 1200f;
    /// <summary>Called by the watch director so RESUME can hand control back.</summary>
    public void _0xcab4010c(System.Action _0xab22b35c)
    {
        this._0xaa1f5c17 = _0xab22b35c;
    }

    private void OnDestroy()
    {
        if (this._0x955f0950 != null)
        {
            this._0x955f0950._0x4fe1d6c0();
        }
    }

    /// <summary>The harbour log: what this watch contributed, and what the quay looks like now.</summary>
    public void _0x982c66b9(int _0xbbb81270, int _0x7a484b16)
    {
        _0xf5f5e224.Instance._0x0f15495b(_0xd9957943._0x38608dc2.WIN);
        _0x0b453b2e _0x00e63064 = _0xf5f5e224.Instance._0xed6f10f1(_0xd9957943._0x38608dc2.WIN);
        RectTransform _0x2e1e27d0 = this._0xc12fda86(_0x00e63064, _0xd9957943._0x38608dc2.WIN);
        if (_0x2e1e27d0 == null)
        {
            return;
        }

        bool _0x9b2f0252 = _0x7a484b16 >= _0x99c12d2e.BerthCount;
        this._0xf5f71ccb(_0x2e1e27d0, _0xe0260e47._0xd84f35a5(new byte[14] { 191, 169, 188, 171, 160, 200, 171, 167, 165, 184, 164, 173, 188, 173 }, 232));
        _0x253833cf.Picture(_0x2e1e27d0, _0xe0260e47._0xd84f35a5(new byte[6] { 206, 237, 229, 195, 240, 246 }, 130), _0x253833cf.Middle, new Vector2(0f, 280f), 210f, this._art._0x8aad929c, _0x857790a9.Foam);
        Image _0xeb4a9728 = _0x253833cf.Plate(_0x2e1e27d0, _0xe0260e47._0xd84f35a5(new byte[7] { 210, 241, 249, 214, 255, 242, 241 }, 158), _0x253833cf.Middle, new Vector2(0f, 280f), new Vector2(252f, 252f), _0x857790a9.Tint(_0x857790a9.Lantern, 0.22f), this._art._0x0f6a08a7, 0.18f);
        _0xeb4a9728.DOFade(0.45f, 0.9f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(_0xeb4a9728.gameObject);
        this._0xb9a5c58e(_0x2e1e27d0, _0xbbb81270.ToString() + _0xe0260e47._0xd84f35a5(new byte[25] { 207, 169, 163, 174, 168, 188, 207, 191, 163, 174, 161, 187, 170, 171, 229, 172, 163, 186, 173, 207, 190, 186, 174, 182, 207 }, 239) + _0x7a484b16.ToString() + _0xe0260e47._0xd84f35a5(new byte[3] { 125, 114, 125 }, 93) + _0x99c12d2e.BerthCount.ToString(), 60f);
        this._0x955f0950 = new _0x6e343b66()._0x92f042b6(_0x2e1e27d0, this._art, _0x253833cf.Middle, new Vector2(0f, -110f), 92f, 44f, false);
        this._0x955f0950._0xbdb52a90(_0x7a484b16, _0xe0260e47._0xd84f35a5(new byte[6] { 104, 111, 120, 126, 98, 121 }, 42));
        this._0xb8c3dabc(_0x2e1e27d0, _0x9b2f0252 ? _0xe0260e47._0xd84f35a5(new byte[19] { 250, 232, 232, 230, 141, 225, 236, 227, 249, 232, 255, 227, 141, 228, 254, 141, 225, 228, 249 }, 173) : _0xe0260e47._0xd84f35a5(new byte[31] { 132, 138, 133, 151, 227, 145, 134, 128, 134, 138, 149, 134, 135, 227, 238, 227, 139, 130, 145, 129, 140, 150, 145, 227, 143, 130, 141, 151, 134, 145, 141 }, 195));
        this._0x4b22b330(_0x2e1e27d0, -250f, _0xe0260e47._0xd84f35a5(new byte[9] { 218, 209, 195, 180, 215, 205, 215, 216, 209 }, 148), _0x857790a9.Teal, () => _0x83b8da7d.Instance._0x37c24232(_0xd9957943._0x35830778.SCENE_1));
        this._0x4b22b330(_0x2e1e27d0, 250f, _0xe0260e47._0xd84f35a5(new byte[7] { 130, 139, 152, 136, 133, 159, 152 }, 202), _0x857790a9.Slate, () => _0x83b8da7d.Instance._0x37c24232(_0xd9957943._0x35830778.SCENE_0));
        this._0x58fe2738(_0x2e1e27d0, () => _0xf5f5e224.Instance._0xb1f217f9());
    }

    private void _0xd9db0865()
    {
        _0xf5f5e224.Instance._0xb1f217f9();
        if (this._0xaa1f5c17 != null)
        {
            this._0xaa1f5c17();
        }
    }

    private readonly GameObject[] _0x679fd9c6 = new GameObject[16];
    /// <summary>
    /// Switch the template body off and give the pop a fresh card of our own. The card is
    /// built FIRST so the wipe can spare it by REFERENCE - comparing a GameObject's name
    /// would be a name-based lookup, which obfuscation breaks.
    /// </summary>
    private RectTransform _0xc12fda86(_0x0b453b2e _0x90c2a85e, int _0x60f4b6c7)
    {
        if (_0x90c2a85e == null || _0x90c2a85e.Content == null || this._art == null)
        {
            return null;
        }

        Transform _0x902647e7 = _0x90c2a85e.Content.transform;
        if (this._0x679fd9c6[_0x60f4b6c7] != null)
        {
            this._0x679fd9c6[_0x60f4b6c7].transform.SetParent(null, false);
            Destroy(this._0x679fd9c6[_0x60f4b6c7]);
            this._0x679fd9c6[_0x60f4b6c7] = null;
        }

        RectTransform _0x76f01230 = _0x253833cf.Node(_0x902647e7, _0xe0260e47._0xd84f35a5(new byte[11] { 33, 8, 27, 11, 6, 28, 27, 42, 8, 27, 13 }, 105), _0x253833cf.Middle, Vector2.zero, new Vector2(CardWidth, CardHeight));
        this._0x679fd9c6[_0x60f4b6c7] = _0x76f01230.gameObject;
        for (int _0xfb46dee0 = 0; _0xfb46dee0 < _0x902647e7.childCount; _0xfb46dee0++)
        {
            Transform _0xdad93b40 = _0x902647e7.GetChild(_0xfb46dee0);
            if (_0xdad93b40 != _0x76f01230.transform)
            {
                _0xdad93b40.gameObject.SetActive(false);
            }
        }

        _0x253833cf.Plate(_0x76f01230, _0xe0260e47._0xd84f35a5(new byte[10] { 192, 226, 241, 231, 208, 235, 226, 231, 236, 244 }, 131), _0x253833cf.Middle, new Vector2(0f, -14f), new Vector2(CardWidth, CardHeight), _0x857790a9.Tint(_0x857790a9.Ink, 0.45f), this._art._0x0f6a08a7, 0.3f);
        _0x253833cf.Plate(_0x76f01230, _0xe0260e47._0xd84f35a5(new byte[8] { 234, 200, 219, 205, 235, 198, 205, 208 }, 169), _0x253833cf.Middle, Vector2.zero, new Vector2(CardWidth, CardHeight), _0x857790a9.Tint(_0x857790a9.Harbour, 0.97f), this._art._0x0f6a08a7, 0.3f);
        _0x253833cf.Plate(_0x76f01230, _0xe0260e47._0xd84f35a5(new byte[9] { 254, 220, 207, 217, 238, 213, 216, 216, 211 }, 189), _0x253833cf.Middle, new Vector2(0f, 420f), new Vector2(CardWidth - 28f, 340f), _0x857790a9.Tint(_0x857790a9.Slate, 0.3f), this._art._0x0f6a08a7, 0.36f);
        _0x253833cf.Plate(_0x76f01230, _0xe0260e47._0xd84f35a5(new byte[8] { 159, 189, 174, 184, 142, 169, 176, 185 }, 220), _0x253833cf.Middle, new Vector2(0f, 400f), new Vector2(CardWidth - 200f, 5f), _0x857790a9.Tint(_0x857790a9.Teal, 0.5f), this._art._0x0f6a08a7, 1.4f);
        return _0x76f01230;
    }

    /// <summary>Pause, dressed to the same standard as the other two - it is seen most often.</summary>
    public void _0x5267c874(int _0x48a9c203, float _0xe4d5890d)
    {
        _0xf5f5e224.Instance._0x0f15495b(_0xd9957943._0x38608dc2.PAUSE);
        _0x0b453b2e _0xd6475883 = _0xf5f5e224.Instance._0xed6f10f1(_0xd9957943._0x38608dc2.PAUSE);
        RectTransform _0x64127a87 = this._0xc12fda86(_0xd6475883, _0xd9957943._0x38608dc2.PAUSE);
        if (_0x64127a87 == null)
        {
            return;
        }

        int _0x0d83c16e = Mathf.RoundToInt(Mathf.Clamp01(_0xe4d5890d) * 100f);
        this._0xf5f71ccb(_0x64127a87, _0xe0260e47._0xd84f35a5(new byte[8] { 167, 168, 165, 174, 169, 180, 163, 162 }, 230));
        _0x253833cf.Picture(_0x64127a87, _0xe0260e47._0xd84f35a5(new byte[8] { 114, 67, 87, 81, 71, 99, 80, 86 }, 34), _0x253833cf.Middle, new Vector2(0f, 280f), 210f, this._art._0x32988354, _0x857790a9.Tint(_0x857790a9.Teal, 0.95f));
        this._0xb9a5c58e(_0x64127a87, _0xe0260e47._0xd84f35a5(new byte[19] { 159, 131, 142, 235, 156, 138, 159, 136, 131, 235, 130, 152, 235, 155, 138, 158, 152, 142, 143 }, 203), 56f);
        this._0xb8c3dabc(_0x64127a87, _0xe0260e47._0xd84f35a5(new byte[6] { 235, 225, 236, 234, 254, 141 }, 173) + _0x48a9c203.ToString() + _0xe0260e47._0xd84f35a5(new byte[4] { 173, 194, 203, 173 }, 141) + _0x99c12d2e.FlagsPerWatch.ToString() + _0xe0260e47._0xd84f35a5(new byte[6] { 89, 7, 26, 23, 22, 115 }, 83) + _0x0d83c16e.ToString() + _0xe0260e47._0xd84f35a5(new byte[8] { 149, 229, 240, 231, 246, 240, 251, 225 }, 181));
        this._0x4b22b330(_0x64127a87, -250f, _0xe0260e47._0xd84f35a5(new byte[6] { 34, 53, 35, 37, 61, 53 }, 112), _0x857790a9.Teal, () => this._0xd9db0865());
        this._0x4b22b330(_0x64127a87, 250f, _0xe0260e47._0xd84f35a5(new byte[7] { 203, 194, 209, 193, 204, 214, 209 }, 131), _0x857790a9.Slate, () => _0x83b8da7d.Instance._0x37c24232(_0xd9957943._0x35830778.SCENE_0));
        this._0x58fe2738(_0x64127a87, () => this._0xd9db0865());
    }

    private _0x6e343b66 _0x955f0950;
    private void _0xb8c3dabc(RectTransform _0x9aa373cd, string _0xf2d1b380)
    {
        _0x253833cf.Caption(_0x9aa373cd, _0xe0260e47._0xd84f35a5(new byte[7] { 172, 147, 140, 178, 147, 136, 153 }, 252), _0x253833cf.Middle, new Vector2(0f, -250f), new Vector2(900f, 110f), _0xf2d1b380, 38f, _0x857790a9.Mist, this._art._0xed34cdf9, TextAlignmentOptions.Center);
    }

    /// <summary>The soft close. The brief has no losing, so this is a tide turning, not a defeat.</summary>
    public void _0x055f2d04(int _0xf1feb47a)
    {
        _0xf5f5e224.Instance._0x0f15495b(_0xd9957943._0x38608dc2.LOSE);
        _0x0b453b2e _0x6e822c08 = _0xf5f5e224.Instance._0xed6f10f1(_0xd9957943._0x38608dc2.LOSE);
        RectTransform _0x55225545 = this._0xc12fda86(_0x6e822c08, _0xd9957943._0x38608dc2.LOSE);
        if (_0x55225545 == null)
        {
            return;
        }

        this._0xf5f71ccb(_0x55225545, _0xe0260e47._0xd84f35a5(new byte[10] { 186, 167, 170, 171, 206, 186, 187, 188, 160, 189 }, 238));
        _0x253833cf.Picture(_0x55225545, _0xe0260e47._0xd84f35a5(new byte[7] { 106, 87, 90, 91, 127, 76, 74 }, 62), _0x253833cf.Middle, new Vector2(0f, 280f), 210f, this._art._0x3a3815eb, _0x857790a9.Tint(_0x857790a9.Lantern, 0.9f));
        this._0xb9a5c58e(_0x55225545, _0xe0260e47._0xd84f35a5(new byte[13] { 27, 13, 24, 15, 4, 108, 15, 0, 3, 31, 9, 8, 70 }, 76) + _0xf1feb47a.ToString() + _0xe0260e47._0xd84f35a5(new byte[4] { 225, 142, 135, 225 }, 193) + _0x99c12d2e.FlagsPerWatch.ToString() + _0xe0260e47._0xd84f35a5(new byte[14] { 218, 188, 182, 187, 189, 169, 218, 170, 182, 187, 180, 174, 191, 190 }, 250), 56f);
        this._0xb8c3dabc(_0x55225545, _0xe0260e47._0xd84f35a5(new byte[28] { 220, 192, 205, 168, 217, 221, 201, 209, 168, 195, 205, 205, 216, 219, 168, 209, 199, 221, 218, 168, 216, 218, 199, 207, 218, 205, 219, 219 }, 136));
        this._0x4b22b330(_0x55225545, -250f, _0xe0260e47._0xd84f35a5(new byte[10] { 183, 185, 185, 172, 220, 171, 189, 168, 191, 180 }, 252), _0x857790a9.Teal, () => _0x83b8da7d.Instance._0x37c24232(_0xd9957943._0x35830778.SCENE_1));
        this._0x4b22b330(_0x55225545, 250f, _0xe0260e47._0xd84f35a5(new byte[7] { 9, 0, 19, 3, 14, 20, 19 }, 65), _0x857790a9.Slate, () => _0x83b8da7d.Instance._0x37c24232(_0xd9957943._0x35830778.SCENE_0));
        this._0x58fe2738(_0x55225545, () => _0xf5f5e224.Instance._0xb1f217f9());
    }

    private void _0xf5f71ccb(RectTransform _0xcf4d3f6d, string _0x78d9b025)
    {
        TextMeshProUGUI _0xec132ed6 = _0x253833cf.Caption(_0xcf4d3f6d, _0xe0260e47._0xd84f35a5(new byte[9] { 202, 245, 234, 210, 255, 251, 254, 255, 232 }, 154), _0x253833cf.Middle, new Vector2(0f, 470f), new Vector2(700f, 90f), _0x78d9b025, 64f, _0x857790a9.Foam, this._art._0xed34cdf9, TextAlignmentOptions.Center);
        _0xec132ed6.characterSpacing = 4f;
    }

    [SerializeField]
    private _0xaed87db8 _art;
    private System.Action _0xaa1f5c17;
    /// <summary>The close cross. It carries an icon and no caption, as C.17 requires.</summary>
    private void _0x58fe2738(RectTransform _0xaad43e7b, UnityEngine.Events.UnityAction _0x163f527f)
    {
        RectTransform _0x0ec3647a = _0x253833cf.Node(_0xaad43e7b, _0xe0260e47._0xd84f35a5(new byte[8] { 60, 3, 28, 47, 0, 3, 31, 9 }, 108), _0x253833cf.Middle, new Vector2(460f, 500f), new Vector2(92f, 92f));
        Button _0x9aa4b9d7 = _0x253833cf.Touchable(_0x0ec3647a, this._art._0x0f6a08a7);
        Image _0x679eea55 = _0x0ec3647a.gameObject.GetComponent<Image>();
        if (_0x679eea55 != null)
        {
            _0x679eea55.color = _0x857790a9.Tint(_0x857790a9.Slate, 0.6f);
            _0x679eea55.pixelsPerUnitMultiplier = 0.4f;
        }

        // The cross is DRAWN, not loaded: the art contract has no close icon, and an Image
        // with an unresolved sprite is the white square that rule B.1 exists to prevent.
        _0x253833cf.Plate(_0x0ec3647a, _0xe0260e47._0xd84f35a5(new byte[12] { 179, 140, 147, 160, 143, 140, 144, 134, 161, 130, 145, 162 }, 227), _0x253833cf.Middle, Vector2.zero, new Vector2(46f, 7f), _0x857790a9.Mist, this._art._0x0f6a08a7, 1.6f).transform.localEulerAngles = new Vector3(0f, 0f, 45f);
        _0x253833cf.Plate(_0x0ec3647a, _0xe0260e47._0xd84f35a5(new byte[12] { 73, 118, 105, 90, 117, 118, 106, 124, 91, 120, 107, 91 }, 25), _0x253833cf.Middle, Vector2.zero, new Vector2(46f, 7f), _0x857790a9.Mist, this._art._0x0f6a08a7, 1.6f).transform.localEulerAngles = new Vector3(0f, 0f, -45f);
        _0x9aa4b9d7.onClick.AddListener(() => this._0x1e3df2de(_0x9aa4b9d7, _0x163f527f));
    }

    private const float CardWidth = 1060f;
    private void _0xb9a5c58e(RectTransform _0x92393879, string _0xdab474d9, float _0xe33f4339)
    {
        _0x253833cf.Caption(_0x92393879, _0xe0260e47._0xd84f35a5(new byte[7] { 168, 151, 136, 186, 151, 156, 129 }, 248), _0x253833cf.Middle, new Vector2(0f, 40f), new Vector2(900f, 160f), _0xdab474d9, _0xe33f4339, _0x857790a9.Lantern, this._art._0xed34cdf9, TextAlignmentOptions.Center);
    }

    /// <summary>One action button, captioned by MEANING and wired with a lambda (C.1/C.17).</summary>
    private void _0x4b22b330(RectTransform _0x83756e4e, float _0x894645c3, string _0x1dacdb81, Color _0x969e23a0, UnityEngine.Events.UnityAction _0x134e512b)
    {
        RectTransform _0x7b2b8b58 = _0x253833cf.Node(_0x83756e4e, _0xe0260e47._0xd84f35a5(new byte[9] { 102, 89, 70, 119, 85, 66, 95, 89, 88 }, 54), _0x253833cf.Middle, new Vector2(_0x894645c3, -470f), new Vector2(460f, 140f));
        Button _0x98a630c7 = _0x253833cf.Touchable(_0x7b2b8b58, this._art._0x0f6a08a7);
        Image _0x4f59d14d = _0x7b2b8b58.gameObject.GetComponent<Image>();
        if (_0x4f59d14d != null)
        {
            _0x4f59d14d.color = _0x969e23a0;
            _0x4f59d14d.pixelsPerUnitMultiplier = 0.42f;
        }

        TextMeshProUGUI _0x8dfab88a = _0x253833cf.Caption(_0x7b2b8b58, _0xe0260e47._0xd84f35a5(new byte[14] { 70, 121, 102, 87, 117, 98, 127, 121, 120, 90, 119, 116, 115, 122 }, 22), _0x253833cf.Middle, Vector2.zero, new Vector2(420f, 90f), _0x1dacdb81, 44f, _0x857790a9.Foam, this._art._0xed34cdf9, TextAlignmentOptions.Center);
        _0x8dfab88a.characterSpacing = 5f;
        _0x98a630c7.onClick.AddListener(() => this._0x1e3df2de(_0x98a630c7, _0x134e512b));
    }

    private void _0x1e3df2de(Button _0xb96d49bf, UnityEngine.Events.UnityAction _0xce42cea2)
    {
        if (_0xb96d49bf != null)
        {
            _0xb96d49bf.transform.DOScale(0.95f, 0.09f).SetLoops(2, LoopType.Yoyo).SetEase(Ease.OutQuad).SetLink(_0xb96d49bf.gameObject);
        }

        if (_0xce42cea2 != null)
        {
            _0xce42cea2();
        }
    }
}

internal static class _0xe0260e47
{
    internal static string _0xd84f35a5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}