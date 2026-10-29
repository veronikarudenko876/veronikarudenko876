using UnityEngine;

/// <summary>
/// TIDE CALL. A lantern pulse walks the nine berths along a serpentine route; one berth
/// carries a teal ring. Tapping anywhere on the quay while the pulse sits on the marked
/// berth scores a step. A miss costs nothing - the pulse keeps going and the ring moves.
/// </summary>
public sealed class _0x6c81b666 : _0x4b8f06f9
{
    private int _0xc6a4b00c;
    private bool _0x127452a7()
    {
        if (this._0x6dc572cf < 0 || this._0x40041d85.Length == 0)
        {
            return false;
        }

        return this._0x40041d85[(this._0x6dc572cf + 1) % this._0x40041d85.Length] == this._0xc6a4b00c;
    }

    private const float GraceSeconds = 0.12f;
    public string Instruction => _0x632c1233._0x8b8e5678(new byte[43] { 49, 36, 53, 69, 50, 45, 32, 43, 69, 49, 45, 32, 69, 41, 36, 43, 49, 32, 55, 43, 111, 55, 32, 36, 38, 45, 32, 54, 69, 49, 45, 32, 69, 49, 32, 36, 41, 69, 39, 32, 55, 49, 45 }, 101);

    public void Advance(float delta)
    {
        if (this._0x6d571ba1 == null || this._0x40041d85.Length == 0)
        {
            return;
        }

        this._0x80ed9eac += delta;
        int _0xe03d553c = Mathf.FloorToInt(this._0x80ed9eac / DwellSeconds) % this._0x40041d85.Length;
        if (_0xe03d553c == this._0x6dc572cf)
        {
            return;
        }

        this._0x6dc572cf = _0xe03d553c;
        _0x0a86433d _0xd2748180 = this._0x8321ed62(this._0x40041d85[_0xe03d553c]);
        if (_0xd2748180 != null)
        {
            _0xd2748180._0x69e03faf(_0x857790a9.Lantern, DwellSeconds);
        }
    }

    private float _0x80ed9eac;
    public int AssistOneStep()
    {
        if (this._0x43093db3 >= this.StepsNeeded)
        {
            return -1;
        }

        int _0xff3700b0 = this._0xc6a4b00c;
        _0x0a86433d _0xda47337e = this._0x8321ed62(_0xff3700b0);
        if (_0xda47337e != null)
        {
            _0xda47337e._0x69e03faf(_0x857790a9.Lantern, 0.45f);
        }

        this._0x43093db3++;
        this._0x3c58e18a();
        return _0xff3700b0;
    }

    private System.Random _0x7582a353;
    public int StepsNeeded => 3;

    private void _0x3c58e18a()
    {
        if (this._0x6d571ba1 != null)
        {
            this._0x6d571ba1._0x71810f49();
        }

        if (this._0x43093db3 >= this.StepsNeeded || this._0x7582a353 == null || this._0x40041d85.Length == 0)
        {
            return;
        }

        int _0x9552f168 = this._0x40041d85[this._0x7582a353.Next(this._0x40041d85.Length)];
        int _0x62520112 = 0;
        while (_0x9552f168 == this._0xc6a4b00c && _0x62520112 < 12)
        {
            _0x9552f168 = this._0x40041d85[this._0x7582a353.Next(this._0x40041d85.Length)];
            _0x62520112++;
        }

        this._0xc6a4b00c = _0x9552f168;
        this._0xb9020e6c();
    }

    private _0x0a86433d _0x8321ed62(int _0xb6b74672)
    {
        if (this._0x6d571ba1 == null || _0xb6b74672 < 0 || _0xb6b74672 >= this._0x6d571ba1._0xb15a11e0.Length)
        {
            return null;
        }

        return this._0x6d571ba1._0xb15a11e0[_0xb6b74672];
    }

    public void Begin(_0x3ea7f588 _0xf33445de, _0x92b1008d _0x28c03370, _0xaed87db8 _0x317d786a, System.Random _0xcd91365e)
    {
        this._0x6d571ba1 = _0x28c03370;
        this._0x7582a353 = _0xcd91365e;
        this._0x43093db3 = 0;
        this._0x80ed9eac = 0f;
        this._0x6dc572cf = -1;
        this._0x40041d85 = _0xc7ad14b8.TideRoute(_0xf33445de.TideCorner, _0xf33445de.TideDirection);
        this._0xc6a4b00c = _0xf33445de.TideMarked;
        this._0xb9020e6c();
    }

    private int _0x43093db3;
    private int _0x6dc572cf = -1;
    public void BerthTapped(int _0x732f5745)
    {
        if (this._0x6d571ba1 == null || this._0x40041d85.Length == 0)
        {
            return;
        }

        // The window is the dwell plus a grace on each side, so a near-miss still counts.
        float _0xe8a5a3c1 = this._0x80ed9eac % DwellSeconds;
        bool _0xbbb1f1d1 = this._0x6dc572cf >= 0 && this._0x40041d85[this._0x6dc572cf] == this._0xc6a4b00c;
        bool _0x57eb8af8 = _0xbbb1f1d1 || (_0xe8a5a3c1 > DwellSeconds - GraceSeconds && this._0x127452a7()) || (_0xe8a5a3c1 < GraceSeconds && this._0xd6bb8d6b());
        _0x0a86433d _0x9c043ab0 = this._0x8321ed62(this._0xc6a4b00c);
        if (!_0x57eb8af8)
        {
            _0x0a86433d _0x57b747b4 = this._0x8321ed62(_0x732f5745);
            if (_0x57b747b4 != null)
            {
                _0x57b747b4._0xdd70072e();
            }

            return;
        }

        this._0x43093db3++;
        if (_0x9c043ab0 != null)
        {
            _0x9c043ab0._0x69e03faf(_0x857790a9.Teal, 0.3f);
        }

        this._0x3c58e18a();
    }

    private int[] _0x40041d85 = new int[0];
    private _0x92b1008d _0x6d571ba1;
    private void _0xb9020e6c()
    {
        _0x0a86433d _0x98e1be18 = this._0x8321ed62(this._0xc6a4b00c);
        if (_0x98e1be18 != null)
        {
            _0x98e1be18._0xf8923cfb(true);
        }
    }

    private bool _0xd6bb8d6b()
    {
        if (this._0x6dc572cf < 0 || this._0x40041d85.Length == 0)
        {
            return false;
        }

        int _0x4e6eb045 = (this._0x6dc572cf - 1 + this._0x40041d85.Length) % this._0x40041d85.Length;
        return this._0x40041d85[_0x4e6eb045] == this._0xc6a4b00c;
    }

    public int StepsDone => this._0x43093db3;
    public int ShownCrest => -1;

    private const float DwellSeconds = 0.42f;
    public void Finish()
    {
        if (this._0x6d571ba1 != null)
        {
            this._0x6d571ba1._0x71810f49();
        }

        this._0x6d571ba1 = null;
    }
}

internal static class _0x632c1233
{
    internal static string _0x8b8e5678(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}