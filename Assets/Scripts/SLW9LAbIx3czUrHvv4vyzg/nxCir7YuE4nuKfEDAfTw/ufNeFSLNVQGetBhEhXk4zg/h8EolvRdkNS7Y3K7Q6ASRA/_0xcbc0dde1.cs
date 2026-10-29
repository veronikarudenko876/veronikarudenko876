using UnityEngine;
using UnityEngine.UI;

public class _0xcbc0dde1 : MonoBehaviour
{
    private void Start()
    {
        if (this._0x681b9f73)
            this._0xaa1287e1.onClick.AddListener(() => _0xd705b3c4.Instance._0xd1444a98());
        else
            this._0xaa1287e1.onClick.AddListener(() => _0xd705b3c4.Instance._0x635f95c6(this._0x94102cb1));
    }

    private int _0x94102cb1;
    private void Awake()
    {
        if (this._0xaa1287e1 == null)
            if (!this.TryGetComponent(out this._0xaa1287e1))
                this._0xaa1287e1 = this.GetComponentInChildren<Button>();
    }

    private Button _0xaa1287e1;
    private bool _0x681b9f73;
}