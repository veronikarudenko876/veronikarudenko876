using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xfcb64a1c : MonoBehaviour
{
    private TMP_Text _0x5dc6e5ca;
    private void _0x71245107()
    {
        if (this._0x92d24e97.canvasRenderer.GetColor() != this._0x5dc6e5ca.canvasRenderer.GetColor())
            this._0x5dc6e5ca.canvasRenderer.SetColor(this._0x92d24e97.canvasRenderer.GetColor());
    }

    private Image _0x92d24e97;
    private void Update()
    {
        this._0x71245107();
    }
}