using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x6dde5d93 : MonoBehaviour
{
    public Button Button;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x83b8da7d.Instance._0x37c24232(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x83b8da7d.Instance._0x37c24232(this.LoadSceneId));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsLoadCurrentScene;
    public int LoadSceneId;
}