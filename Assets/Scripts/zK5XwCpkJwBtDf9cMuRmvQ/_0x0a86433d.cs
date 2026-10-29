using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// One berth of the quay: the mooring plate, its lantern, the cargo crest slot and the
/// pennant slot. Built by <see cref = "HarbourBoard"/>; no constructor, Init returns itself
/// (CLAUDE-unity.md C.59). Every tween is linked to the plate so a scene change kills it
/// (C.56).
/// </summary>
public sealed class _0x0a86433d
{
    public _0x0a86433d _0x5407f921(RectTransform _0xbf408955, Image _0xb9a656e7, Image _0xc7060efd, Image _0xa4a37deb, Image _0x3fc777b1, Image _0xfe552729, Button _0x134126a8, Color _0x900e8c86)
    {
        this._0x008cd3c8 = _0xbf408955;
        this._0x19c2a001 = _0xb9a656e7;
        this._0x851a4be0 = _0xc7060efd;
        this._0x400dd204 = _0xa4a37deb;
        this._0xf0f00d19 = _0x3fc777b1;
        this._0x80bbba19 = _0xfe552729;
        this._0x54a003df = _0x134126a8;
        this._0xe228c739 = _0x900e8c86;
        return this;
    }

    public void _0x0d834c39()
    {
        if (this._0xf0f00d19 != null)
        {
            this._0xf0f00d19.transform.DOShakePosition(0.25f, 12f, 14, 70f, false, true).SetLink(this._0xf0f00d19.gameObject);
        }
    }

    public void _0x15ca8652(bool _0x4bba8992)
    {
        if (this._0x54a003df != null)
        {
            this._0x54a003df.interactable = _0x4bba8992;
        }
    }

    private Image _0x400dd204;
    private Image _0x19c2a001;
    public Button _0x6be5a7ab => this._0x54a003df;

    /// <summary>Light the lantern - the beam signal, the tide pulse and the assist all use
    /// this, in their own colour.</summary>
    public void _0x69e03faf(Color _0x691e235e, float _0xcbbd3526)
    {
        if (this._0x851a4be0 == null)
        {
            return;
        }

        DOTween.Kill(this._0x851a4be0);
        this._0x851a4be0.color = _0x691e235e;
        this._0x851a4be0.DOColor(this._0xe228c739, _0xcbbd3526).SetEase(Ease.InOutSine).SetLink(this._0x851a4be0.gameObject);
        if (this._0x008cd3c8 != null)
        {
            this._0x008cd3c8.DOScale(1.06f, _0xcbbd3526 * 0.4f).SetLoops(2, LoopType.Yoyo).SetEase(Ease.OutQuad).SetLink(this._0x008cd3c8.gameObject);
        }
    }

    /// <summary>A wrong tap: a soft shake, never a penalty.</summary>
    public void _0xdd70072e()
    {
        if (this._0x008cd3c8 == null)
        {
            return;
        }

        this._0x008cd3c8.DOShakeAnchorPos(0.25f, 10f, 12, 60f, false, true).SetLink(this._0x008cd3c8.gameObject);
    }

    public RectTransform _0x2a7d681f => this._0x008cd3c8;

    public void _0x5eb7a3ea(Sprite _0x10bd2389)
    {
        if (this._0xf0f00d19 == null)
        {
            return;
        }

        this._0xf0f00d19.sprite = _0x10bd2389;
        this._0xf0f00d19.preserveAspect = true;
        this._0xf0f00d19.enabled = _0x10bd2389 != null;
        if (_0x10bd2389 != null)
        {
            this._0xf0f00d19.transform.localScale = Vector3.one * 0.7f;
            this._0xf0f00d19.transform.DOScale(1f, 0.22f).SetEase(Ease.OutBack).SetLink(this._0xf0f00d19.gameObject);
        }
    }

    private Image _0x851a4be0;
    private RectTransform _0x008cd3c8;
    private Button _0x54a003df;
    /// <summary>The teal ring that marks the tide target.</summary>
    public void _0xf8923cfb(bool _0x3f43d600)
    {
        if (this._0x400dd204 != null)
        {
            this._0x400dd204.enabled = _0x3f43d600;
        }
    }

    /// <summary>Plant a pennant. <paramref name = "crewOwned"/> dims it, so another keeper's
    /// flag reads differently from the one this watch just earned.</summary>
    public void _0x595db821(Sprite _0x815e65c5, bool _0x59beab39)
    {
        if (this._0x80bbba19 == null)
        {
            return;
        }

        this._0x80bbba19.sprite = _0x815e65c5;
        this._0x80bbba19.preserveAspect = true;
        this._0x80bbba19.enabled = true;
        this._0x80bbba19.color = _0x59beab39 ? _0x857790a9.Tint(_0x857790a9.Mist, 0.55f) : _0x857790a9.Foam;
        if (_0x59beab39)
        {
            this._0x80bbba19.transform.localScale = Vector3.one;
            return;
        }

        this._0x80bbba19.transform.localScale = Vector3.zero;
        this._0x80bbba19.transform.DOScale(1f, 0.42f).SetEase(Ease.OutBack, 1.15f).SetLink(this._0x80bbba19.gameObject);
        this._0x69e03faf(_0x857790a9.Teal, 0.4f);
    }

    public void _0x056f613b()
    {
        if (this._0x851a4be0 != null)
        {
            DOTween.Kill(this._0x851a4be0);
        }

        if (this._0x008cd3c8 != null)
        {
            DOTween.Kill(this._0x008cd3c8);
        }
    }

    public bool _0x9bb40243 => this._0x80bbba19 != null && this._0x80bbba19.enabled;

    private Image _0x80bbba19;
    private Image _0xf0f00d19;
    private Color _0xe228c739;
    /// <summary>Tint the plate itself - used to fade a berth that is no longer in play.</summary>
    public void _0x840a84c5(Color _0xbe85bf84)
    {
        if (this._0x19c2a001 != null)
        {
            this._0x19c2a001.color = _0xbe85bf84;
        }
    }
}