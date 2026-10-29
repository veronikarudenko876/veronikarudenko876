using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x3aa41c55 : MonoBehaviour
{
    private float _0x7ac6b47f = 1.5f;
    private float _0x01558d5c = 4;
    private void Update()
    {
        int _0x173082e1 = 1;
        if (this._0x512809f8.Count > 0)
        {
            string _0x4e9576e1 = this._0x55e293f5.text;
            foreach (string _0xfd56eae3 in this._0x512809f8)
                while (_0x4e9576e1.Contains(_0xfd56eae3))
                    _0x4e9576e1 = _0x4e9576e1.Replace(_0xfd56eae3, "");
            _0x173082e1 = _0x4e9576e1.Length;
        }
        else
        {
            _0x173082e1 = this._0x55e293f5.text.Length;
        }

        float _0xddebe7c5 = Mathf.Clamp(this._0xf55a9cc0 + this._0xd332d81b * _0x173082e1, this._0x7ac6b47f, this._0x01558d5c);
        if (!Mathf.Approximately(this._0x00d203c3.aspectRatio, _0xddebe7c5))
            this._0x00d203c3.aspectRatio = _0xddebe7c5;
    }

    private float _0xf55a9cc0;
    private float _0xd332d81b = 0.6f;
    private AspectRatioFitter _0x00d203c3;
    private TMP_Text _0x55e293f5;
    private List<string> _0x512809f8 = new();
}