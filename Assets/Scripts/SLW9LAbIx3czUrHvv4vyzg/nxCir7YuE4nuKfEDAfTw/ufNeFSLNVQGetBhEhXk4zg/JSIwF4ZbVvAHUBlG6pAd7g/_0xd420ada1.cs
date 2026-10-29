using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xd420ada1 : MonoBehaviour
{
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xd420ada1>();
    }

    public float FirstAnimationTime = 10.0f;
    public Slider AnimationSlider;
    private Sequence _0xa6895613;
    public float SecondPassSliderValue = 0.5f;
    public GameObject Error;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xd9957943._0x35830778.SCENE_0 && !_0xfa433a31)
        {
            this._0xc5f63049();
        }
        else
        {
            this._0x83f33b17();
        }
    }

    public static _0xd420ada1 Instance;
    public GameObject Content;
    public void _0x943a9b73()
    {
        this._0xa6895613?.Kill();
        this.AnimationSlider.value = _0xfa433a31 ? this.SecondPassSliderValue : 0.05f;
    }

    private static bool _0xfa433a31 = false;
    public void _0x010c2fde()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0xa6895613?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0xfa433a31 = false;
    }

    public void _0x48cfface()
    {
        this._0xa6895613?.Pause();
    }

    public float DefaultAnimationTime = 0.4f;
    private void _0xc5f63049()
    {
        this.AnimationSlider.value = 0.05f;
        _0xfa433a31 = !_0xfa433a31;
        this._0xa6895613 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x81743a1a => this.AnimationSlider.value = _0x81743a1a, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0xdd507af9._0x4eb01ff6?._0xf53d361b();
        });
    }

    public void _0x83f33b17()
    {
        this._0x943a9b73();
        bool _0xad536aa5 = _0xfa433a31;
        this._0xa6895613 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x81743a1a => this.AnimationSlider.value = _0x81743a1a, _0xad536aa5 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0xfa433a31 = !_0xfa433a31;
    }

    public void _0x8720d606()
    {
        this._0xa6895613?.Play();
    }

    public GameObject Background;
}