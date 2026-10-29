using UnityEngine;

/// <summary>
/// Everything one watch is laid out from. No constructor anywhere: the object is built with
/// field initialisers and an Init that returns itself (CLAUDE-unity.md C.59).
/// </summary>
public sealed class _0x3ea7f588
{
    public int _0x3bd0a64b
    {
        get
        {
            int _0xd75b8105 = 0;
            for (int _0xfe3cb288 = 0; _0xfe3cb288 < this.Occupied.Length; _0xfe3cb288++)
            {
                if (!this.Occupied[_0xfe3cb288])
                {
                    _0xd75b8105++;
                }
            }

            return _0xd75b8105;
        }
    }

    public _0x3ea7f588 _0x9aa8ed3d(int[] _0x778160e7, int[] _0x2c57e1c7, int[] _0x5a5326d8, int[] _0xeb38a127, int _0x8a8ebcee, int _0xacfeaa41, int _0x7cec296a, int _0x2ad57d6b, bool[] _0x379c3962, int[] _0x723f1b7c, float _0x0bb7efd8)
    {
        this.ActivityOrder = _0x778160e7;
        this.SignalSequence = _0x2c57e1c7;
        this.SortBerths = _0x5a5326d8;
        this.SortCrests = _0xeb38a127;
        this.SortTarget = _0x8a8ebcee;
        this.TideMarked = _0xacfeaa41;
        this.TideCorner = _0x7cec296a;
        this.TideDirection = _0x2ad57d6b;
        this.Occupied = _0x379c3962;
        this.GoldLanterns = _0x723f1b7c;
        this.ShimmerPhase = _0x0bb7efd8;
        return this;
    }

    public int[] SortBerths = new int[3];
    /// <summary>The next berth with no pennant on it, or -1 when the quay is full.</summary>
    public int _0x04f90020(bool[] _0xcbf5e97d)
    {
        for (int _0x3a85e43f = 0; _0x3a85e43f < this.Occupied.Length; _0x3a85e43f++)
        {
            if (!this.Occupied[_0x3a85e43f] && !_0xcbf5e97d[_0x3a85e43f])
            {
                return _0x3a85e43f;
            }
        }

        return -1;
    }

    public int TideCorner;
    public int TideDirection = 1;
    public float ShimmerPhase;
    public int[] GoldLanterns = new int[2];
    public int SortTarget;
    public int[] SignalSequence = new int[3];
    public bool[] Occupied = new bool[_0x99c12d2e.BerthCount];
    public int[] ActivityOrder = new int[3];
    public int TideMarked;
    public int[] SortCrests = new int[3];
}

/// <summary>
/// Seeded layout generation (CLAUDE-unity.md C.11). Two consecutive watches differ in the
/// activity order, the signal sequence, the cargo deal, the tide route and which berths the
/// rest of the crew already took - not merely in a HUD number.
///
/// System.Random, never UnityEngine.Random: the latter is global state and two systems
/// drawing from it stop meaning "the same seed".
/// </summary>
public static class _0xc7ad14b8
{
    /// <summary>The guaranteed layout, used only when twenty draws all missed.</summary>
    public static _0x3ea7f588 Fallback(int _0x0cb48935)
    {
        int[] _0x8f99829f =
        {
            0,
            1,
            2
        };
        int[] _0x165d3d9e =
        {
            0,
            4,
            8
        };
        int[] _0x22961d04 =
        {
            1,
            5,
            6
        };
        int _0xfe798e1b = 0 % Mathf.Max(1, _0x0cb48935);
        int[] _0xd6c924e2 =
        {
            _0xfe798e1b,
            1 % Mathf.Max(1, _0x0cb48935),
            2 % Mathf.Max(1, _0x0cb48935)
        };
        bool[] _0x740ff31c = new bool[_0x99c12d2e.BerthCount];
        _0x740ff31c[2] = true;
        _0x740ff31c[3] = true;
        int[] _0xe8bfa6e3 =
        {
            0,
            8
        };
        return new _0x3ea7f588()._0x9aa8ed3d(_0x8f99829f, _0x165d3d9e, _0x22961d04, _0xd6c924e2, _0xfe798e1b, 4, 0, 1, _0x740ff31c, _0xe8bfa6e3, 0f);
    }

    /// <summary>
    /// A layout is playable when the keeper can still place three pennants and no activity
    /// asks for a berth another keeper already holds.
    /// </summary>
    public static bool IsPlayable(_0x3ea7f588 _0xdfc7bbde)
    {
        if (_0xdfc7bbde == null || _0xdfc7bbde._0x3bd0a64b < _0x99c12d2e.FlagsPerWatch)
        {
            return false;
        }

        for (int _0x4c4a31e2 = 0; _0x4c4a31e2 < _0xdfc7bbde.SignalSequence.Length; _0x4c4a31e2++)
        {
            if (_0xdfc7bbde.Occupied[_0xdfc7bbde.SignalSequence[_0x4c4a31e2]])
            {
                return false;
            }
        }

        for (int _0x5eddc97f = 0; _0x5eddc97f < _0xdfc7bbde.SortBerths.Length; _0x5eddc97f++)
        {
            if (_0xdfc7bbde.Occupied[_0xdfc7bbde.SortBerths[_0x5eddc97f]])
            {
                return false;
            }
        }

        if (_0xdfc7bbde.Occupied[_0xdfc7bbde.TideMarked])
        {
            return false;
        }

        // The cargo deal must actually contain the crest the card asks for.
        bool _0xb71ad13c = false;
        for (int _0xb798bb7b = 0; _0xb798bb7b < _0xdfc7bbde.SortCrests.Length; _0xb798bb7b++)
        {
            if (_0xdfc7bbde.SortCrests[_0xb798bb7b] == _0xdfc7bbde.SortTarget)
            {
                _0xb71ad13c = true;
            }
        }

        if (!_0xb71ad13c)
        {
            return false;
        }

        // Three distinct cargo berths, or two tokens would sit on one plate.
        if (_0xdfc7bbde.SortBerths[0] == _0xdfc7bbde.SortBerths[1] || _0xdfc7bbde.SortBerths[1] == _0xdfc7bbde.SortBerths[2] || _0xdfc7bbde.SortBerths[0] == _0xdfc7bbde.SortBerths[2])
        {
            return false;
        }

        return true;
    }

    private static _0x3ea7f588 Draw(System.Random _0xcf43659d, int _0x5fe6060a, int _0xc2267b50)
    {
        int[] _0x302f91f7 =
        {
            0,
            1,
            2
        };
        Shuffle(_0x302f91f7, _0xcf43659d);
        // Other keepers already hold up to four berths, so at least five stay open - the
        // watch needs three of them for its own pennants.
        bool[] _0x56a5f5e6 = new bool[_0x99c12d2e.BerthCount];
        int _0x5efe6434 = Mathf.Clamp(_0xc2267b50, 0, 4);
        int[] _0xa6338bea = FreshPool();
        Shuffle(_0xa6338bea, _0xcf43659d);
        for (int _0x4e9fc4dd = 0; _0x4e9fc4dd < _0x5efe6434; _0x4e9fc4dd++)
        {
            _0x56a5f5e6[_0xa6338bea[_0x4e9fc4dd]] = true;
        }

        int[] _0x9fb36551 = OpenList(_0x56a5f5e6);
        // SIGNAL: three open berths, never the same one twice in a row.
        int[] _0xf6b36248 = new int[3];
        _0xf6b36248[0] = _0x9fb36551[_0xcf43659d.Next(_0x9fb36551.Length)];
        for (int _0x78dc8683 = 1; _0x78dc8683 < 3; _0x78dc8683++)
        {
            int _0x39bb573b = _0x9fb36551[_0xcf43659d.Next(_0x9fb36551.Length)];
            int _0x8be0397f = 0;
            while (_0x39bb573b == _0xf6b36248[_0x78dc8683 - 1] && _0x8be0397f < 12)
            {
                _0x39bb573b = _0x9fb36551[_0xcf43659d.Next(_0x9fb36551.Length)];
                _0x8be0397f++;
            }

            _0xf6b36248[_0x78dc8683] = _0x39bb573b;
        }

        // CARGO: three distinct open berths, one of which carries the crest to match.
        int[] _0xabdca4eb = (int[])_0x9fb36551.Clone();
        Shuffle(_0xabdca4eb, _0xcf43659d);
        int[] _0x3b2e0bfe =
        {
            _0xabdca4eb[0],
            _0xabdca4eb[1 % _0xabdca4eb.Length],
            _0xabdca4eb[2 % _0xabdca4eb.Length]
        };
        int[] _0x12a63451 = new int[3];
        int _0xca54fef7 = _0xcf43659d.Next(_0x5fe6060a);
        int _0xa8c62638 = _0xcf43659d.Next(3);
        for (int _0x5913ff46 = 0; _0x5913ff46 < 3; _0x5913ff46++)
        {
            int _0x5a9b9b50 = _0xcf43659d.Next(_0x5fe6060a);
            int _0xf69a8360 = 0;
            while (_0x5a9b9b50 == _0xca54fef7 && _0x5913ff46 != _0xa8c62638 && _0xf69a8360 < 12)
            {
                _0x5a9b9b50 = _0xcf43659d.Next(_0x5fe6060a);
                _0xf69a8360++;
            }

            _0x12a63451[_0x5913ff46] = _0x5913ff46 == _0xa8c62638 ? _0xca54fef7 : _0x5a9b9b50;
        }

        // TIDE: a marked open berth, one of four serpentine corners, either direction.
        int _0x64c19354 = _0x9fb36551[_0xcf43659d.Next(_0x9fb36551.Length)];
        int _0x8ba4ccc6 = _0xcf43659d.Next(4);
        int _0xf89ded89 = _0xcf43659d.Next(2) == 0 ? 1 : -1;
        int[] _0xc50563ac =
        {
            _0xcf43659d.Next(_0x99c12d2e.BerthCount),
            _0xcf43659d.Next(_0x99c12d2e.BerthCount)
        };
        float _0xcb75ce7c = (float)_0xcf43659d.NextDouble() * 6.2831f;
        return new _0x3ea7f588()._0x9aa8ed3d(_0x302f91f7, _0xf6b36248, _0x3b2e0bfe, _0x12a63451, _0xca54fef7, _0x64c19354, _0x8ba4ccc6, _0xf89ded89, _0x56a5f5e6, _0xc50563ac, _0xcb75ce7c);
    }

    public static int SeedFor(int _0xcc12af27, int _0xdd87c420)
    {
        return (_0xcc12af27 * 7919) ^ (_0xdd87c420 * 104729);
    }

    /// <summary>Generate, prove it is playable, and only then hand it over. Falls back to a
    /// constant layout after <see cref = "Attempts"/> misses - the fallback stays a fallback.</summary>
    public static _0x3ea7f588 Compose(int _0x0f3b3e45, int _0xb9720d81, int _0xa12a2dee, int _0x1a0966e1)
    {
        System.Random _0xf38cb9d9 = new System.Random(SeedFor(_0x0f3b3e45, _0xb9720d81));
        _0x3ea7f588 _0x151b2a1a = null;
        for (int _0x0175c18b = 0; _0x0175c18b < Attempts; _0x0175c18b++)
        {
            _0x151b2a1a = Draw(_0xf38cb9d9, _0xa12a2dee, _0x1a0966e1);
            if (IsPlayable(_0x151b2a1a))
            {
                return _0x151b2a1a;
            }
        }

        return Fallback(_0xa12a2dee);
    }

    private static void Shuffle(int[] _0x22e39166, System.Random _0x2b45a2bb)
    {
        for (int _0x4268c03e = _0x22e39166.Length - 1; _0x4268c03e > 0; _0x4268c03e--)
        {
            int _0x7cee3835 = _0x2b45a2bb.Next(_0x4268c03e + 1);
            int _0xa8eb01e5 = _0x22e39166[_0x4268c03e];
            _0x22e39166[_0x4268c03e] = _0x22e39166[_0x7cee3835];
            _0x22e39166[_0x7cee3835] = _0xa8eb01e5;
        }
    }

    private static int[] OpenList(bool[] _0xf0878bd5)
    {
        int _0x5569bcb1 = 0;
        for (int _0x32aeb287 = 0; _0x32aeb287 < _0xf0878bd5.Length; _0x32aeb287++)
        {
            if (!_0xf0878bd5[_0x32aeb287])
            {
                _0x5569bcb1++;
            }
        }

        int[] _0xeca534ae = new int[_0x5569bcb1];
        int _0xee947f58 = 0;
        for (int _0x9799e1bc = 0; _0x9799e1bc < _0xf0878bd5.Length; _0x9799e1bc++)
        {
            if (!_0xf0878bd5[_0x9799e1bc])
            {
                _0xeca534ae[_0xee947f58] = _0x9799e1bc;
                _0xee947f58++;
            }
        }

        return _0xeca534ae;
    }

    private static int[] FreshPool()
    {
        int[] _0x9d34491e = new int[_0x99c12d2e.BerthCount];
        for (int _0xd397b958 = 0; _0xd397b958 < _0x9d34491e.Length; _0xd397b958++)
        {
            _0x9d34491e[_0xd397b958] = _0xd397b958;
        }

        return _0x9d34491e;
    }

    /// <summary>
    /// The route the tide pulse walks, as berth indices.
    ///
    /// <paramref name = "direction"/> picks the AXIS, not a reversal: walking the same
    /// serpentine backwards is the same walk seen from the opposite corner, which would
    /// collapse the eight combinations to four. Row-major against column-major keeps all
    /// eight genuinely distinct (measured, not assumed).
    /// </summary>
    public static int[] TideRoute(int _0x0eb65a71, int _0x67d55e9b)
    {
        int[] _0x9967d3c3 = new int[_0x99c12d2e.BerthCount];
        int _0x184cfa4e = 0;
        if (_0x67d55e9b > 0)
        {
            for (int _0xda19d626 = 0; _0xda19d626 < 3; _0xda19d626++)
            {
                for (int _0xd61548a7 = 0; _0xd61548a7 < 3; _0xd61548a7++)
                {
                    int _0x8bc05017 = (_0xda19d626 % 2 == 0) ? _0xd61548a7 : 2 - _0xd61548a7;
                    _0x9967d3c3[_0x184cfa4e] = (_0xda19d626 * 3) + _0x8bc05017;
                    _0x184cfa4e++;
                }
            }
        }
        else
        {
            for (int _0xa2d604b5 = 0; _0xa2d604b5 < 3; _0xa2d604b5++)
            {
                for (int _0xea145a6c = 0; _0xea145a6c < 3; _0xea145a6c++)
                {
                    int _0x1921c183 = (_0xa2d604b5 % 2 == 0) ? _0xea145a6c : 2 - _0xea145a6c;
                    _0x9967d3c3[_0x184cfa4e] = (_0x1921c183 * 3) + _0xa2d604b5;
                    _0x184cfa4e++;
                }
            }
        }

        // Corner 1 and 3 mirror horizontally, 2 and 3 mirror vertically.
        for (int _0x86de8d27 = 0; _0x86de8d27 < _0x9967d3c3.Length; _0x86de8d27++)
        {
            int _0x34962504 = _0x9967d3c3[_0x86de8d27] / 3;
            int _0x45241fb8 = _0x9967d3c3[_0x86de8d27] % 3;
            if (_0x0eb65a71 == 1 || _0x0eb65a71 == 3)
            {
                _0x45241fb8 = 2 - _0x45241fb8;
            }

            if (_0x0eb65a71 == 2 || _0x0eb65a71 == 3)
            {
                _0x34962504 = 2 - _0x34962504;
            }

            _0x9967d3c3[_0x86de8d27] = (_0x34962504 * 3) + _0x45241fb8;
        }

        return _0x9967d3c3;
    }

    public const int Attempts = 20;
}