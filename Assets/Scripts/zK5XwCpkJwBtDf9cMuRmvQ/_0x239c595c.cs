using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The one free resource the brief allows: a single lantern a day, sent to the shared quay.
/// Nothing is bought, nothing is spent, nothing is wagered - the lantern flies across the
/// screen and lights one berth.
///
/// The day is gated on a PlayerPrefs stamp, so the button starts locked if it has already
/// been sent today.
/// </summary>
public sealed class _0x239c595c
{
    private void _0x66a99386()
    {
        if (this._0x27ab7fdc != null)
        {
            this._0x27ab7fdc.interactable = false;
        }

        if (this._0x4c463b68 != null)
        {
            this._0x4c463b68.color = _0x857790a9.Tint(_0x857790a9.Slate, 0.5f);
        }

        if (this._0x48d2f790 != null)
        {
            this._0x48d2f790.text = _0xb9f0de19._0xde8aed09(new byte[18] { 217, 212, 219, 193, 208, 199, 219, 181, 198, 208, 219, 193, 181, 193, 218, 209, 212, 204 }, 149);
        }

        if (this._0x2fe13211 != null)
        {
            this._0x2fe13211.text = _0xb9f0de19._0xde8aed09(new byte[35] { 200, 196, 198, 206, 171, 201, 202, 200, 192, 171, 223, 196, 198, 196, 217, 217, 196, 220, 171, 205, 196, 217, 171, 223, 195, 206, 171, 197, 206, 211, 223, 171, 196, 197, 206 }, 139);
        }
    }

    private TextMeshProUGUI _0x2fe13211;
    private RectTransform _0xaff42bc3;
    private Vector2 _0xcdafb3f4(Transform _0x3843bdfe)
    {
        RectTransform _0xdb0b293a = _0x3843bdfe as RectTransform;
        if (_0xdb0b293a == null)
        {
            return new Vector2(0f, 0f);
        }

        // The shared ribbon sits 880 units below the panel top in the CREW group.
        return new Vector2(-380f, (_0xdb0b293a.rect.height * 0.5f) - 880f);
    }

    private _0xaed87db8 _0xe6c18068;
    public _0x239c595c _0xc1890956(Transform _0xf88df707, _0xaed87db8 _0xe3ea68e5, float _0x86088ffe, _0x6e343b66 _0x5a9b168d, System.Action _0x2cae3cc5)
    {
        this._0xe6c18068 = _0xe3ea68e5;
        this._0xd2e51c65 = _0x5a9b168d;
        this._0x7422c72c = _0x2cae3cc5;
        RectTransform _0xec8b640e = _0x253833cf.Node(_0xf88df707, _0xb9f0de19._0xde8aed09(new byte[11] { 165, 136, 135, 157, 140, 155, 135, 174, 128, 143, 157 }, 233), _0x253833cf.TopCentre, new Vector2(0f, -_0x86088ffe), new Vector2(1060f, 150f));
        this._0xaff42bc3 = _0xec8b640e;
        _0x253833cf.Plate(_0xec8b640e, _0xb9f0de19._0xde8aed09(new byte[10] { 100, 74, 69, 87, 112, 75, 66, 71, 76, 84 }, 35), _0x253833cf.Middle, new Vector2(0f, -8f), new Vector2(1060f, 150f), _0x857790a9.Tint(_0x857790a9.Ink, 0.45f), _0xe3ea68e5._0x0f6a08a7, 0.36f);
        this._0x27ab7fdc = _0x253833cf.Touchable(_0xec8b640e, _0xe3ea68e5._0x0f6a08a7);
        this._0x4c463b68 = _0xec8b640e.gameObject.GetComponent<Image>();
        if (this._0x4c463b68 != null)
        {
            this._0x4c463b68.color = _0x857790a9.Lantern;
            this._0x4c463b68.pixelsPerUnitMultiplier = 0.36f;
        }

        _0x253833cf.Picture(_0xec8b640e, _0xb9f0de19._0xde8aed09(new byte[9] { 93, 115, 124, 110, 93, 118, 99, 106, 114 }, 26), _0x253833cf.Middle, new Vector2(-370f, 0f), 84f, _0xe3ea68e5._0x3a3815eb, _0x857790a9.Foam);
        this._0x48d2f790 = _0x253833cf.Caption(_0xec8b640e, _0xb9f0de19._0xde8aed09(new byte[9] { 158, 176, 191, 173, 149, 184, 187, 188, 181 }, 217), _0x253833cf.Middle, new Vector2(60f, 0f), new Vector2(720f, 80f), _0xb9f0de19._0xde8aed09(new byte[19] { 148, 130, 137, 131, 231, 134, 231, 129, 149, 130, 130, 231, 139, 134, 137, 147, 130, 149, 137 }, 199), 44f, _0x857790a9.Foam, _0xe3ea68e5._0xed34cdf9, TextAlignmentOptions.Center);
        this._0x48d2f790.characterSpacing = 4f;
        this._0x2fe13211 = _0x253833cf.Caption(_0xf88df707, _0xb9f0de19._0xde8aed09(new byte[8] { 185, 151, 152, 138, 176, 145, 138, 155 }, 254), _0x253833cf.TopCentre, new Vector2(0f, -(_0x86088ffe + 115f)), new Vector2(1000f, 40f), _0xb9f0de19._0xde8aed09(new byte[25] { 118, 119, 124, 25, 127, 107, 124, 124, 25, 117, 120, 119, 109, 124, 107, 119, 25, 124, 120, 122, 113, 25, 125, 120, 96 }, 57), 30f, _0x857790a9.Mist, _0xe3ea68e5._0xed34cdf9, TextAlignmentOptions.Center);
        this._0x27ab7fdc.onClick.AddListener(() => this._0xeea42779());
        if (_0x99c12d2e._0x91e38e58)
        {
            this._0x66a99386();
        }

        return this;
    }

    private void _0xbda7bb2d(RectTransform _0xe15bfe52, int _0xc7d80ec6)
    {
        if (_0xe15bfe52 != null)
        {
            Object.Destroy(_0xe15bfe52.gameObject);
        }

        if (this._0xd2e51c65 != null)
        {
            this._0xd2e51c65._0xbdb52a90(_0x99c12d2e._0xd64e3fc3, _0xb9f0de19._0xde8aed09(new byte[13] { 157, 154, 141, 139, 151, 140, 255, 153, 150, 147, 147, 154, 155 }, 223));
            this._0xd2e51c65._0x51cc9286(_0xc7d80ec6);
        }

        if (this._0x7422c72c != null)
        {
            this._0x7422c72c();
        }
    }

    public void _0xe1eb73ea()
    {
        if (this._0x27ab7fdc != null)
        {
            DOTween.Kill(this._0x27ab7fdc.transform);
        }
    }

    private void _0xeea42779()
    {
        if (_0x99c12d2e._0x91e38e58 || this._0xe6c18068 == null || this._0xaff42bc3 == null)
        {
            return;
        }

        _0x99c12d2e.StampLanternSent();
        int _0x342d7d01 = Mathf.Clamp(_0x99c12d2e._0xd64e3fc3, 0, _0x99c12d2e.BerthCount - 1);
        _0x99c12d2e._0xd64e3fc3 = _0x99c12d2e._0xd64e3fc3 + 1;
        // The lantern really travels: a caption change alone is not visible feedback (C.7).
        Transform _0x58238ab6 = this._0xaff42bc3.parent != null ? this._0xaff42bc3.parent : this._0xaff42bc3;
        RectTransform _0x35560d1a = _0x253833cf.Node(_0x58238ab6, _0xb9f0de19._0xde8aed09(new byte[13] { 253, 208, 223, 197, 212, 195, 223, 247, 221, 216, 214, 217, 197 }, 177), _0x253833cf.Middle, this._0x16b0e83e(_0x58238ab6), new Vector2(96f, 96f));
        Image _0x358e5e65 = _0x35560d1a.gameObject.AddComponent<Image>();
        _0x358e5e65.sprite = this._0xe6c18068._0x3a3815eb;
        _0x358e5e65.preserveAspect = true;
        _0x358e5e65.raycastTarget = false;
        _0x358e5e65.color = _0x857790a9.Foam;
        Vector2 _0xda384788 = this._0xcdafb3f4(_0x58238ab6);
        Sequence _0x51f7c7dc = DOTween.Sequence().SetLink(_0x35560d1a.gameObject);
        _0x51f7c7dc.Append(_0x35560d1a.DOAnchorPos(_0xda384788, 0.8f).SetEase(Ease.OutCubic));
        _0x51f7c7dc.Join(_0x35560d1a.DOScale(0.6f, 0.8f).SetEase(Ease.OutCubic));
        _0x51f7c7dc.OnComplete(() => this._0xbda7bb2d(_0x35560d1a, _0x342d7d01));
        this._0x66a99386();
    }

    private Image _0x4c463b68;
    private Button _0x27ab7fdc;
    private System.Action _0x7422c72c;
    private TextMeshProUGUI _0x48d2f790;
    private _0x6e343b66 _0xd2e51c65;
    private Vector2 _0x16b0e83e(Transform _0x1f5cc632)
    {
        RectTransform _0x575d3058 = _0x1f5cc632 as RectTransform;
        if (_0x575d3058 == null || this._0xaff42bc3 == null)
        {
            return Vector2.zero;
        }

        // The host is anchored to the top centre; the flight stage uses the middle, so the
        // offset is measured from the stage's own half height.
        return new Vector2(this._0xaff42bc3.anchoredPosition.x - 370f, (_0x575d3058.rect.height * 0.5f) + this._0xaff42bc3.anchoredPosition.y);
    }
}

internal static class _0xb9f0de19
{
    internal static string _0xde8aed09(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}