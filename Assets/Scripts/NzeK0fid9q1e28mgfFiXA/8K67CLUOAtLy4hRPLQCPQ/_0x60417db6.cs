using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x60417db6 : MonoBehaviour
{
    private static ScreenOrientation _0x46c91e05 = ScreenOrientation.LandscapeLeft;
    private void _0xd1deef08()
    {
        if (this._0x7b1dda10 == null)
            return;
        Rect _0xf7b2fd17 = Screen.safeArea;
        Vector2 _0xcf2c5048 = _0xf7b2fd17.position;
        Vector2 _0x42c85bab = _0xf7b2fd17.position + _0xf7b2fd17.size;
        _0xcf2c5048.x /= this._0x148cad59.pixelRect.width;
        _0xcf2c5048.y /= this._0x148cad59.pixelRect.height;
        _0x42c85bab.x /= this._0x148cad59.pixelRect.width;
        _0x42c85bab.y /= this._0x148cad59.pixelRect.height;
        this._0x7b1dda10.anchorMin = _0xcf2c5048;
        this._0x7b1dda10.anchorMax = _0x42c85bab;
    }

    private static void ResolutionChanged()
    {
        _0x0fdf155b.x = Screen.width;
        _0x0fdf155b.y = Screen.height;
        _0x2e683309.Invoke();
    }

    private Canvas _0x148cad59;
    private static void OrientationChanged()
    {
        _0x46c91e05 = Screen.orientation;
        _0x0fdf155b.x = Screen.width;
        _0x0fdf155b.y = Screen.height;
        _0x2e683309.Invoke();
    }

    private RectTransform _0xf710741f;
    private static readonly List<_0x60417db6> _0x37cce949 = new();
    private void Update()
    {
        if (_0x37cce949[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x46c91e05)
            OrientationChanged();
        if (Screen.safeArea != _0x00eaf807)
            SafeAreaChanged();
        if (Screen.width != _0x0fdf155b.x || Screen.height != _0x0fdf155b.y)
            ResolutionChanged();
    }

    private static void SafeAreaChanged()
    {
        _0x00eaf807 = Screen.safeArea;
        for (int _0xe694ddf3 = 0; _0xe694ddf3 < _0x37cce949.Count; _0xe694ddf3++)
            _0x37cce949[_0xe694ddf3]._0xd1deef08();
    }

    private void OnDestroy()
    {
        if (_0x37cce949 != null && _0x37cce949.Contains(this))
            _0x37cce949.Remove(this);
    }

    private static UnityEvent _0x2e683309 = new();
    private static Rect _0x00eaf807 = Rect.zero;
    private static bool _0xbc0cb42f;
    private void Awake()
    {
        if (!_0x37cce949.Contains(this))
            _0x37cce949.Add(this);
        this._0x148cad59 = this.GetComponent<Canvas>();
        this._0xf710741f = this.GetComponent<RectTransform>();
        this._0x7b1dda10 = this.transform.Find(_0xf3e29aaf._0xd9d1f0c3(new byte[8] { 145, 163, 164, 167, 131, 176, 167, 163 }, 194)) as RectTransform;
        if (!_0xbc0cb42f)
        {
            _0x46c91e05 = Screen.orientation;
            _0x0fdf155b.x = Screen.width;
            _0x0fdf155b.y = Screen.height;
            _0x00eaf807 = Screen.safeArea;
            _0xbc0cb42f = true;
        }

        this._0xd1deef08();
    }

    private RectTransform _0x7b1dda10;
    private static Vector2 _0x0fdf155b = Vector2.zero;
}

internal static class _0xf3e29aaf
{
    internal static string _0xd9d1f0c3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}