using UnityEngine;
using UnityEngine.UI;

public class _0x48fb81d7 : MonoBehaviour
{
    public Button TutorialEndButton;
    public int NextTutorialPanelIndex;
    public int EndTutorialPanelIndex = 1;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xd705b3c4.Instance._0x635f95c6(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x83b8da7d.Instance._0xfcc8cd4f());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xd705b3c4.Instance._0x635f95c6(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0xd705b3c4.Instance._0x635f95c6(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x83b8da7d.Instance._0xfcc8cd4f());
        }
    }

    public bool IsTutorialEndPanel;
    public Button NextTutorialButton;
}