using UnityEngine;

/// <summary>
/// SIGNAL RELAY. The lighthouse walks its beam over three berths, then the keeper repeats
/// the order. A wrong berth is not a failure - the plate ripples and the beam starts over.
/// </summary>
public sealed class _0x638ad6f9 : _0x4b8f06f9
{
    public int StepsNeeded => 3;

    public void BerthTapped(int _0x1afb159c)
    {
        if (this._0x8d999275 == null || this._0x19d53680 >= this._0xb0dbdd6e.Length)
        {
            return;
        }

        // While the beam is still showing the order, a tap simply cuts the replay short.
        if (this._0x9e71664b)
        {
            this._0x9e71664b = false;
            this._0xb1e96678 = -1;
        }

        _0x0a86433d _0xa112f882 = this._0x07fa7b52(_0x1afb159c);
        if (_0x1afb159c == this._0xb0dbdd6e[this._0x19d53680])
        {
            this._0x19d53680++;
            if (_0xa112f882 != null)
            {
                _0xa112f882._0x69e03faf(_0x857790a9.Teal, 0.3f);
            }

            return;
        }

        if (_0xa112f882 != null)
        {
            _0xa112f882._0xdd70072e();
        }

        this._0x19d53680 = 0;
        this._0xfdf9558a = 0f;
        this._0xb1e96678 = -1;
        this._0x9e71664b = true;
    }

    public int StepsDone => this._0x19d53680;

    public void Finish()
    {
        if (this._0x8d999275 != null)
        {
            this._0x8d999275._0x71810f49();
        }

        this._0x8d999275 = null;
    }

    public void Advance(float delta)
    {
        if (!this._0x9e71664b || this._0x8d999275 == null || this._0xb0dbdd6e.Length == 0)
        {
            return;
        }

        this._0xfdf9558a += delta;
        float _0x2a06bcec = LitSeconds + GapSeconds;
        int _0xdfa1ef06 = Mathf.FloorToInt(this._0xfdf9558a / _0x2a06bcec);
        if (_0xdfa1ef06 >= this._0xb0dbdd6e.Length)
        {
            this._0x9e71664b = false;
            this._0xb1e96678 = -1;
            return;
        }

        if (_0xdfa1ef06 != this._0xb1e96678)
        {
            this._0xb1e96678 = _0xdfa1ef06;
            _0x0a86433d _0x01940432 = this._0x07fa7b52(this._0xb0dbdd6e[_0xdfa1ef06]);
            if (_0x01940432 != null)
            {
                _0x01940432._0x69e03faf(_0x857790a9.Lantern, LitSeconds);
            }
        }
    }

    private int _0x19d53680;
    private int _0xb1e96678 = -1;
    private _0x0a86433d _0x07fa7b52(int _0xf7058811)
    {
        if (this._0x8d999275 == null || _0xf7058811 < 0 || _0xf7058811 >= this._0x8d999275._0xb15a11e0.Length)
        {
            return null;
        }

        return this._0x8d999275._0xb15a11e0[_0xf7058811];
    }

    public string Instruction => _0xac0464ef._0xb4ec9611(new byte[39] { 45, 59, 46, 57, 50, 90, 46, 50, 63, 90, 56, 63, 59, 55, 112, 46, 50, 63, 52, 90, 46, 59, 42, 90, 46, 50, 63, 90, 41, 59, 55, 63, 90, 56, 63, 40, 46, 50, 41 }, 122);

    private float _0xfdf9558a;
    public int AssistOneStep()
    {
        if (this._0x19d53680 >= this._0xb0dbdd6e.Length)
        {
            return -1;
        }

        int _0x0ebc9286 = this._0xb0dbdd6e[this._0x19d53680];
        this._0x9e71664b = false;
        this._0x19d53680++;
        _0x0a86433d _0x10cb8b48 = this._0x07fa7b52(_0x0ebc9286);
        if (_0x10cb8b48 != null)
        {
            _0x10cb8b48._0x69e03faf(_0x857790a9.Lantern, 0.45f);
        }

        return _0x0ebc9286;
    }

    private int[] _0xb0dbdd6e = new int[0];
    private const float LitSeconds = 0.55f;
    private bool _0x9e71664b = true;
    private const float GapSeconds = 0.25f;
    private _0x92b1008d _0x8d999275;
    public int ShownCrest => -1;

    public void Begin(_0x3ea7f588 _0x2b14d6ab, _0x92b1008d _0x21c1a3d3, _0xaed87db8 _0x96392549, System.Random _0x53ff1aac)
    {
        this._0x8d999275 = _0x21c1a3d3;
        this._0xb0dbdd6e = _0x2b14d6ab.SignalSequence;
        this._0x19d53680 = 0;
        this._0xfdf9558a = 0f;
        this._0xb1e96678 = -1;
        this._0x9e71664b = true;
    }
}

internal static class _0xac0464ef
{
    internal static string _0xb4ec9611(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}