using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The small UGUI factory this game is drawn with. Every method RETURNS the thing it made,
/// so no name here can ever be mistaken for a void method group by the button verifier.
///
/// Anchor convention: anchors are collapsed to a POINT, so <c>pos</c> is measured from THAT
/// corner, not from the parent centre. With <see cref = "TopCentre"/> a box of width w needs
/// |x| + w/2 to stay inside the parent's half width, and y runs DOWNWARD as a negative
/// number. Mixing this up is how a label ends up half off the panel.
/// </summary>
public static class _0x253833cf
{
    /// <summary>A horizontal track plus its fill. The fill is returned so the caller can
    /// drive its width; the track stays behind it.</summary>
    public static Image Bar(Transform _0x74a4cb7c, string _0xf300c898, Vector2 _0x1fad66cd, Vector2 _0x7c811769, Vector2 _0xa614e4dd, Color _0xb00c4526, Color _0x2c1a4a4a, Sprite _0x1579e051)
    {
        Plate(_0x74a4cb7c, _0xf300c898 + _0x55e36cc2._0xa5c6a1fe(new byte[5] { 70, 96, 115, 113, 121 }, 18), _0x1fad66cd, _0x7c811769, _0xa614e4dd, _0xb00c4526, _0x1579e051, 0.6f);
        RectTransform _0x60001d46 = Node(_0x74a4cb7c, _0xf300c898 + _0x55e36cc2._0xa5c6a1fe(new byte[4] { 93, 114, 119, 119 }, 27), _0x1fad66cd, _0x7c811769, _0xa614e4dd);
        _0x60001d46.pivot = new Vector2(0f, 0.5f);
        _0x60001d46.anchoredPosition = new Vector2(_0x7c811769.x - (_0xa614e4dd.x * 0.5f), _0x7c811769.y);
        Image _0xb5e0f94b = _0x60001d46.gameObject.AddComponent<Image>();
        _0xb5e0f94b.sprite = _0x1579e051;
        _0xb5e0f94b.type = Image.Type.Sliced;
        _0xb5e0f94b.pixelsPerUnitMultiplier = 0.6f;
        _0xb5e0f94b.color = _0x2c1a4a4a;
        _0xb5e0f94b.raycastTarget = false;
        return _0xb5e0f94b;
    }

    /// <summary>
    /// A solid surface. Uses the built-in 9-slice UI plate, so the corner radius is
    /// 12 / <paramref name = "roundness"/> canvas units and the sprite can never dangle.
    /// </summary>
    public static Image Plate(Transform _0x01d8cc6f, string _0x62b24403, Vector2 _0x581c3895, Vector2 _0xda04cda2, Vector2 _0xc2f45cbd, Color _0x3ef7cb39, Sprite _0x5110e6b1, float _0x224c5cc2)
    {
        RectTransform _0x12fcf673 = Node(_0x01d8cc6f, _0x62b24403, _0x581c3895, _0xda04cda2, _0xc2f45cbd);
        Image _0x7e203c3c = _0x12fcf673.gameObject.AddComponent<Image>();
        _0x7e203c3c.sprite = _0x5110e6b1;
        _0x7e203c3c.type = Image.Type.Sliced;
        _0x7e203c3c.pixelsPerUnitMultiplier = _0x224c5cc2;
        _0x7e203c3c.color = _0x3ef7cb39;
        _0x7e203c3c.raycastTarget = false;
        return _0x7e203c3c;
    }

    public static readonly Vector2 BottomCentre = new Vector2(0.5f, 0f);
    public static readonly Vector2 Middle = new Vector2(0.5f, 0.5f);
    /// <summary>A plate that fills its parent instead of taking a size.</summary>
    public static Image Wash(Transform _0x019564f0, string _0x07be1821, Color _0xa7f35139)
    {
        RectTransform _0x3739e570 = Stretch(_0x019564f0, _0x07be1821);
        Image _0x816ec157 = _0x3739e570.gameObject.AddComponent<Image>();
        _0x816ec157.color = _0xa7f35139;
        _0x816ec157.raycastTarget = false;
        return _0x816ec157;
    }

    /// <summary>A CanvasGroup on a new full-parent rect - the swap handle for a screen group.</summary>
    public static CanvasGroup Group(Transform _0x30edddf1, string _0x08256ac5)
    {
        RectTransform _0x51a804f1 = Stretch(_0x30edddf1, _0x08256ac5);
        return _0x51a804f1.gameObject.AddComponent<CanvasGroup>();
    }

    /// <summary>
    /// A label. Word wrap is OFF and auto-size is ON with a floor at the readability
    /// threshold, exactly as C.10 / C.12 require - line breaks come only from an explicit
    /// \n in the string.
    /// </summary>
    public static TextMeshProUGUI Caption(Transform _0x5cc0baf8, string _0xb0bf8bed, Vector2 _0x50a44045, Vector2 _0x87f30ded, Vector2 _0x331e4f75, string _0x53699014, float _0x304d43bf, Color _0x102e4617, TMP_FontAsset _0xe66d393f, TextAlignmentOptions _0x3f8a3551)
    {
        RectTransform _0x059a3939 = Node(_0x5cc0baf8, _0xb0bf8bed, _0x50a44045, _0x87f30ded, _0x331e4f75);
        TextMeshProUGUI _0x2c5d73a9 = _0x059a3939.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0xe66d393f != null)
        {
            _0x2c5d73a9.font = _0xe66d393f;
        }

        _0x2c5d73a9.text = _0x53699014;
        _0x2c5d73a9.color = _0x102e4617;
        _0x2c5d73a9.alignment = _0x3f8a3551;
        _0x2c5d73a9.textWrappingMode = TextWrappingModes.NoWrap;
        _0x2c5d73a9.overflowMode = TextOverflowModes.Overflow;
        _0x2c5d73a9.enableAutoSizing = true;
        _0x2c5d73a9.fontSizeMin = 24f;
        _0x2c5d73a9.fontSizeMax = _0x304d43bf;
        _0x2c5d73a9.fontSize = _0x304d43bf;
        _0x2c5d73a9.raycastTarget = false;
        _0x5837093c.ApplyOutline(_0x2c5d73a9, 0.18f);
        return _0x2c5d73a9;
    }

    public static readonly Vector2 TopCentre = new Vector2(0.5f, 1f);
    /// <summary>A rect that stretches to fill its parent.</summary>
    public static RectTransform Stretch(Transform _0x98fb7c1d, string _0xebe5c9ae)
    {
        GameObject _0x002bfe4d = new GameObject(_0xebe5c9ae, typeof(RectTransform));
        RectTransform _0x4caed585 = _0x002bfe4d.GetComponent<RectTransform>();
        _0x4caed585.SetParent(_0x98fb7c1d, false);
        _0x4caed585.anchorMin = Vector2.zero;
        _0x4caed585.anchorMax = Vector2.one;
        _0x4caed585.pivot = new Vector2(0.5f, 0.5f);
        _0x4caed585.offsetMin = Vector2.zero;
        _0x4caed585.offsetMax = Vector2.zero;
        _0x4caed585.localScale = Vector3.one;
        return _0x4caed585;
    }

    /// <summary>
    /// Make an existing rect pressable. The ColorBlock is reset to white in the same breath:
    /// a fresh Button inherits UGUI defaults that would otherwise multiply the face we just
    /// drew, and a template-derived one carries a normal colour of transparent black.
    /// </summary>
    public static Button Touchable(RectTransform _0xc95e4cb3, Sprite _0x6f4f4b56)
    {
        Image _0x5b7960ee = _0xc95e4cb3.gameObject.GetComponent<Image>();
        if (_0x5b7960ee == null)
        {
            _0x5b7960ee = _0xc95e4cb3.gameObject.AddComponent<Image>();
            _0x5b7960ee.sprite = _0x6f4f4b56;
            _0x5b7960ee.type = Image.Type.Sliced;
            _0x5b7960ee.color = new Color(1f, 1f, 1f, 0f);
        }

        _0x5b7960ee.raycastTarget = true;
        Button _0xc660ef19 = _0xc95e4cb3.gameObject.AddComponent<Button>();
        _0xc660ef19.targetGraphic = _0x5b7960ee;
        ColorBlock _0xf983926e = _0xc660ef19.colors;
        _0xf983926e.normalColor = Color.white;
        _0xf983926e.highlightedColor = Color.white;
        _0xf983926e.selectedColor = Color.white;
        _0xf983926e.pressedColor = new Color(0.82f, 0.82f, 0.82f, 1f);
        _0xf983926e.disabledColor = new Color(1f, 1f, 1f, 0.55f);
        _0xc660ef19.colors = _0xf983926e;
        return _0xc660ef19;
    }

    /// <summary>A bare rect under <paramref name = "parent"/>, anchored to a point.</summary>
    public static RectTransform Node(Transform _0x21c2b251, string _0x572bc9c7, Vector2 _0x64aafe2d, Vector2 _0xea539041, Vector2 _0x706e62e4)
    {
        GameObject _0x1e7f4803 = new GameObject(_0x572bc9c7, typeof(RectTransform));
        RectTransform _0x26c83cad = _0x1e7f4803.GetComponent<RectTransform>();
        _0x26c83cad.SetParent(_0x21c2b251, false);
        _0x26c83cad.anchorMin = _0x64aafe2d;
        _0x26c83cad.anchorMax = _0x64aafe2d;
        _0x26c83cad.pivot = new Vector2(0.5f, 0.5f);
        _0x26c83cad.sizeDelta = _0x706e62e4;
        _0x26c83cad.anchoredPosition = _0xea539041;
        _0x26c83cad.localScale = Vector3.one;
        return _0x26c83cad;
    }

    /// <summary>
    /// A content sprite. Always Simple + preserveAspect, so the square canvas the art
    /// pipeline pads every PNG onto is never stretched into an egg (F.2a).
    /// </summary>
    public static Image Picture(Transform _0xe96144b8, string _0x5bf66a19, Vector2 _0x7ab8bfe5, Vector2 _0x95dacdd3, float _0xb1f65cd9, Sprite _0x64dcfb38, Color _0x97fcf768)
    {
        RectTransform _0x5a18fa60 = Node(_0xe96144b8, _0x5bf66a19, _0x7ab8bfe5, _0x95dacdd3, new Vector2(_0xb1f65cd9, _0xb1f65cd9));
        Image _0x664f55e5 = _0x5a18fa60.gameObject.AddComponent<Image>();
        _0x664f55e5.sprite = _0x64dcfb38;
        _0x664f55e5.type = Image.Type.Simple;
        _0x664f55e5.preserveAspect = true;
        _0x664f55e5.color = _0x97fcf768;
        _0x664f55e5.raycastTarget = false;
        return _0x664f55e5;
    }
}

internal static class _0x55e36cc2
{
    internal static string _0xa5c6a1fe(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}