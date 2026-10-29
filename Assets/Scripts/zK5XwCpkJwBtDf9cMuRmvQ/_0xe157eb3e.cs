using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// One watch: three dockside activities in a seeded order, three steps each, a pennant on
/// the quay for every activity finished.
///
/// RUN LENGTH (C.5). The tide drains 0.55 a second from 100, so a watch with no input at
/// all lasts 182 seconds - three times the 60-second floor, and the meter is refilled by
/// the player's own work (+14 a flag). The capture window can therefore never photograph a
/// premature end card.
///
/// THE ASSIST is what makes the review album readable. A sequence-and-timing game cannot be
/// solved by a blind tap script, so after ASSIST_IDLE seconds with no tap the crew resolves
/// one step itself - visibly, with a caption and a lit berth. The idle timer resets on
/// EVERY tap, so a keeper who is actually playing never sees it.
///
/// There is no physics in this scene and none is wanted: a berth is a UGUI button.
/// </summary>
public sealed class _0xe157eb3e : MonoBehaviour
{
    private const float TideRefillPerFlag = 14f;
    private void Start()
    {
        if (this._art == null || _0xd705b3c4.Instance == null)
        {
            return;
        }

        _0xa6e3970b _0x6f50cdce = this._0xd933c3c7(_0xd9957943._0x23baba46.DEFAULT);
        if (_0x6f50cdce == null || _0x6f50cdce.Content == null)
        {
            return;
        }

        Transform _0xf5182fe7 = _0x6f50cdce.Content.transform;
        RectTransform _0x8ae2fcd7 = _0x253833cf.Stretch(_0xf5182fe7, _0x1974b224._0x159c4f08(new byte[10] { 147, 165, 176, 167, 172, 151, 176, 165, 163, 161 }, 196));
        _0x8ae2fcd7.SetAsLastSibling();
        // Rule H option 2: the template HUD is switched off wholesale and nothing of ours
        // hangs on it. TopPanel lives inside this very Content, so sparing our own stage by
        // REFERENCE (never by name) is enough to take the whole template bar away.
        for (int _0x78573258 = 0; _0x78573258 < _0xf5182fe7.childCount; _0x78573258++)
        {
            Transform _0x57ae931e = _0xf5182fe7.GetChild(_0x78573258);
            if (_0x57ae931e != _0x8ae2fcd7)
            {
                _0x57ae931e.gameObject.SetActive(false);
            }
        }

        _0x253833cf.Wash(_0x8ae2fcd7, _0x1974b224._0x159c4f08(new byte[9] { 225, 197, 209, 201, 227, 211, 194, 217, 221 }, 176), _0x857790a9.Tint(_0x857790a9.Ink, 0.34f));
        _0x253833cf.Picture(_0x8ae2fcd7, _0x1974b224._0x159c4f08(new byte[10] { 216, 253, 243, 252, 224, 252, 251, 225, 231, 241 }, 148), _0x253833cf.TopCentre, new Vector2(0f, -430f), 210f, this._art._0x8aad929c, _0x857790a9.Foam);
        this._0xe7070a1d = new _0x92b1008d()._0x963f25a0(_0x8ae2fcd7, this._art, _0x253833cf.TopCentre, new Vector2(0f, -BoardFromTop), BoardSize);
        this._0xbb378681 = new _0xd1f16883()._0x011de731(_0x8ae2fcd7, this._art, PanelHeight);
        this._0x06f5c185 = new _0xa6c5b1ee()._0xd28e815e(_0x8ae2fcd7, this._art);
        this._0xa72d3f47();
        this._0xa1cbae49();
    }

    private void _0x0f43fcea(int _0x1001e042)
    {
        if (!this._0x88e4098b || this._0x336a503a == null)
        {
            return;
        }

        this._0x8c5034ce = 0f;
        this._0x336a503a.BerthTapped(_0x1001e042);
        this._0x6b0a714f();
    }

    private void _0xb38b5230()
    {
        this._0x06f5c185._0x7faf7244(this._0x06f5c185._0x38603c26);
        _0x83b8da7d.Instance._0x37c24232(_0xd9957943._0x35830778.SCENE_0);
    }

    private bool _0x88e4098b;
    private readonly _0x4b8f06f9[] _0x7ca8d222 = new _0x4b8f06f9[3];
    /// <summary>One place where a step - however it was earned - turns into progress.</summary>
    private void _0x6b0a714f()
    {
        int _0xb50bc9d4 = this._0x336a503a.StepsDone;
        if (_0xb50bc9d4 != this._0x9e64c6c2)
        {
            this._0x9e64c6c2 = _0xb50bc9d4;
            this._0xbb378681._0x8477c182(_0xb50bc9d4);
        }

        if (_0xb50bc9d4 < this._0x336a503a.StepsNeeded)
        {
            return;
        }

        this._0x82220eef();
    }

    private _0x92b1008d _0xe7070a1d;
    private const float BoardSize = 1100f;
    /// <summary>Lay out a fresh watch from a seed nobody has used before.</summary>
    private void _0xa1cbae49()
    {
        int _0xd532022d = _0x99c12d2e._0x06417839;
        int _0x9449719f = _0x99c12d2e._0x8ddd3d0d + 1;
        _0x99c12d2e._0x8ddd3d0d = _0x9449719f;
        int _0xcd2568d2 = _0xc7ad14b8.SeedFor(_0xd532022d, _0x9449719f);
        this._0xae4cf775 = new System.Random(_0xcd2568d2);
#if B_LOGS
        Debug.Log(_0x1974b224._0x159c4f08(new byte[13] { 59, 23, 1, 20, 3, 8, 61, 64, 19, 5, 5, 4, 93 }, 96) + _0xcd2568d2.ToString());
#endif
        this._0xf2c99ccf = _0xc7ad14b8.Compose(_0xd532022d, _0x9449719f, this._art._0x1d446a9a, _0x99c12d2e._0xd64e3fc3);
        // The berths other keepers already hold get their pennant straight away, dimmed, so
        // the shared quay reads as shared from the first frame.
        for (int _0x324776df = 0; _0x324776df < _0x99c12d2e.BerthCount; _0x324776df++)
        {
            if (this._0xf2c99ccf.Occupied[_0x324776df] && this._0xe7070a1d._0xb15a11e0[_0x324776df] != null)
            {
                this._0xe7070a1d._0xb15a11e0[_0x324776df]._0x595db821(this._art._0x32988354, true);
            }
        }

        this._0x7ca8d222[0] = new _0x638ad6f9();
        this._0x7ca8d222[1] = new _0x30de3028();
        this._0x7ca8d222[2] = new _0x6c81b666();
        this._0xe7070a1d._0xe6fdc845(this._0xf2c99ccf.ShimmerPhase);
        this._0x841872f9 = 0;
        this._0x93c34899 = TideStart;
        this._0x8c5034ce = 0f;
        this._0xd221e6f6 = 0;
        this._0xd6a23881 = false;
        this._0x88e4098b = true;
        this._0x06f5c185._0x50359e10(0, _0x99c12d2e.FlagsPerWatch);
        this._0x06f5c185._0x53086e3d(1f);
        this._0xddb7bc7c();
    }

    private void _0x2d5571f2()
    {
        if (this._0xd6a23881)
        {
            return;
        }

        this._0x8c5034ce = 0f;
        this._0x88e4098b = true;
    }

    private int _0xd221e6f6;
    private _0x4b8f06f9 _0x336a503a;
    private void _0xddb7bc7c()
    {
        if (this._0x336a503a != null)
        {
            this._0x336a503a.Finish();
        }

        if (this._0xd221e6f6 >= this._0xf2c99ccf.ActivityOrder.Length)
        {
            this._0x4d146c72();
            return;
        }

        this._0x336a503a = this._0x7ca8d222[this._0xf2c99ccf.ActivityOrder[this._0xd221e6f6]];
        this._0x336a503a.Begin(this._0xf2c99ccf, this._0xe7070a1d, this._art, this._0xae4cf775);
        this._0x9e64c6c2 = 0;
        this._0x8c5034ce = 0f;
        this._0xbb378681._0x9d0dbc1e(this._0xd221e6f6 + 1, this._0xf2c99ccf.ActivityOrder.Length, this._0x336a503a.Instruction, this._0x336a503a.ShownCrest);
    }

    private _0xd1f16883 _0xbb378681;
    private _0xa6e3970b _0xd933c3c7(int _0xe79e8b73)
    {
        if (_0xd705b3c4.Instance == null || _0xd705b3c4.Instance.Panels == null)
        {
            return null;
        }

        if (_0xe79e8b73 < 0 || _0xe79e8b73 >= _0xd705b3c4.Instance.Panels.Count)
        {
            return null;
        }

        return _0xd705b3c4.Instance.Panels[_0xe79e8b73];
    }

    private void OnDestroy()
    {
        if (this._0xe7070a1d != null)
        {
            this._0xe7070a1d._0x4b95c86b();
        }

        if (this._0xbb378681 != null)
        {
            this._0xbb378681._0x72b9ed3e();
        }

        if (this._0x06f5c185 != null)
        {
            this._0x06f5c185._0xb2f5aa49();
        }
    }

    private void _0x82220eef()
    {
        int _0x28dd25cb = this._0xf2c99ccf._0x04f90020(this._0x6b88bde2);
        if (_0x28dd25cb >= 0)
        {
            this._0x6b88bde2[_0x28dd25cb] = true;
            _0x0a86433d _0xf1b7d008 = this._0xe7070a1d._0xb15a11e0[_0x28dd25cb];
            if (_0xf1b7d008 != null)
            {
                _0xf1b7d008._0x595db821(this._art._0x32988354, false);
            }
        }

        this._0x841872f9++;
        this._0x93c34899 = Mathf.Min(TideStart, this._0x93c34899 + TideRefillPerFlag);
        this._0x06f5c185._0x50359e10(this._0x841872f9, _0x99c12d2e.FlagsPerWatch);
        this._0x06f5c185._0x53086e3d(this._0x93c34899 / TideStart);
        this._0xd221e6f6++;
        this._0xddb7bc7c();
    }

    private void _0xa72d3f47()
    {
        for (int _0xa3e4f98f = 0; _0xa3e4f98f < this._0xe7070a1d._0xb15a11e0.Length; _0xa3e4f98f++)
        {
            int _0x29e0355e = _0xa3e4f98f;
            _0x0a86433d _0x573521a4 = this._0xe7070a1d._0xb15a11e0[_0xa3e4f98f];
            if (_0x573521a4 != null && _0x573521a4._0x6be5a7ab != null)
            {
                _0x573521a4._0x6be5a7ab.onClick.AddListener(() => this._0x0f43fcea(_0x29e0355e));
            }
        }

        if (this._0x06f5c185._0x38603c26 != null)
        {
            this._0x06f5c185._0x38603c26.onClick.AddListener(() => this._0xb38b5230());
        }

        if (this._0x06f5c185._0x6ca53d89 != null)
        {
            this._0x06f5c185._0x6ca53d89.onClick.AddListener(() => this._0x8a18e070());
        }

        if (this._pops != null)
        {
            this._pops._0xcab4010c(() => this._0x2d5571f2());
        }
    }

    private const float BoardFromTop = 1160f;
    private const float AssistIdleLate = 3.5f;
    private float _0x8c5034ce;
    /// <summary>The watch is done: log it and show what it contributed.</summary>
    private void _0x4d146c72()
    {
        if (this._0xd6a23881)
        {
            return;
        }

        this._0xd6a23881 = true;
        this._0x88e4098b = false;
        _0x99c12d2e.RecordWatch(this._0x841872f9);
        if (this._pops != null)
        {
            this._pops._0x982c66b9(this._0x841872f9, _0x99c12d2e._0xd64e3fc3);
        }
    }

    private int _0x841872f9;
    private float _0x93c34899 = TideStart;
    private System.Random _0xae4cf775;
    private void _0x8a18e070()
    {
        if (this._0xd6a23881)
        {
            return;
        }

        this._0x06f5c185._0x7faf7244(this._0x06f5c185._0x6ca53d89);
        this._0x88e4098b = false;
        if (this._pops != null)
        {
            this._pops._0x5267c874(this._0x841872f9, this._0x93c34899 / TideStart);
        }
    }

    private const float TideDrainPerSecond = 0.55f;
    private _0x3ea7f588 _0xf2c99ccf;
    private const float AssistIdleEarly = 5f;
    private _0xa6c5b1ee _0x06f5c185;
    private readonly bool[] _0x6b88bde2 = new bool[_0x99c12d2e.BerthCount];
    private const float PanelHeight = 2688f;
    private const float TideStart = 100f;
    [SerializeField]
    private _0xdd00bb9b _pops;
    private bool _0xd6a23881;
    private void Update()
    {
        if (!this._0x88e4098b || this._0x336a503a == null)
        {
            return;
        }

        float delta = Time.deltaTime;
        this._0x336a503a.Advance(delta);
        this._0x8c5034ce += delta;
        this._0x93c34899 -= TideDrainPerSecond * delta;
        if (this._0x93c34899 <= 0f)
        {
            this._0x93c34899 = 0f;
            this._0xb6357cc3();
            return;
        }

        float _0x169648c0 = this._0x841872f9 >= 2 ? AssistIdleLate : AssistIdleEarly;
        if (this._0x8c5034ce >= _0x169648c0)
        {
            this._0x8c5034ce = 0f;
            int _0x1a97840e = this._0x336a503a.AssistOneStep();
            if (_0x1a97840e >= 0)
            {
                this._0xbb378681._0x31602348();
                this._0x6b0a714f();
            }
        }
    }

    /// <summary>The tide ran out. A soft close - the brief has no losing.</summary>
    private void _0xb6357cc3()
    {
        if (this._0xd6a23881)
        {
            return;
        }

        this._0xd6a23881 = true;
        this._0x88e4098b = false;
        _0x99c12d2e.RecordWatch(this._0x841872f9);
        if (this._pops != null)
        {
            this._pops._0x055f2d04(this._0x841872f9);
        }
    }

    private int _0x9e64c6c2;
    [SerializeField]
    private _0xaed87db8 _art;
}

internal static class _0x1974b224
{
    internal static string _0x159c4f08(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}