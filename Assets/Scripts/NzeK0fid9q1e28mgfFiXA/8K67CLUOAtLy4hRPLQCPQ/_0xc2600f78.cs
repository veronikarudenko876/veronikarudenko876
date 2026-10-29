using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0xc2600f78 : MonoBehaviour
{
    private Vector3 _0x28bf0dd2 { get; set; }
    private Vector3 _0xf54ae5cd { get; set; }
    private Vector3 _0x069ef8f6 { get; set; }

    private void Awake()
    {
        this._0x173ad017 = this.GetComponent<Camera>();
        _0x29b1c206 = this;
        this._0xafaac65b();
    }

    private static _0xc2600f78 _0x29b1c206;
    private Vector3 _0xd3ed83c0 { get; set; }

    private float _0xc7c8e388 = 1;
    private Color _0x10637ae5 = Color.white;
    private float _0x04e54e57 { get; set; }

    private _0xe350423b _0xaa06ec69 = _0xe350423b.Portrait;
    //public bool executeInUpdate;
    private float _0xf5f109a6 { get; set; }
    private Vector3 _0xae41c894 { get; set; }

    private new Camera _0x173ad017;
    public enum _0xe350423b
    {
        Landscape,
        Portrait
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x10637ae5;
        Matrix4x4 _0xcb85e0f6 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x173ad017.orthographic)
        {
            float _0x4a18f3ca = this._0x173ad017.farClipPlane - this._0x173ad017.nearClipPlane;
            float _0x1e2afb72 = (this._0x173ad017.farClipPlane + this._0x173ad017.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x1e2afb72), new Vector3(this._0x173ad017.orthographicSize * 2 * this._0x173ad017.aspect, this._0x173ad017.orthographicSize * 2, _0x4a18f3ca));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x173ad017.fieldOfView, this._0x173ad017.farClipPlane, this._0x173ad017.nearClipPlane, this._0x173ad017.aspect);
        }

        Gizmos.matrix = _0xcb85e0f6;
    }

    private Vector3 _0x65c5fa25 { get; set; }
    private Vector3 _0xf754270a { get; set; }

    private void _0xafaac65b()
    {
        float _0xfa1328d6, _0xe9508823, _0x0480936a, _0xdf48ff38;
        if (this._0xaa06ec69 == _0xe350423b.Landscape)
            this._0x173ad017.orthographicSize = 1f / this._0x173ad017.aspect * this._0xc7c8e388 / 2f;
        else
            this._0x173ad017.orthographicSize = this._0xc7c8e388 / 2f;
        this._0x04e54e57 = 2f * this._0x173ad017.orthographicSize;
        this._0xf5f109a6 = this._0x04e54e57 * this._0x173ad017.aspect;
        float _0xff2dc313 = this._0x173ad017.transform.position.x;
        float _0x867f004b = this._0x173ad017.transform.position.y;
        _0xfa1328d6 = _0xff2dc313 - this._0xf5f109a6 / 2;
        _0xe9508823 = _0xff2dc313 + this._0xf5f109a6 / 2;
        _0x0480936a = _0x867f004b + this._0x04e54e57 / 2;
        _0xdf48ff38 = _0x867f004b - this._0x04e54e57 / 2;
        this._0xae41c894 = new Vector3(_0xfa1328d6, _0xdf48ff38, 0);
        this._0xf54ae5cd = new Vector3(_0xff2dc313, _0xdf48ff38, 0);
        this._0x4d60321b = new Vector3(_0xe9508823, _0xdf48ff38, 0);
        this._0x069ef8f6 = new Vector3(_0xfa1328d6, _0x867f004b, 0);
        this._0xd3ed83c0 = new Vector3(_0xff2dc313, _0x867f004b, 0);
        this._0x65c5fa25 = new Vector3(_0xe9508823, _0x867f004b, 0);
        this._0x28bf0dd2 = new Vector3(_0xfa1328d6, _0x0480936a, 0);
        this._0x53af85d0 = new Vector3(_0xff2dc313, _0x0480936a, 0);
        this._0xf754270a = new Vector3(_0xe9508823, _0x0480936a, 0);
    }

    private Vector3 _0x53af85d0 { get; set; }
    private Vector3 _0x4d60321b { get; set; }
}