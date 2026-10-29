using UnityEngine;
using UnityEngine.UI;

public class _0x62e4260d : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsPhysicsRunOnClick;
    public Button Button;
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x83b8da7d.Instance._0x309a9835(this.IsPhysicsRunOnClick));
    }
}