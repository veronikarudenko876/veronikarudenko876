using UnityEngine;
using UnityEngine.UI;

public class _0x9bfbe5e9 : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsHideAllPops;
    public Button Button;
    public bool IsShowLastPop;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xf5f5e224.Instance._0xa303b754();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xf5f5e224.Instance._0xb1f217f9());
        else
            this.Button.onClick.AddListener(() => _0xf5f5e224.Instance._0x0f15495b(this.PopToShowIndex));
    }

    public int PopToShowIndex;
}