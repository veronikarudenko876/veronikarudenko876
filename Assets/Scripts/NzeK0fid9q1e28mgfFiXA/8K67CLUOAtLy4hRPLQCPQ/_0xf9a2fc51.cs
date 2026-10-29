using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xf9a2fc51 : MonoBehaviour
{
    private static ScreenOrientation _0x0f551296 = ScreenOrientation.LandscapeLeft;
    private CanvasScaler _0xba63f60d;
    private Vector2 _0x737b230d;
    private RectTransform _0x6b571a23;
    private static Rect _0x4fa3ede5 = Rect.zero;
    private static void SafeAreaChanged()
    {
        _0x4fa3ede5 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private Canvas _0x0f39a8ec;
    private static void ApplySafeAreaToAll()
    {
        for (int _0x4a8c84cd = 0; _0x4a8c84cd < _0xc1543a16.Count; _0x4a8c84cd++)
            _0xc1543a16[_0x4a8c84cd]._0x96f268a7();
    }

    private static Vector2 _0x88ee0c20 = Vector2.zero;
    private static void ResolutionChanged()
    {
        _0x88ee0c20.x = Screen.width;
        _0x88ee0c20.y = Screen.height;
        _0x4fa3ede5 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x75a2c4a3.Invoke();
    }

    private RectTransform _0x7e62d53d;
    private void Start()
    {
    }

    private void OnDestroy()
    {
        if (_0xc1543a16 != null && _0xc1543a16.Contains(this))
            _0xc1543a16.Remove(this);
    }

    private static void OrientationChanged()
    {
        _0x0f551296 = Screen.orientation;
        _0x88ee0c20.x = Screen.width;
        _0x88ee0c20.y = Screen.height;
        _0x4fa3ede5 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x75a2c4a3.Invoke();
    }

    private static bool _0x0f27fe5b;
    private void Update()
    {
        if (_0xc1543a16.Count == 0 || _0xc1543a16[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x0f551296)
            OrientationChanged();
        if (Screen.safeArea != _0x4fa3ede5)
            SafeAreaChanged();
        if (Screen.width != _0x88ee0c20.x || Screen.height != _0x88ee0c20.y)
            ResolutionChanged();
    }

    private static readonly List<_0xf9a2fc51> _0xc1543a16 = new();
    private void Awake()
    {
        if (!_0xc1543a16.Contains(this))
            _0xc1543a16.Add(this);
        this._0x0f39a8ec = this.GetComponent<Canvas>();
        this._0xba63f60d = this.GetComponent<CanvasScaler>();
        if (this._0xba63f60d != null)
            this._0x737b230d = this._0xba63f60d.referenceResolution;
        this._0x6b571a23 = this.GetComponent<RectTransform>();
        this._0x7e62d53d = this.transform.Find(_0x64bcd7ed._0x1ff804ec(new byte[8] { 248, 202, 205, 206, 234, 217, 206, 202 }, 171)) as RectTransform;
        if (!_0x0f27fe5b)
        {
            _0x0f551296 = Screen.orientation;
            _0x88ee0c20.x = Screen.width;
            _0x88ee0c20.y = Screen.height;
            _0x4fa3ede5 = Screen.safeArea;
            _0x0f27fe5b = true;
        }

        this._0x96f268a7();
    }

    private static UnityEvent _0x75a2c4a3 = new();
    private void _0x96f268a7()
    {
        if (this._0x7e62d53d == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x99760c22 = Screen.safeArea;
        Vector2 _0x749861fd = _0x99760c22.position;
        Vector2 _0x5b8755f7 = _0x99760c22.position + _0x99760c22.size;
        _0x749861fd.x /= screenWidth;
        _0x749861fd.y /= screenHeight;
        _0x5b8755f7.x /= screenWidth;
        _0x5b8755f7.y /= screenHeight;
        this._0x7e62d53d.anchorMin = _0x749861fd;
        this._0x7e62d53d.anchorMax = _0x5b8755f7;
        this._0x7e62d53d.offsetMin = Vector2.zero;
        this._0x7e62d53d.offsetMax = Vector2.zero;
        if (this._0xba63f60d == null)
            return;
        Vector2 _0x664f6bec = _0x5b8755f7 - _0x749861fd;
        float _0xd026bd14 = 2f - _0x664f6bec.x;
        float _0x8a723d0f = 2f - _0x664f6bec.y;
        this._0xba63f60d.referenceResolution = this._0x737b230d * new Vector2(_0xd026bd14, _0x8a723d0f);
    }
}

internal static class _0x64bcd7ed
{
    internal static string _0x1ff804ec(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}