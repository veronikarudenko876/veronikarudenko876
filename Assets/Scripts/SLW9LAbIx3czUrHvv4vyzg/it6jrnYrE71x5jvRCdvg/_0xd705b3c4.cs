using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xd9957943;

public class _0xd705b3c4 : MonoBehaviour
{
    public List<_0xa6e3970b> Panels;
    public float StaticBlurMaterialInitialValue;
    private void _0xab86fbbc(int _0x8c21032d)
    {
        this._0x7a70eff8(_0x8c21032d);
        this._0xc961c6fe(_0x8c21032d);
        this.CurrentPanelIndex = _0x8c21032d;
        this.Panels[_0x8c21032d]._0x2351981e();
    }

    public bool IsShowSplashOnStart = true;
    private void _0xc961c6fe(int _0xf07c8a3f)
    {
        if (_0xf07c8a3f == _0x23baba46.SPLASH)
            _0xd420ada1.Instance._0x943a9b73();
        if (_0x83b8da7d.Instance._0x95196e3a == _0x35830778.SCENE_0)
        {
        }
    }

    public void _0x19cb4c5d(int _0x237c894a)
    {
        if (_0x237c894a == _0x23baba46.SPLASH && _0x83b8da7d.Instance._0x95196e3a != _0x35830778.SCENE_0)
            _0xd420ada1.Instance._0x83f33b17();
        if (_0x83b8da7d.Instance._0x95196e3a != _0x35830778.SCENE_0)
        {
            if (_0x237c894a == _0x23baba46.SPLASH || _0x237c894a == _0x23baba46.TUTORIAL0)
                _0x83b8da7d.Instance._0x309a9835(false);
            else if (_0x237c894a == _0x23baba46.DEFAULT)
                _0x83b8da7d.Instance._0x309a9835(true);
        }
    }

    public int CurrentPanelIndex;
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private _0xa6e3970b _0x1306e40d(int _0x14671489)
    {
        return this.Panels[_0x14671489];
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xd705b3c4>();
    }

    private void SwitchSplash()
    {
        if (_0x0f7c1f59.Instance.IsTutorialEnabled && !_0x83b8da7d._0x10fa0ed7._0xde325621)
            this._0x635f95c6(_0x23baba46.TUTORIAL0);
        else
            this._0x635f95c6(_0x23baba46.DEFAULT);
    }

    public float ScaleDuration = 0.4f;
    private void Start()
    {
        this._0x03a4be23();
    }

    public void _0xd1444a98()
    {
        this.LastPanelIndexes.RemoveAll(_0x988f757b => _0x988f757b == this.CurrentPanelIndex);
        int _0x4e514995 = this.LastPanelIndexes.Last();
        this._0xc961c6fe(_0x4e514995);
        this._0x8eb6bc21(_0x4e514995);
        this.CurrentPanelIndex = _0x4e514995;
        this.Panels[_0x4e514995].Show();
    }

    private void _0x8eb6bc21(int _0x80a38a70)
    {
        this.LastPanelIndexes.Add(_0x80a38a70);
        this.CurrentPanelIndex = _0x80a38a70;
        for (int _0x86d60cfb = 0; _0x86d60cfb < this.Panels.Count; _0x86d60cfb++)
            if (_0x86d60cfb != _0x80a38a70 && this.Panels[_0x86d60cfb] != null)
                this.Panels[_0x86d60cfb]._0xfd900ec4();
    }

    private void _0x03a4be23()
    {
        this._0xab86fbbc(_0x23baba46.SPLASH);
        if (_0x83b8da7d.Instance._0x95196e3a == _0x35830778.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0xd420ada1.Instance.DefaultAnimationTime);
        }
    }

    public void _0x635f95c6(int _0x8a9bdcd2)
    {
        this._0x7a70eff8(_0x8a9bdcd2);
        this._0xc961c6fe(_0x8a9bdcd2);
        this.CurrentPanelIndex = _0x8a9bdcd2;
        this.Panels[_0x8a9bdcd2].Show();
    }

    private void _0x7a70eff8(int _0x4c56f67b)
    {
        this.LastPanelIndexes.Add(_0x4c56f67b);
        this.CurrentPanelIndex = _0x4c56f67b;
        for (int _0xd865325f = 0; _0xd865325f < this.Panels.Count; _0xd865325f++)
            if (_0xd865325f != _0x4c56f67b && this.Panels[_0xd865325f] != null)
                this.Panels[_0xd865325f]._0xfd900ec4();
    }

    public static _0xd705b3c4 Instance;
}