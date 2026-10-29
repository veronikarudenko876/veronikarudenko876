using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0xe2979e5f : MonoBehaviour
{
    private void OnDisable()
    {
        if (this._0x8268954e != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x8268954e);
    }

    private const float MinOutlineWidth = 0.01f;
    private static float Linear(float _0x2642d3c5)
    {
        _0x2642d3c5 = Mathf.Clamp01(_0x2642d3c5);
        return _0x2642d3c5 <= 0.03928f ? _0x2642d3c5 / 12.92f : Mathf.Pow((_0x2642d3c5 + 0.055f) / 1.055f, 2.4f);
    }

    private void OnEnable()
    {
        if (this._0x8268954e == null)
            this._0x8268954e = _0x8610288b => this._0x504d1af9(_0x8610288b);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x8268954e);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x504d1af9(Object _0x67f10058)
    {
        TMP_Text _0xebe2b277 = _0x67f10058 as TMP_Text;
        if (_0xebe2b277 != null)
            this._0xcaab6afa.Add(_0xebe2b277);
    }

    private static _0xe2979e5f _0xec21f558;
    private readonly HashSet<TMP_Text> _0xcaab6afa = new HashSet<TMP_Text>();
    private static float Ratio(Color _0x2845a1c3, Color _0x1038dd09)
    {
        float _0xafa62594 = Luminance(_0x2845a1c3);
        float _0x21c9d425 = Luminance(_0x1038dd09);
        return (Mathf.Max(_0xafa62594, _0x21c9d425) + 0.05f) / (Mathf.Min(_0xafa62594, _0x21c9d425) + 0.05f);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0xec21f558 != null)
            return;
        GameObject _0x6e985ac8 = new GameObject(_0x737bcd76._0x9aa83085(new byte[16] { 249, 192, 221, 238, 194, 195, 217, 223, 204, 222, 217, 234, 216, 204, 223, 201 }, 173));
        _0x6e985ac8.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x6e985ac8);
        _0xec21f558 = _0x6e985ac8.AddComponent<_0xe2979e5f>();
    }

    private void LateUpdate()
    {
        if (this._0xcaab6afa.Count == 0)
            return;
        this._0x93aac9a0.Clear();
        this._0x93aac9a0.AddRange(this._0xcaab6afa);
        this._0xcaab6afa.Clear();
        for (int _0x2acd0f8d = 0; _0x2acd0f8d < this._0x93aac9a0.Count; _0x2acd0f8d++)
            Fix(this._0x93aac9a0[_0x2acd0f8d]);
    }

    private const float MinRatio = 4.5f;
    private readonly List<TMP_Text> _0x93aac9a0 = new List<TMP_Text>();
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x588e76c1)
    {
        return 0.2126f * Linear(_0x588e76c1.r) + 0.7152f * Linear(_0x588e76c1.g) + 0.0722f * Linear(_0x588e76c1.b);
    }

    private const float TargetRatio = 7f;
    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x8268954e;
    private static void Fix(TMP_Text _0x38b23086)
    {
        if (_0x38b23086 == null || !_0x38b23086.isActiveAndEnabled)
            return;
        Material _0x79b85412 = _0x38b23086.fontSharedMaterial;
        if (_0x79b85412 == null || !_0x79b85412.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x79b85412.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x79b85412.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0xa3c050ae = _0x38b23086.color;
        if (_0xa3c050ae.a <= 0f)
            return;
        Color _0x37617a30 = _0x79b85412.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0xa3c050ae, _0x37617a30) >= MinRatio)
            return;
        Color _0x9b82fef7 = Luminance(_0x37617a30) < 0.5f ? Color.white : Color.black;
        Color _0xe14b09c7;
        if (Ratio(_0x9b82fef7, _0x37617a30) < TargetRatio)
        {
            _0xe14b09c7 = _0x9b82fef7;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x24e7e13c = 0f;
            float _0x77954186 = 1f;
            for (int _0x059459c7 = 0; _0x059459c7 < 20; _0x059459c7++)
            {
                float _0xdfed6873 = (_0x24e7e13c + _0x77954186) * 0.5f;
                if (Ratio(Color.Lerp(_0xa3c050ae, _0x9b82fef7, _0xdfed6873), _0x37617a30) >= TargetRatio)
                    _0x77954186 = _0xdfed6873;
                else
                    _0x24e7e13c = _0xdfed6873;
            }

            _0xe14b09c7 = Color.Lerp(_0xa3c050ae, _0x9b82fef7, _0x77954186);
        }

        _0xe14b09c7.a = _0xa3c050ae.a;
        _0x38b23086.color = _0xe14b09c7;
    }
}

internal static class _0x737bcd76
{
    internal static string _0x9aa83085(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}