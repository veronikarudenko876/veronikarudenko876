using TMPro;
using UnityEngine;

/// <summary>
/// Every asset the generated UI needs, held as SERIALIZED references and wired in both
/// scenes by {fileID, guid} - the one kind of link obfuscation cannot break.
///
/// THE NAMES ARE A FIXED CONTRACT, NOT A CHOICE. Since 26.10.2026 the art is drawn by Codex
/// from a prompt that does not read this project, and the file list is fixed:
/// bg_game, logo, icon_home, icon_pause, sprite_1..sprite_5 (plus two button plates this
/// game does not use). Inventing a name means the PNG never arrives, the guid resolves to
/// nothing, and Unity draws every Image that references it as a solid WHITE RECTANGLE -
/// with no build error. So the five sprites are given MEANING here, once, and the rest of
/// the code speaks in harbour terms.
///
/// Everything else this game draws - plates, frames, rings, bars, the close cross - uses the
/// built-in 9-slice UI sprite, which can never dangle.
/// </summary>
public sealed class _0xaed87db8 : MonoBehaviour
{
    [SerializeField]
    private Sprite _sprite2; // the stone mooring plate of a berth
    [SerializeField]
    private Sprite _sprite1; // the club pennant
    public Sprite _0x3a3815eb => this._sprite4;
    public Sprite _0x8aad929c => this._sprite3;
    public Sprite _0x00afe793 => this._sprite5;

    /// <summary>The palette colour a mark is tinted with, so two marks never read alike even
    /// at thumbnail size. Every one of these is a light colour, as C.14 requires.</summary>
    public Color _0x4ab30e69(int _0x5437a0f9)
    {
        switch (_0x5437a0f9)
        {
            case 0:
                return _0x857790a9.Lantern;
            case 1:
                return _0x857790a9.Foam;
            case 2:
                return _0x857790a9.TealLift;
            default:
                return _0x857790a9.Mist;
        }
    }

    [SerializeField]
    private Sprite _sprite5; // the keeper's badge
    [SerializeField]
    private Sprite _iconHome; // back to the harbour
    public Sprite _0x37d7a6c8 => this._iconPause;

    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private Sprite _sprite3; // the harbour lighthouse
    /// <summary>Unity's built-in 9-slice UI plate. Its border is 12 px, so the corner radius
    /// in canvas units is 12 / pixelsPerUnitMultiplier - that multiplier is the roundness
    /// lever for every surface this game draws.</summary>
    public Sprite _0x0f6a08a7 => this._roundPlate;

    [SerializeField]
    private Sprite _sprite4; // a hanging harbour lantern
    public Sprite _0x32988354 => this._sprite1;
    public int _0x1d446a9a => 4;
    public Sprite _0x93cf757b => this._iconHome;
    public Sprite _0x34fba6fe => this._sprite2;
    public TMP_FontAsset _0xed34cdf9 => this._font;

    [SerializeField]
    private Sprite _iconPause; // moor / pause
    /// <summary>
    /// The four crew marks a cargo plate can carry. They are the game's own objects seen
    /// again as emblems, which is why no extra art is ordered for them.
    /// </summary>
    public Sprite _0x9a3eb911(int _0x22a1a4fe)
    {
        switch (_0x22a1a4fe)
        {
            case 0:
                return this._sprite1;
            case 1:
                return this._sprite3;
            case 2:
                return this._sprite4;
            default:
                return this._sprite5;
        }
    }

    [SerializeField]
    private Sprite _roundPlate;
    public Sprite _0x39a19e84 => this._logo;

    [SerializeField]
    private Sprite _logo; // the abstract beacon mark (no letters)
}