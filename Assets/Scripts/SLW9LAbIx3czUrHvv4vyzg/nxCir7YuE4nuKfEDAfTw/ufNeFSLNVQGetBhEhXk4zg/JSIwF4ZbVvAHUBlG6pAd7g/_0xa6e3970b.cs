using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xa6e3970b : MonoBehaviour
{
    public TMP_Text HeaderText;
    public void _0xfd900ec4()
    {
        this._0x1f772732();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    private void _0x58ede477()
    {
        if (this.OuterBackground != null)
        {
            Image _0xdf0c3427 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xdf0c3427, true);
            _0xdf0c3427.DOFade(1f, 0f);
        }
    }

    public TMP_Text MainText;
    private void _0x705371a0()
    {
        if (this.OuterBackground != null)
        {
            Image _0xa0a25250 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xa0a25250, true);
            _0xa0a25250.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public bool IsScaledDownOnAwake = true;
    public GameObject OuterBackground;
    private bool _0xb120834a => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x28d1b86f();
    }

    public void _0x2351981e()
    {
        this._0x58ede477();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0xd705b3c4.Instance._0x19cb4c5d(_0xd705b3c4.Instance.CurrentPanelIndex);
    }

    public GameObject Content;
    private void _0x1f772732()
    {
        if (this.OuterBackground != null)
        {
            Image _0x57326706 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x57326706, true);
            _0x57326706.DOFade(0f, this.ScaleDuration);
        }
    }

    public void Show()
    {
        this._0x705371a0();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0xd705b3c4.Instance._0x19cb4c5d(_0xd705b3c4.Instance.CurrentPanelIndex);
            });
        }
    }

    public Ease Ease = Ease.OutSine;
    private void _0x28d1b86f()
    {
        if (this.OuterBackground != null)
        {
            Image _0x7ebf5787 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x7ebf5787, true);
            _0x7ebf5787.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public float ScaleDuration = 0.4f;
}