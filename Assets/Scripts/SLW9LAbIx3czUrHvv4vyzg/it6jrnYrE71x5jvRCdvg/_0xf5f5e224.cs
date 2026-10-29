using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xd9957943;

public class _0xf5f5e224 : MonoBehaviour
{
    private void _0x48bda222()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public _0x0b453b2e _0xed6f10f1(int _0x56339088)
    {
        return this.Pops[_0x56339088];
    }

    public static _0xf5f5e224 Instance;
    private void _0x666c58c9(bool _0x0171591f = false)
    {
        for (int _0xc0b04b22 = 0; _0xc0b04b22 < this.Pops.Count; ++_0xc0b04b22)
            if (this.Pops[_0xc0b04b22] != null && !(_0xc0b04b22 == this.CurrentPopIndex && _0x0171591f))
                this.Pops[_0xc0b04b22]._0x88ed37ef();
    }

    public void _0xa303b754()
    {
        this.LastPopIndexes.RemoveAll(_0x988f757b => _0x988f757b == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0xb1f217f9();
        else
            this._0x0f15495b(this.LastPopIndexes.Last());
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public List<_0x0b453b2e> Pops;
    public void _0xb1f217f9()
    {
        this.LastPopIndexes.Clear();
        this._0x666c58c9();
        foreach (GameObject _0xe1839cdf in this.GameObjectsToHide)
            if (_0xe1839cdf != null)
                _0xe1839cdf.SetActive(true);
        this._0xbe5a2c9a();
    }

    private void _0xbe5a2c9a()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public List<int> LastPopIndexes = new();
    public int CurrentPopIndex;
    public float ScaleDuration = 0.4f;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x0b453b2e _0xec167e01 in this.Pops)
            if (_0xec167e01 != null)
                _0xec167e01.gameObject.SetActive(true);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xf5f5e224>();
    }

    public GameObject BlurBackground;
    public List<GameObject> GameObjectsToHide;
    public void _0x0f15495b(int _0x8b9b0d5c)
    {
        this.CurrentPopIndex = _0x8b9b0d5c;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x666c58c9(true);
        this._0x48bda222();
        this.Pops[_0x8b9b0d5c].Show();
        foreach (GameObject _0xf0ba97de in this.GameObjectsToHide)
            _0xf0ba97de.SetActive(false);
    }
}