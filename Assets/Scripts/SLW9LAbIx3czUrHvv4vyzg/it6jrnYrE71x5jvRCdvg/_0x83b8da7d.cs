using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xd9957943;

public class _0x83b8da7d : MonoBehaviour
{
    private void Start()
    {
        if (this._0x95196e3a != _0x35830778.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0x37c24232(_0x35830778.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x10fa0ed7._0xde325621 = false;
            _0xf5f5e224.Instance._0xb1f217f9();
            _0xd705b3c4.Instance._0x635f95c6(_0x23baba46.TUTORIAL0);
        });
    }

    private void _0xefec60cf(bool _0xef2df1b1)
    {
        Rigidbody2D[] _0xb0ab4392 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0xc1d68040 in _0xb0ab4392)
            if (_0xef2df1b1)
                _0xc1d68040.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0xc1d68040.constraints = RigidbodyConstraints2D.None;
    }

    private static _0x9fc666e6 _0x94331b4a => _0x9fc666e6.ALL_SCENES_SETTING_SINGLETONS[0];

    public static bool IsAfterLevelComplete;
    private void _0x6001a0b5()
    {
        IsAfterLevelComplete = true;
        Instance._0x37c24232(_0x35830778.SCENE_0);
    }

    private static void MakeGrid(List<RectTransform> _0x585688be, AspectRatioFitter _0xc907c5ca, float _0xeb30d648, int _0xfe533adf, int _0xf75c4f69)
    {
        _0xc907c5ca.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0xc907c5ca.aspectRatio = _0xeb30d648;
        foreach (RectTransform _0xa7b8a558 in _0x585688be)
        {
            int _0xb08275d8 = _0xa7b8a558.transform.GetSiblingIndex();
            _0xa7b8a558.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xb08275d8 % _0xfe533adf) * (1f / _0xfe533adf), (_0xf75c4f69 - (Mathf.FloorToInt((float)_0xb08275d8 / _0xfe533adf) % _0xf75c4f69 + 1f)) * (1f / _0xf75c4f69));
            _0xa7b8a558.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xb08275d8 % _0xfe533adf + 1f) * (1f / _0xfe533adf), (_0xf75c4f69 - Mathf.FloorToInt((float)_0xb08275d8 / _0xfe533adf) % _0xf75c4f69) * (1f / _0xf75c4f69));
            _0xa7b8a558.offsetMin = Vector2.zero;
            _0xa7b8a558.offsetMax = Vector2.zero;
        }
    }

    public void _0x7bae8038()
    {
        foreach (_0x4c0eb1d6 _0x3d0c40b2 in this.MoneyCountContainers)
            _0x3d0c40b2._0xa4a4de11();
    }

    public Canvas MainCanvas;
    private IEnumerator _0xed8ce3cc(int _0x0f612fa2)
    {
        _0xd705b3c4.Instance._0x635f95c6(_0x23baba46.SPLASH);
        AsyncOperation _0xd8cf7ac8 = SceneManager.LoadSceneAsync(_0x0f612fa2);
        while (!_0xd8cf7ac8.isDone)
            yield return null;
    }

    [HideInInspector]
    public List<_0x4c0eb1d6> MoneyCountContainers = new();
    public void _0xfcc8cd4f()
    {
        _0x10fa0ed7._0xde325621 = true;
    }

    private void _0x5a1dcee3(Transform _0x242c4b05)
    {
        Transform[] _0x46ef7c79 = _0x242c4b05.GetComponentsInChildren<Transform>();
        foreach (Transform _0xa0f69c01 in _0x46ef7c79)
            if (_0xa0f69c01 != null && DOTween.IsTweening(_0xa0f69c01))
            {
                if (this._0xed7dd4f8)
                    DOTween.Play(_0xa0f69c01);
                else
                    DOTween.Pause(_0xa0f69c01);
            }
    }

    public static _0x9fc666e6 _0x10fa0ed7 => _0x9fc666e6.ALL_SCENES_SETTING_SINGLETONS[Instance._0x95196e3a];

    public Transform Environment;
    public Transform EnvironmentWithTweensToToggle;
    public static _0x83b8da7d Instance;
    public void _0x37c24232(int _0xf853bf73)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xed8ce3cc(_0xf853bf73));
    }

    private IEnumerator _0x5cad2637(string _0x16171183)
    {
        _0xd705b3c4.Instance._0x635f95c6(_0x23baba46.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x850a5ad8 = SceneManager.LoadSceneAsync(_0x16171183);
        while (!_0x850a5ad8.isDone)
            yield return null;
    }

    public bool _0xed7dd4f8 { get; private set; }

    public void _0x309a9835(bool _0x21b58796)
    {
        this._0xed7dd4f8 = _0x21b58796;
        this._0xefec60cf(!this._0xed7dd4f8);
        Physics2D.simulationMode = this._0xed7dd4f8 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x5a1dcee3(this.EnvironmentWithTweensToToggle);
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public Button DeleteProgressDataButton;
    private static void ExitGame()
    {
        Application.Quit();
    }

    public Button ShowResetTutorialButton;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x83b8da7d>();
        this.RootGameObject = GameObject.FindWithTag(_0x70ade84a._0x5cfe5e67(new byte[4] { 105, 84, 84, 79 }, 59));
        if (this._0x95196e3a == _0x35830778.SCENE_0)
            this._0x309a9835(true);
        else
            this._0x309a9835(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x4c0eb1d6>(true).ToList();
    }

    private static _0x9fc666e6 GAME_INDEX_SETTINGS(int _0x05adc006)
    {
        return _0x9fc666e6.ALL_SCENES_SETTING_SINGLETONS[_0x05adc006];
    }

    public static bool IsAfterLevelFailed = false;
    public void _0xdb8d7d8d()
    {
        this._0x37c24232(SceneManager.GetActiveScene().buildIndex);
    }

    public int _0x95196e3a => SceneManager.GetActiveScene().buildIndex;
}

internal static class _0x70ade84a
{
    internal static string _0x5cfe5e67(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}