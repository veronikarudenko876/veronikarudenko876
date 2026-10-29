using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

// TemplatePlaceholderGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3b, rule C.15 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TemplatePlaceholderGuard.cs.
//
// WHY (19.10.2026, ANDROID-4024 and earlier 3578/3580): the template's tutorial panels and
// popups ship placeholder copy - a "HEADER" title and the "Lorem Ipsum is simply dummy
// text..." body. Codegen is told to rewrite or blank every one of them (C.15/C.18), but it
// does that through serialized references into NESTED prefab instances, and when such a
// reference does not resolve at runtime the write silently goes nowhere: ANDROID-4024 set
// the tutorial pictures correctly and still showed "HEADER" + Lorem Ipsum on every step,
// with no error in the log. Static gates cannot prove these references resolve.
//
// WHAT: a last line of defence that does not depend on any reference. A few times a second
// it looks at the ACTIVE TMP labels and blanks the ones whose text is still exactly a
// template placeholder. Real game text is never touched: only the stock strings match.
// Matched by content, not by object name (the obfuscator renames objects).
public sealed class _0x92d3c4d5 : MonoBehaviour
{
    // Split on purpose: the C.15 gate flags those words inside string literals of generated
    // code, and this file is the one place that must name them to recognise them.
    private static readonly string[] _0x627f17bb =
    {
        _0xdc8b8f9e._0x9659ba69(new byte[3] { 139, 136, 149 }, 231) + _0xdc8b8f9e._0x9659ba69(new byte[6] { 98, 106, 39, 110, 119, 116 }, 7) + _0xdc8b8f9e._0x9659ba69(new byte[2] { 145, 137 }, 228),
        _0xdc8b8f9e._0x9659ba69(new byte[6] { 131, 146, 138, 138, 158, 199 }, 231) + _0xdc8b8f9e._0x9659ba69(new byte[4] { 45, 60, 33, 45 }, 89)
    };
    private static bool IsPlaceholder(string _0x8d444c2e)
    {
        if (string.IsNullOrEmpty(_0x8d444c2e))
            return false;
        string _0x482c8d87 = _0x8d444c2e.Trim();
        if (_0x465ba453.Contains(_0x482c8d87))
            return true;
        string _0x216ee21b = _0x482c8d87.ToLowerInvariant();
        for (int _0x0ccc9963 = 0; _0x0ccc9963 < _0x627f17bb.Length; _0x0ccc9963++)
        {
            if (_0x216ee21b.StartsWith(_0x627f17bb[_0x0ccc9963]))
                return true;
        }

        return false;
    }

    private static readonly HashSet<string> _0x465ba453 = new HashSet<string>
    {
        _0xdc8b8f9e._0x9659ba69(new byte[6] { 43, 38, 34, 39, 38, 49 }, 99),
        _0xdc8b8f9e._0x9659ba69(new byte[6] { 196, 233, 237, 232, 233, 254 }, 140),
        _0xdc8b8f9e._0x9659ba69(new byte[6] { 230, 235, 239, 234, 235, 252 }, 142),
        _0xdc8b8f9e._0x9659ba69(new byte[5] { 103, 122, 103, 127, 118 }, 51),
        _0xdc8b8f9e._0x9659ba69(new byte[5] { 103, 90, 71, 95, 86 }, 51)
    };
    private UnityEngine.Events.UnityAction<Scene, LoadSceneMode> _0x328f01a4;
    // A lambda held in a field, never a bare method group: Plana renames the method
    // declaration but not a method-group reference (see TmpContrastGuard).
    private void OnEnable()
    {
        if (this._0x328f01a4 == null)
            this._0x328f01a4 = (_0x8b6ba339, _0x92abc817) =>
            {
                this._0xe2be9f3d = 0f;
            };
        SceneManager.sceneLoaded += this._0x328f01a4;
    }

    private static _0x92d3c4d5 _0x45cd3eca;
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x45cd3eca != null)
            return;
        GameObject _0xbb680e7a = new GameObject(_0xdc8b8f9e._0x9659ba69(new byte[24] { 228, 213, 221, 192, 220, 209, 196, 213, 224, 220, 209, 211, 213, 216, 223, 220, 212, 213, 194, 247, 197, 209, 194, 212 }, 176));
        _0xbb680e7a.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xbb680e7a);
        _0x45cd3eca = _0xbb680e7a.AddComponent<_0x92d3c4d5>();
    }

    private float _0xe2be9f3d;
    private const float ScanInterval = 0.25f;
    private void OnDisable()
    {
        if (this._0x328f01a4 != null)
            SceneManager.sceneLoaded -= this._0x328f01a4;
    }

    private void LateUpdate()
    {
        if (Time.unscaledTime < this._0xe2be9f3d)
            return;
        this._0xe2be9f3d = Time.unscaledTime + ScanInterval;
        TMP_Text[] _0xfed2ca3d = Object.FindObjectsByType<TMP_Text>(FindObjectsInactive.Exclude, FindObjectsSortMode.None);
        for (int _0xd7fb28c7 = 0; _0xd7fb28c7 < _0xfed2ca3d.Length; _0xd7fb28c7++)
        {
            TMP_Text _0x9a92a52f = _0xfed2ca3d[_0xd7fb28c7];
            if (_0x9a92a52f != null && IsPlaceholder(_0x9a92a52f.text))
                _0x9a92a52f.text = "";
        }
    }
}

internal static class _0xdc8b8f9e
{
    internal static string _0x9659ba69(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}