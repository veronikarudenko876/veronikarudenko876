using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x23cfa6bc : MonoBehaviour
{
    private bool _0x587c6446(Touch? _0x71523771)
    {
        if (!_0x71523771.HasValue)
            return false;
        Vector3 _0x594daea1 = Camera.main.ScreenToWorldPoint(_0x71523771.Value.screenPosition);
        Vector3 _0xbe549029 = _0x594daea1;
        _0xbe549029.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xbe549029))
            return true;
        _0x71523771 = null;
        return false;
    }

    private bool _0x700094a5(Touch? _0xabe697e9, Bounds _0xcfdad355, TouchPhase _0xa7abac6b)
    {
        if (!_0x83b8da7d.Instance._0xed7dd4f8)
        {
            _0xabe697e9 = null;
            return false;
        }

        if (_0xabe697e9 != null)
            if (_0xabe697e9.Value.phase == _0xa7abac6b)
            {
                Vector3 _0x0b60ea81 = Camera.main.ScreenToWorldPoint(_0xabe697e9.Value.screenPosition);
                Vector3 _0x0179f0cc = new(_0x0b60ea81.x, _0x0b60ea81.y, _0xcfdad355.center.z);
                if (_0xcfdad355.Contains(_0x0179f0cc) && this._0x587c6446(_0xabe697e9.Value))
                    return true;
            }

        return false;
    }

    private Touch? _0x390a7829()
    {
        if (!_0x83b8da7d.Instance._0xed7dd4f8)
            return null;
        foreach (Touch _0x3c54fea8 in Touch.activeTouches)
            if (!_0x3c54fea8.ended)
                if (this._0x587c6446(_0x3c54fea8))
                    return _0x3c54fea8;
        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x82832dce = this.gameObject.GetComponent<_0x23cfa6bc>();
    }

    private Touch? _0xa6ec3002()
    {
        if (!_0x83b8da7d.Instance._0xed7dd4f8)
            return null;
        foreach (Touch _0x33b46ee7 in Touch.activeTouches)
            if (_0x33b46ee7.ended)
                if (this._0x587c6446(_0x33b46ee7))
                    return _0x33b46ee7;
        return null;
    }

    private Touch? _0x33e01115(Bounds _0xde9a274d)
    {
        if (!_0x83b8da7d.Instance._0xed7dd4f8)
            return null;
        foreach (Touch _0x6a336307 in Touch.activeTouches)
            if (!_0x6a336307.ended)
            {
                Vector3 _0xb0e7a2eb = Camera.main.ScreenToWorldPoint(_0x6a336307.screenPosition);
                Vector3 _0xa1721432 = new(_0xb0e7a2eb.x, _0xb0e7a2eb.y, _0xde9a274d.center.z);
                if (_0xde9a274d.Contains(_0xa1721432) && this._0x587c6446(_0x6a336307))
                    return _0x6a336307;
            }

        return null;
    }

    private static _0x23cfa6bc _0x82832dce;
    private Touch? _0x87b389db(Bounds _0x67a6202a)
    {
        if (!_0x83b8da7d.Instance._0xed7dd4f8)
            return null;
        foreach (Touch _0x5110c4ab in Touch.activeTouches)
            if (_0x5110c4ab.ended)
            {
                Vector3 _0x9dc54853 = Camera.main.ScreenToWorldPoint(_0x5110c4ab.screenPosition);
                Vector3 _0x34f9631a = new(_0x9dc54853.x, _0x9dc54853.y, _0x67a6202a.center.z);
                if (_0x67a6202a.Contains(_0x34f9631a) && this._0x587c6446(_0x5110c4ab))
                    return _0x5110c4ab;
            }

        return null;
    }

    private void _0xe8fc03ed(Touch? _0x540b3958)
    {
        if (!_0x83b8da7d.Instance._0xed7dd4f8)
        {
            _0x540b3958 = null;
            return;
        }

        int _0xdb08b66c = _0x540b3958.Value.touchId;
        _0x540b3958 = Touch.activeTouches.FirstOrDefault(_0x06475603 => _0x06475603.touchId == _0xdb08b66c);
        if (!this._0x587c6446(_0x540b3958.Value))
            _0x540b3958 = null;
    }

    private Touch? _0x9fa34a40(Bounds _0x8870d64d, TouchPhase _0x2edd283e)
    {
        if (!_0x83b8da7d.Instance._0xed7dd4f8)
            return null;
        foreach (Touch _0x371d78c0 in Touch.activeTouches)
            if (_0x371d78c0.phase == _0x2edd283e)
            {
                Vector3 _0x9749e1da = Camera.main.ScreenToWorldPoint(_0x371d78c0.screenPosition);
                Vector3 _0xb7d429d6 = new(_0x9749e1da.x, _0x9749e1da.y, _0x8870d64d.center.z);
                if (_0x8870d64d.Contains(_0xb7d429d6) && this._0x587c6446(_0x371d78c0))
                    return _0x371d78c0;
            }

        return null;
    }

    public BoxCollider2D CameraTouchBounds;
}