using UnityEngine;

/// <summary>
/// CARGO SORT. Three berths carry a crest, the task card shows the one to match. Tapping the
/// matching plate clears it and deals a new trio; a wrong tap just shakes that token.
/// </summary>
public sealed class _0x30de3028 : _0x4b8f06f9
{
    private int _0x226a9726;
    private readonly int[] _0x899fb97b = new int[3];
    private _0x92b1008d _0xbe3c393b;
    public int StepsNeeded => 3;
    public int ShownCrest => this._0x226a9726;

    private void _0xe94d54c6()
    {
        if (this._0xbe3c393b == null || this._0x1a955093 == null)
        {
            return;
        }

        for (int _0x07123b24 = 0; _0x07123b24 < 3; _0x07123b24++)
        {
            int _0x4232b179 = this._0x5af2c12d[_0x07123b24];
            if (_0x4232b179 < 0 || _0x4232b179 >= this._0xbe3c393b._0xb15a11e0.Length)
            {
                continue;
            }

            _0x0a86433d _0xfb088291 = this._0xbe3c393b._0xb15a11e0[_0x4232b179];
            if (_0xfb088291 != null)
            {
                _0xfb088291._0x5eb7a3ea(this._0x1a955093._0x9a3eb911(this._0x899fb97b[_0x07123b24]));
            }
        }
    }

    private readonly int[] _0x5af2c12d = new int[3];
    public int StepsDone => this._0xd1b00b53;

    private int _0x655c1d25(int _0xdd1f72a9)
    {
        for (int _0x8e1542e6 = 0; _0x8e1542e6 < 3; _0x8e1542e6++)
        {
            if (this._0x5af2c12d[_0x8e1542e6] == _0xdd1f72a9)
            {
                return _0x8e1542e6;
            }
        }

        return -1;
    }

    private bool[] _0x3c06cec4 = new bool[_0x99c12d2e.BerthCount];
    public int AssistOneStep()
    {
        int _0x3f14d258 = this._0xab48775a();
        if (_0x3f14d258 < 0)
        {
            return -1;
        }

        _0x0a86433d _0x66766df7 = this._0xbe3c393b != null ? this._0xbe3c393b._0xb15a11e0[_0x3f14d258] : null;
        if (_0x66766df7 != null)
        {
            _0x66766df7._0x69e03faf(_0x857790a9.Lantern, 0.45f);
        }

        this._0xd1b00b53++;
        this._0x5a2f2bb8();
        return _0x3f14d258;
    }

    private int[] _0x54aa84c0()
    {
        int _0x7ce025a1 = 0;
        for (int _0x015bfce6 = 0; _0x015bfce6 < _0x99c12d2e.BerthCount; _0x015bfce6++)
        {
            if (!this._0xb81078b3(_0x015bfce6))
            {
                _0x7ce025a1++;
            }
        }

        int[] _0xc583dd87 = new int[_0x7ce025a1];
        int _0x7a78a159 = 0;
        for (int _0x0c49d004 = 0; _0x0c49d004 < _0x99c12d2e.BerthCount; _0x0c49d004++)
        {
            if (!this._0xb81078b3(_0x0c49d004))
            {
                _0xc583dd87[_0x7a78a159] = _0x0c49d004;
                _0x7a78a159++;
            }
        }

        return _0xc583dd87;
    }

    public void BerthTapped(int _0x495a4158)
    {
        if (this._0xbe3c393b == null)
        {
            return;
        }

        int _0x5bc8f5ef = this._0x655c1d25(_0x495a4158);
        if (_0x5bc8f5ef < 0)
        {
            return;
        }

        _0x0a86433d _0xdbcc8187 = this._0xbe3c393b._0xb15a11e0[_0x495a4158];
        if (this._0x899fb97b[_0x5bc8f5ef] != this._0x226a9726)
        {
            if (_0xdbcc8187 != null)
            {
                _0xdbcc8187._0x0d834c39();
            }

            return;
        }

        this._0xd1b00b53++;
        if (_0xdbcc8187 != null)
        {
            _0xdbcc8187._0x69e03faf(_0x857790a9.Teal, 0.3f);
        }

        this._0x5a2f2bb8();
    }

    public string Instruction => _0x7bc7c601._0x7820941c(new byte[37] { 66, 87, 70, 54, 66, 94, 83, 54, 84, 83, 68, 66, 94, 54, 65, 95, 66, 94, 28, 66, 94, 83, 54, 91, 87, 66, 85, 94, 95, 88, 81, 54, 85, 68, 83, 69, 66 }, 22);

    private _0xaed87db8 _0x1a955093;
    private System.Random _0x4e5d313a;
    private int _0xd1b00b53;
    public void Advance(float delta)
    {
    // Nothing in this activity is on a clock - it waits for the keeper.
    }

    private int _0xab48775a()
    {
        for (int _0x124be8bc = 0; _0x124be8bc < 3; _0x124be8bc++)
        {
            if (this._0x899fb97b[_0x124be8bc] == this._0x226a9726)
            {
                return this._0x5af2c12d[_0x124be8bc];
            }
        }

        return -1;
    }

    private void _0x5a2f2bb8()
    {
        if (this._0xbe3c393b != null)
        {
            this._0xbe3c393b._0xce37e2ff();
        }

        if (this._0xd1b00b53 >= this.StepsNeeded || this._0x4e5d313a == null)
        {
            return;
        }

        // A fresh trio on berths nobody has taken, with the new target guaranteed present.
        int[] _0xd3a5757e = this._0x54aa84c0();
        if (_0xd3a5757e.Length >= 3)
        {
            for (int _0xb71f9b4c = _0xd3a5757e.Length - 1; _0xb71f9b4c > 0; _0xb71f9b4c--)
            {
                int _0xfeb3802a = this._0x4e5d313a.Next(_0xb71f9b4c + 1);
                int _0x6d1782f2 = _0xd3a5757e[_0xb71f9b4c];
                _0xd3a5757e[_0xb71f9b4c] = _0xd3a5757e[_0xfeb3802a];
                _0xd3a5757e[_0xfeb3802a] = _0x6d1782f2;
            }

            for (int _0xe3042aab = 0; _0xe3042aab < 3; _0xe3042aab++)
            {
                this._0x5af2c12d[_0xe3042aab] = _0xd3a5757e[_0xe3042aab];
            }
        }

        this._0x226a9726 = this._0x4e5d313a.Next(this._0x540da78c);
        int _0x84587a84 = this._0x4e5d313a.Next(3);
        for (int _0x0f9d9297 = 0; _0x0f9d9297 < 3; _0x0f9d9297++)
        {
            if (_0x0f9d9297 == _0x84587a84)
            {
                this._0x899fb97b[_0x0f9d9297] = this._0x226a9726;
                continue;
            }

            int _0xba83d9d3 = this._0x4e5d313a.Next(this._0x540da78c);
            int _0x29cf494f = 0;
            while (_0xba83d9d3 == this._0x226a9726 && _0x29cf494f < 12)
            {
                _0xba83d9d3 = this._0x4e5d313a.Next(this._0x540da78c);
                _0x29cf494f++;
            }

            this._0x899fb97b[_0x0f9d9297] = _0xba83d9d3;
        }

        this._0xe94d54c6();
    }

    private int _0x540da78c = 4;
    public void Finish()
    {
        if (this._0xbe3c393b != null)
        {
            this._0xbe3c393b._0xce37e2ff();
        }

        this._0xbe3c393b = null;
    }

    private bool _0xb81078b3(int _0x1d7e53c3)
    {
        if (this._0x3c06cec4 != null && _0x1d7e53c3 < this._0x3c06cec4.Length && this._0x3c06cec4[_0x1d7e53c3])
        {
            return true;
        }

        _0x0a86433d _0xdf328b09 = this._0xbe3c393b != null && _0x1d7e53c3 < this._0xbe3c393b._0xb15a11e0.Length ? this._0xbe3c393b._0xb15a11e0[_0x1d7e53c3] : null;
        return _0xdf328b09 != null && _0xdf328b09._0x9bb40243;
    }

    public void Begin(_0x3ea7f588 _0xb34a38e9, _0x92b1008d _0x63b1375d, _0xaed87db8 _0x126bce72, System.Random _0x852261d9)
    {
        this._0xbe3c393b = _0x63b1375d;
        this._0x1a955093 = _0x126bce72;
        this._0x4e5d313a = _0x852261d9;
        this._0x540da78c = _0x126bce72 != null ? _0x126bce72._0x1d446a9a : 4;
        this._0xd1b00b53 = 0;
        this._0x3c06cec4 = _0xb34a38e9.Occupied;
        for (int _0xd19d0491 = 0; _0xd19d0491 < 3; _0xd19d0491++)
        {
            this._0x5af2c12d[_0xd19d0491] = _0xb34a38e9.SortBerths[_0xd19d0491];
            this._0x899fb97b[_0xd19d0491] = _0xb34a38e9.SortCrests[_0xd19d0491];
        }

        this._0x226a9726 = _0xb34a38e9.SortTarget;
        this._0xe94d54c6();
    }
}

internal static class _0x7bc7c601
{
    internal static string _0x7820941c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}