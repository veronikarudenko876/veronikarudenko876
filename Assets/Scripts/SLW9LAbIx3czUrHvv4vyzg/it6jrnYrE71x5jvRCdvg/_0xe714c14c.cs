using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xe714c14c : MonoBehaviour
{
    public void _0x70cb1fd5()
    {
        _0x83b8da7d.Instance._0x309a9835(true);
        _0x83b8da7d.Instance._0x37c24232(_0xd9957943._0x35830778.SCENE_0);
    }

    public List<TMP_Text> LevelNumberText = new();
    public List<TMP_Text> TimerText = new();
    [HideInInspector]
    public bool IsGameEnd;
    public List<Button> HomeButtons = new();
    private int _0x6ab684f7 => this.CustomTimeInitial + _0x83b8da7d._0x10fa0ed7._0x4f1b1f4c * 10;

    private void _0x87e639fb()
    {
        if (this.ScoreCurrent > _0x83b8da7d._0x10fa0ed7._0xb7a8879d)
            _0x83b8da7d._0x10fa0ed7._0xb7a8879d = this.ScoreCurrent;
        if (_0x0f7c1f59.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xe9549594)
                this._0x2a23e82e();
    }

    public void _0x2a23e82e()
    {
        if (!this.IsGameEnd)
        {
            this._0x3189a026();
            _0x83b8da7d.IsAfterLevelComplete = true;
            _0x83b8da7d.IsAfterLevelFailed = false;
            _0x0b453b2e _0x3a242bb2 = _0xf5f5e224.Instance._0xed6f10f1(_0xd9957943._0x38608dc2.WIN).GetComponent<_0x0b453b2e>();
            if (_0x0f7c1f59.Instance.IsCheckScoreEnabled)
                _0x3a242bb2.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xe9549594}";
            else
                _0x3a242bb2.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x0f7c1f59.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xd9957943._0x4f88f6a3._0x385b7ed3)
                    _0xd9957943._0x4f88f6a3._0x385b7ed3 = this.ScoreCurrent;
                _0x3a242bb2.ContentAdditionalText.text = $"{_0xd9957943._0x4f88f6a3._0x385b7ed3}";
            }
            else
            {
                _0x3a242bb2.ContentAdditionalText.text = $"{this._0x743bc9a8}";
                _0xd9957943._0x4f88f6a3._0x385b7ed3 += this._0x743bc9a8;
            }

            if (_0x0f7c1f59.Instance.IsLevelIncrementOnWin)
                ++_0x83b8da7d._0x10fa0ed7._0x4f1b1f4c;
            _0xf5f5e224.Instance._0x0f15495b(_0xd9957943._0x38608dc2.WIN);
        }
    }

    public int CustomTargetScore = 10;
    private void _0x3189a026()
    {
        this.IsGameEnd = true;
        _0x83b8da7d.IsAfterLevelComplete = true;
    }

    private void _0xaaecf7e1()
    {
        if (_0x0f7c1f59.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x261eb523 => _0x261eb523.text = $"{this.ScoreCurrent}/{this._0xe9549594}");
        else
            this.ScoreText.ForEach(_0x261eb523 => _0x261eb523.text = $"{this.ScoreCurrent}");
    }

    private int _0x743bc9a8 => this.ScoreCurrent;

    [HideInInspector]
    public int TimeLeft;
    private IEnumerator _0x37877c62()
    {
        this._0xe8c9e09a();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x83b8da7d.Instance._0x95196e3a == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x83b8da7d.Instance._0xed7dd4f8)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0xe8c9e09a();
            }
        }

        if (!this.IsGameEnd)
            this._0x8c0f4783();
    }

    public List<TMP_Text> SubtitleText = new();
    private void _0xe8c9e09a()
    {
        this.TimerText.ForEach(_0x261eb523 => _0x261eb523.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x801e39eb._0x675ca4f0(new byte[6] { 83, 83, 98, 4, 77, 77 }, 62)));
    }

    public int CustomTimeInitial = 30;
    private void Awake()
    {
        _0x051ab489 = this.gameObject.GetComponent<_0xe714c14c>();
    }

    private void _0xd1713a09()
    {
        if (this.ScoreCurrent >= this._0xe9549594)
            this._0x2a23e82e();
        else
            this._0x8c0f4783();
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x6ab684f7;
        this.CurrentGameIndex = _0x83b8da7d.Instance._0x95196e3a;
        foreach (Button _0x5a2d9af8 in this.HomeButtons)
            _0x5a2d9af8.onClick.AddListener(() =>
            {
                this._0x70cb1fd5();
            });
        foreach (Button _0xd4f05683 in this.PauseButtons)
            _0xd4f05683.onClick.AddListener(() =>
            {
                _0x83b8da7d.Instance._0x309a9835(false);
                _0xf5f5e224.Instance._0x0f15495b(_0xd9957943._0x38608dc2.PAUSE);
            });
        this._0xaaecf7e1();
        this.LevelNumberText.ForEach(_0x261eb523 => _0x261eb523.text = $"LVL {_0x83b8da7d._0x10fa0ed7._0x4f1b1f4c + 1}");
        if (_0x0f7c1f59.Instance.IsTimerEnabled)
        {
            this._0xe8c9e09a();
            this.StartCoroutine(this._0x37877c62());
        }
    }

    private static _0xe714c14c _0x051ab489;
    public void _0x88b0a0aa(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xaaecf7e1();
            this._0x87e639fb();
        }
    }

    private int _0xe9549594 => this.CustomTargetScore + _0x83b8da7d._0x10fa0ed7._0x4f1b1f4c * 10;

    public List<Button> PauseButtons = new();
    [HideInInspector]
    public int ScoreCurrent;
    [HideInInspector]
    public int CurrentGameIndex;
    public void _0x8c0f4783()
    {
        if (_0x0f7c1f59.Instance.IsOnlyWinGameEndEnabled)
            this._0x2a23e82e();
        if (!this.IsGameEnd)
        {
            this._0x3189a026();
            _0x83b8da7d.IsAfterLevelComplete = false;
            _0x83b8da7d.IsAfterLevelFailed = true;
            _0x0b453b2e _0x9bd24179 = _0xf5f5e224.Instance._0xed6f10f1(_0xd9957943._0x38608dc2.LOSE).GetComponent<_0x0b453b2e>();
            if (_0x0f7c1f59.Instance.IsCheckScoreEnabled)
                _0x9bd24179.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xe9549594}";
            else
                _0x9bd24179.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x9bd24179.ContentAdditionalText.text = $"{0}";
            _0xd9957943._0x4f88f6a3._0x385b7ed3 += 0;
            _0xf5f5e224.Instance._0x0f15495b(_0xd9957943._0x38608dc2.LOSE);
        }
    }

    public List<TMP_Text> ScoreText = new();
}

internal static class _0x801e39eb
{
    internal static string _0x675ca4f0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}