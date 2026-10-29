using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x0b453b2e : MonoBehaviour
{
    private void _0x39c45031()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public Image ContentImage;
    public Ease ease = Ease.OutSine;
    public void _0x88ed37ef()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x39c45031();
    }

    public bool IsOnlyYScale;
    public bool IsScaledDownOnAwake = true;
    public GameObject Content;
    private void Start()
    {
    // Content.SetActive(false);
    }

    public static void HideAllPops()
    {
        _0xf5f5e224.Instance._0xb1f217f9();
    }

    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public TMP_Text ContentHeaderText;
    private bool _0x991e23ad => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public float scaleDuration = 0.4f;
    public TMP_Text ContentAdditionalText;
    public TMP_Text ContentMainText;
}