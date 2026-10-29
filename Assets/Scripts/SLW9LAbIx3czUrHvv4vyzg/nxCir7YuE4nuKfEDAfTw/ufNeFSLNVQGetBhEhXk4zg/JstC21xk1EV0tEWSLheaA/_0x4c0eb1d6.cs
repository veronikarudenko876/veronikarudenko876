using TMPro;
using UnityEngine;
using static _0xd9957943;

public class _0x4c0eb1d6 : MonoBehaviour
{
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x440503b8;
            if (this.gameObject.TryGetComponent(out _0x440503b8))
                this.MoneyCountText = _0x440503b8;
        }

        this._0xa4a4de11();
    }

    public void _0xa4a4de11()
    {
        this.MoneyCountText.text = _0x4f88f6a3._0x385b7ed3.ToString();
    }

    public TMP_Text MoneyCountText;
}