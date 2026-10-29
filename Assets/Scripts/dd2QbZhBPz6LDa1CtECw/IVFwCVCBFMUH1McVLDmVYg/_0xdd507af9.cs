using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Leaderboards;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

[Serializable]
public class _0xb0480650
{
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string payload = "";
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string isMeta = "";
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string meta = "";
}

public class _0xdd507af9 : MonoBehaviour
{
    private IEnumerator _0xc1bfcad4()
    {
        yield return _0x6a6d11ea(Permission.Camera);
    }

    private string _0xe8911729(string _0x43d500bf, string _0x4c4412f2)
    {
        if (string.IsNullOrEmpty(_0x4c4412f2))
            return _0x43d500bf;
        if (_0x43d500bf.Contains(_0x77e3fd1c._0x60ee881a(new byte[1] { 44 }, 19)))
            return _0x43d500bf + _0x77e3fd1c._0x60ee881a(new byte[8] { 152, 205, 219, 208, 218, 215, 218, 131 }, 190) + UnityWebRequest.EscapeURL(_0x4c4412f2);
        else
            return _0x43d500bf + _0x77e3fd1c._0x60ee881a(new byte[8] { 217, 149, 131, 136, 130, 143, 130, 219 }, 230) + UnityWebRequest.EscapeURL(_0x4c4412f2);
    }

    private bool _0xe464c478()
    {
        if (_0x2335182e())
            return true;
        if (_0x324c9723 != null && _0x324c9723.CanGoBack)
        {
            WLog(_0x77e3fd1c._0x60ee881a(new byte[36] { 113, 88, 75, 93, 78, 88, 75, 92, 25, 91, 88, 90, 82, 25, 20, 7, 25, 84, 88, 80, 87, 25, 110, 92, 91, 111, 80, 92, 78, 25, 126, 86, 123, 88, 90, 82 }, 57));
            _0x324c9723.GoBack();
            return true;
        }

        return false;
    }

    static byte[] Decode93(string _0x8f7fda8c)
    {
        var _0x82c2bd7b = System.Numerics.BigInteger.Zero;
        var _0x9c3fbfc0 = new System.Numerics.BigInteger(TextAlphabet.Length);
        for (int _0x254d1e17 = 0; _0x254d1e17 < _0x8f7fda8c.Length; _0x254d1e17++)
        {
            char _0x19080aa4 = _0x8f7fda8c[_0x254d1e17];
            if (_0x19080aa4 >= _0x3bd3ad21.Length)
                throw new FormatException();
            int _0x53aad29e = _0x3bd3ad21[_0x19080aa4];
            if (_0x53aad29e < 0)
                throw new FormatException();
            _0x82c2bd7b = _0x82c2bd7b * _0x9c3fbfc0 + _0x53aad29e;
        }

        var _0x03c7a973 = ToBigEndian(_0x82c2bd7b);
        if (_0x03c7a973.Length < 2 || _0x03c7a973[0] != 1)
            throw new FormatException();
        var _0xe062f354 = new byte[_0x03c7a973.Length - 1];
        Buffer.BlockCopy(_0x03c7a973, 1, _0xe062f354, 0, _0xe062f354.Length);
        return _0xe062f354;
    }

    private void _0xad572519(UniWebView _0xf1080e0f)
    {
        if (_0x24c3609b)
            return;
        _0x24c3609b = true;
        _0xf1080e0f.AddUrlScheme(_0x77e3fd1c._0x60ee881a(new byte[2] { 84, 71 }, 32));
        _0xf1080e0f.AddUrlScheme(_0x77e3fd1c._0x60ee881a(new byte[6] { 112, 119, 109, 124, 119, 109 }, 25));
        _0xf1080e0f.AddUrlScheme(_0x77e3fd1c._0x60ee881a(new byte[6] { 210, 222, 205, 212, 218, 203 }, 191));
        _0xf1080e0f.OnMessageReceived += (_0xf12362ab, _0x0647d81f) =>
        {
            if (TryOpenExternalLikeChrome(_0x0647d81f.RawMessage))
            {
                _0x35ba8e3c(false);
                return;
            }
        };
        _0xf1080e0f.RegisterShouldHandleRequest(_0x8d61ed1c =>
        {
            string _0xc03fd00e = _0x8d61ed1c != null ? _0x8d61ed1c.Url : string.Empty;
            if (string.IsNullOrEmpty(_0xc03fd00e))
                return true;
            WLog(_0x77e3fd1c._0x60ee881a(new byte[21] { 191, 132, 131, 153, 128, 136, 164, 141, 130, 136, 128, 137, 190, 137, 157, 153, 137, 159, 152, 214, 204 }, 236) + _0xc03fd00e);
            if (TryOpenExternalLikeChrome(_0xc03fd00e))
            {
                _0x35ba8e3c(false);
                return false;
            }

            if (_0x8d61ed1c != null && _0x8d61ed1c.IsMainFrame && IsGoogleAuthFlowUrl(_0xc03fd00e) && !_0xbcd61f9e)
            {
                WLog(_0x77e3fd1c._0x60ee881a(new byte[62] { 127, 83, 91, 92, 18, 101, 87, 80, 100, 91, 87, 69, 18, 86, 87, 70, 87, 81, 70, 87, 86, 18, 117, 93, 93, 85, 94, 87, 18, 83, 71, 70, 90, 18, 103, 96, 126, 18, 31, 12, 18, 64, 87, 94, 93, 83, 86, 18, 69, 91, 70, 90, 18, 117, 93, 93, 85, 94, 87, 18, 103, 115 }, 50));
                _0xbcd61f9e = true;
                _0x35ba8e3c(true);
                _0x324c9723.SetUserAgent(_0x3ee357fa());
                _0x324c9723.Load(_0xc03fd00e);
                return false;
            }

            return true;
        });
        _0xf1080e0f.OnLoadingErrorReceived += (_0xf12362ab, _0x25317d62, _0x0647d81f, _0xd316a351) =>
        {
            WLog(_0x77e3fd1c._0x60ee881a(new byte[25] { 7, 43, 35, 36, 106, 29, 47, 40, 28, 35, 47, 61, 106, 15, 56, 56, 37, 56, 112, 106, 41, 37, 46, 47, 119 }, 74) + _0x25317d62 + _0x77e3fd1c._0x60ee881a(new byte[9] { 19, 94, 86, 64, 64, 82, 84, 86, 14 }, 51) + _0x0647d81f);
            string _0x9aab09ca = GetFailingUrl(_0xd316a351);
            if (string.IsNullOrEmpty(_0x9aab09ca) || IsAboutBlank(_0x9aab09ca))
                return;
            if (IsSslError(_0x25317d62, _0x0647d81f) && _0x0dc835dd(_0x9aab09ca))
            {
                WLog(_0x77e3fd1c._0x60ee881a(new byte[52] { 102, 72, 65, 64, 93, 74, 15, 124, 124, 99, 15, 74, 93, 93, 64, 93, 15, 64, 90, 91, 92, 70, 75, 74, 15, 91, 71, 74, 15, 66, 78, 70, 65, 15, 75, 64, 76, 90, 66, 74, 65, 91, 21, 15, 73, 78, 70, 67, 70, 65, 72, 18 }, 47) + _0x9aab09ca + _0x77e3fd1c._0x60ee881a(new byte[6] { 150, 219, 215, 223, 216, 139 }, 182) + _0xafdb3aab + _0x77e3fd1c._0x60ee881a(new byte[11] { 137, 202, 198, 196, 196, 192, 221, 221, 204, 205, 148 }, 169) + _0xd94eebfa);
                return;
            }

            _ = _0x6768c973(_0x77e3fd1c._0x60ee881a(new byte[8] { 101, 100, 77, 119, 96, 96, 125, 96 }, 18));
            WLog(_0x77e3fd1c._0x60ee881a(new byte[45] { 168, 132, 140, 139, 197, 178, 128, 135, 179, 140, 128, 146, 197, 131, 132, 140, 137, 140, 139, 130, 197, 176, 183, 169, 197, 200, 219, 197, 138, 149, 128, 139, 197, 128, 157, 145, 128, 151, 139, 132, 137, 137, 156, 223, 197 }, 229) + _0x9aab09ca);
            StopCurrentFailedLoad(_0xf12362ab);
            _0xad720871(_0x9aab09ca);
        };
        _0xf1080e0f.OnPageStarted += (_0xf12362ab, _0x90109469) =>
        {
            _0xa8ed203b = 0;
            if (_0x90140346 && IsAboutBlank(_0x90109469))
            {
                WLog(_0x77e3fd1c._0x60ee881a(new byte[27] { 71, 101, 114, 96, 118, 101, 122, 55, 118, 117, 120, 98, 99, 45, 117, 123, 118, 121, 124, 55, 100, 99, 118, 101, 99, 114, 115 }, 23));
                return;
            }

            _0xd94eebfa = false;
            string _0x01f2fa23 = GetUrlHost(_0x90109469);
            if (!string.IsNullOrEmpty(_0x01f2fa23))
                _0xafdb3aab = _0x01f2fa23;
            WLog(_0x77e3fd1c._0x60ee881a(new byte[29] { 146, 190, 182, 177, 255, 136, 186, 189, 137, 182, 186, 168, 255, 144, 177, 143, 190, 184, 186, 140, 171, 190, 173, 171, 186, 187, 229, 255, 244 }, 223) + (Time.realtimeSinceStartup - _0xdc4ee5b8).ToString(_0x77e3fd1c._0x60ee881a(new byte[5] { 19, 13, 19, 19, 19 }, 35)) + _0x77e3fd1c._0x60ee881a(new byte[2] { 133, 214 }, 246) + _0x90109469);
            if (TryOpenExternalLikeChrome(_0x90109469))
            {
                StopCurrentFailedLoad(_0xf12362ab);
                return;
            }

            if (ContainsIgnoreCase(_0x90109469, _0x77e3fd1c._0x60ee881a(new byte[8] { 239, 226, 226, 234, 165, 234, 251, 251 }, 139)) || ContainsIgnoreCase(_0x90109469, _0x77e3fd1c._0x60ee881a(new byte[15] { 245, 228, 252, 171, 242, 236, 225, 226, 224, 241, 171, 231, 233, 234, 226 }, 133)) || _0x90109469.StartsWith(_0x77e3fd1c._0x60ee881a(new byte[25] { 135, 155, 155, 159, 156, 213, 192, 192, 141, 159, 136, 131, 128, 141, 142, 131, 137, 142, 153, 193, 131, 134, 153, 138, 192 }, 239), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0xf12362ab);
                OpenUrlExternally(_0x90109469);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x90109469))
            {
                _0x35ba8e3c(true);
                WLog(_0x77e3fd1c._0x60ee881a(new byte[41] { 2, 42, 42, 34, 41, 32, 101, 36, 48, 49, 45, 101, 35, 41, 42, 50, 101, 33, 32, 49, 32, 38, 49, 32, 33, 101, 104, 123, 101, 46, 32, 32, 53, 101, 51, 44, 54, 44, 39, 41, 32 }, 69));
                return;
            }

            _0x865004a6 = true;
            _0x35ba8e3c(true);
            WLog(_0x77e3fd1c._0x60ee881a(new byte[43] { 110, 92, 91, 111, 80, 92, 78, 25, 85, 86, 88, 93, 80, 87, 94, 22, 75, 92, 93, 80, 75, 92, 90, 77, 80, 87, 94, 25, 20, 7, 25, 82, 92, 92, 73, 25, 79, 80, 74, 80, 91, 85, 92 }, 57));
        };
        _0xf1080e0f.OnPageCommitted += (_0xf12362ab, _0x90109469) =>
        {
            if (_0x90140346 && IsAboutBlank(_0x90109469))
                return;
            MarkMainFrameCommitted(_0x90109469);
            WLog(_0x77e3fd1c._0x60ee881a(new byte[31] { 86, 122, 114, 117, 59, 76, 126, 121, 77, 114, 126, 108, 59, 84, 117, 75, 122, 124, 126, 88, 116, 118, 118, 114, 111, 111, 126, 127, 33, 59, 48 }, 27) + (Time.realtimeSinceStartup - _0xdc4ee5b8).ToString(_0x77e3fd1c._0x60ee881a(new byte[5] { 161, 191, 161, 161, 161 }, 145)) + _0x77e3fd1c._0x60ee881a(new byte[2] { 107, 56 }, 24) + _0x90109469);
            if (!firstLoadShown && IsHttpUrl(_0x90109469))
            {
                firstLoadShown = true;
                _0x865004a6 = false;
                _0x35ba8e3c(false);
                _0x35f28e12();
                _0xe2421f1b();
                _0xf12362ab.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x6768c973(_0x77e3fd1c._0x60ee881a(new byte[9] { 30, 31, 54, 6, 25, 12, 7, 12, 13 }, 105));
                WLog(_0x77e3fd1c._0x60ee881a(new byte[39] { 65, 109, 101, 98, 44, 91, 105, 110, 90, 101, 105, 123, 44, 127, 100, 99, 123, 98, 44, 99, 98, 44, 111, 99, 97, 97, 101, 120, 120, 105, 104, 44, 111, 99, 98, 120, 105, 98, 120 }, 12));
            }
        };
        _0xf1080e0f.OnPageProgressChanged += (_0xf12362ab, _0x2dc375b2) =>
        {
            if (_0x90140346)
                return;
            if (!firstLoadShown && _0x2dc375b2 >= 0.65f)
            {
                firstLoadShown = true;
                _0x865004a6 = false;
                _0x35ba8e3c(false);
                _0x35f28e12();
                _0xe2421f1b();
                _0xf12362ab.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x6768c973(_0x77e3fd1c._0x60ee881a(new byte[9] { 13, 12, 37, 21, 10, 31, 20, 31, 30 }, 122));
                WLog(_0x77e3fd1c._0x60ee881a(new byte[32] { 160, 140, 132, 131, 205, 186, 136, 143, 187, 132, 136, 154, 205, 158, 133, 130, 154, 131, 205, 143, 148, 205, 157, 159, 130, 138, 159, 136, 158, 158, 215, 205 }, 237) + _0x2dc375b2);
            }
        };
        _0xf1080e0f.OnPageFinished += (_0xf12362ab, _0x25317d62, _0x90109469) =>
        {
            if (_0x90140346 && IsAboutBlank(_0x90109469))
            {
                _0x90140346 = false;
                WLog(_0x77e3fd1c._0x60ee881a(new byte[28] { 229, 199, 208, 194, 212, 199, 216, 149, 212, 215, 218, 192, 193, 143, 215, 217, 212, 219, 222, 149, 211, 220, 219, 220, 198, 221, 208, 209 }, 181));
                return;
            }

            WLog(_0x77e3fd1c._0x60ee881a(new byte[24] { 243, 223, 215, 208, 158, 233, 219, 220, 232, 215, 219, 201, 158, 248, 215, 208, 215, 205, 214, 219, 218, 132, 158, 149 }, 190) + (Time.realtimeSinceStartup - _0xdc4ee5b8).ToString(_0x77e3fd1c._0x60ee881a(new byte[5] { 161, 191, 161, 161, 161 }, 145)) + _0x77e3fd1c._0x60ee881a(new byte[7] { 228, 183, 244, 248, 243, 242, 170 }, 151) + _0x25317d62 + _0x77e3fd1c._0x60ee881a(new byte[5] { 9, 92, 91, 69, 20 }, 41) + _0x90109469);
            if (_0x25317d62 >= 200 && _0x25317d62 < 400)
                MarkMainFrameCommitted(_0x90109469);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x865004a6 = false;
                _0x35ba8e3c(false);
                _0x35f28e12();
                _0xe2421f1b();
                _0xf12362ab.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x6768c973(_0x77e3fd1c._0x60ee881a(new byte[9] { 205, 204, 229, 213, 202, 223, 212, 223, 222 }, 186));
                WLog(_0x77e3fd1c._0x60ee881a(new byte[33] { 144, 188, 180, 179, 253, 138, 184, 191, 139, 180, 184, 170, 253, 187, 180, 175, 174, 169, 253, 177, 178, 188, 185, 253, 190, 178, 176, 173, 177, 184, 169, 184, 185 }, 221));
            }
            else if (_0x865004a6)
            {
                _0x865004a6 = false;
                _0x35ba8e3c(false);
                _0xf12362ab.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x77e3fd1c._0x60ee881a(new byte[40] { 142, 162, 170, 173, 227, 148, 166, 161, 149, 170, 166, 180, 227, 144, 171, 172, 180, 227, 162, 165, 183, 166, 177, 227, 175, 172, 162, 167, 170, 173, 164, 227, 165, 170, 173, 170, 176, 171, 166, 167 }, 195));
            }
            else
            {
                _0x35ba8e3c(false);
            }

            if (_0xbcd61f9e && !IsGoogleAuthFlowUrl(_0x90109469) && !IsGoogleAuthFlowUrl(_0x90109469))
            {
                WLog(_0x77e3fd1c._0x60ee881a(new byte[48] { 83, 123, 123, 115, 120, 113, 52, 117, 97, 96, 124, 52, 103, 113, 113, 121, 103, 52, 114, 125, 122, 125, 103, 124, 113, 112, 52, 57, 42, 52, 102, 113, 103, 96, 123, 102, 113, 52, 112, 113, 114, 117, 97, 120, 96, 52, 65, 85 }, 20));
                _0xbcd61f9e = false;
                _0x324c9723.SetUserAgent("");
            }
        };
        _0xf1080e0f.OnShouldClose += _0xf12362ab =>
        {
            WLog(_0x77e3fd1c._0x60ee881a(new byte[41] { 23, 24, 41, 63, 56, 17, 108, 1, 45, 37, 34, 108, 27, 41, 46, 26, 37, 41, 59, 108, 3, 34, 31, 36, 35, 57, 32, 40, 15, 32, 35, 63, 41, 108, 37, 34, 58, 35, 39, 41, 40 }, 76));
            _0x62c12c6e();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0xf1080e0f.SetPopupPageEventEnabled(true);
        bool _0x4b0dff62 = false;
        bool _0x32217f23 = false;
        _0xf1080e0f.OnMultipleWindowOpened += (_0xf12362ab, _0x6103dcc9) =>
        {
            _0xf12362ab.ScrollTo(0, 0, false);
            WLog(_0x77e3fd1c._0x60ee881a(new byte[43] { 54, 57, 8, 30, 25, 48, 77, 32, 12, 4, 3, 77, 58, 8, 15, 59, 4, 8, 26, 77, 32, 24, 1, 25, 4, 29, 1, 8, 58, 4, 3, 9, 2, 26, 77, 34, 29, 8, 3, 8, 9, 87, 77 }, 109) + _0x6103dcc9);
            var _0x202c62ce = _0xf1080e0f.GetPopupWindow(_0x6103dcc9);
            if (_0x202c62ce == null)
                return;
            _0xb10e3fc8.Add(_0x202c62ce);
            Debug.Log($"[Test] Popup ID: {_0x202c62ce.Id}");
            _0x202c62ce.OnPageStarted += (_0xd857d23b, _0x90109469) =>
            {
                WLog(_0x77e3fd1c._0x60ee881a(new byte[36] { 80, 95, 110, 120, 127, 86, 43, 91, 100, 123, 126, 123, 43, 92, 110, 105, 93, 98, 110, 124, 43, 68, 101, 91, 106, 108, 110, 88, 127, 106, 121, 127, 110, 111, 49, 43 }, 11) + _0x90109469);
                _0xa8ed203b = 0;
                if (string.IsNullOrEmpty(_0x90109469) || IsAboutBlank(_0x90109469))
                    return;
                if (IsGoogleAuthFlowUrl(_0x90109469))
                {
                    WLog(_0x77e3fd1c._0x60ee881a(new byte[57] { 85, 90, 107, 125, 122, 83, 46, 94, 97, 126, 123, 126, 46, 73, 97, 97, 105, 98, 107, 46, 111, 123, 122, 102, 46, 104, 98, 97, 121, 46, 35, 48, 46, 125, 126, 97, 97, 104, 46, 73, 97, 97, 105, 98, 107, 46, 77, 102, 124, 97, 99, 107, 46, 91, 79, 52, 46 }, 14) + _0x90109469);
                    _0x4b0dff62 = false;
                    _0x2bcc7b8c();
                    if (_0xd857d23b != null && _0xd857d23b.IsAlive)
                        _0xd857d23b.EvaluateJavaScript(_0xde7c4dac());
                    return;
                }

                if (_0x324c9723 == null)
                    return;
                if (!_0x4b0dff62)
                {
                    _0x4b0dff62 = true;
                    _0x324c9723.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x77e3fd1c._0x60ee881a(new byte[39] { 24, 23, 38, 48, 55, 30, 99, 19, 44, 51, 54, 51, 99, 34, 51, 51, 47, 58, 99, 20, 42, 45, 39, 44, 52, 48, 99, 39, 38, 48, 40, 55, 44, 51, 99, 22, 2, 121, 99 }, 67) + _0x90109469);
                }

                if (_0xd857d23b != null && _0xd857d23b.IsAlive)
                    _0xd857d23b.EvaluateJavaScript(_0x08a89073());
                if (!_0x32217f23 && _0xd857d23b != null && _0xd857d23b.IsAlive && IsHttpUrl(_0x90109469))
                {
                    _0x32217f23 = true;
                }
            };
            _0x202c62ce.OnPageFinished += (_0xd857d23b, _0xd316a351) =>
            {
                string _0x46961a6e = _0xd316a351 != null ? _0xd316a351.data : string.Empty;
                WLog(_0x77e3fd1c._0x60ee881a(new byte[35] { 54, 57, 8, 30, 25, 48, 77, 61, 2, 29, 24, 29, 77, 58, 8, 15, 59, 4, 8, 26, 77, 43, 4, 3, 4, 30, 5, 8, 9, 87, 77, 24, 31, 1, 80 }, 109) + _0x46961a6e);
                if (_0xd857d23b == null || !_0xd857d23b.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x46961a6e))
                {
                    _0x2bcc7b8c();
                    _0xd857d23b.EvaluateJavaScript(_0xde7c4dac());
                    return;
                }

                if (!_0x4b0dff62)
                    return;
                _0xd857d23b.EvaluateJavaScript(_0x08a89073());
            };
        };
        _0xf1080e0f.OnMultipleWindowClosed += (_0xf12362ab, _0x6103dcc9) =>
        {
            _0xb10e3fc8.RemoveAll(_0xa3b5a873 => _0xa3b5a873 == null || _0xa3b5a873.Id == _0x6103dcc9 || !_0xa3b5a873.IsAlive);
            _0x35ba8e3c(false);
            if (_0xb10e3fc8.Count == 0 && _0x324c9723 != null)
            {
                _0x4b0dff62 = false;
                _0x32217f23 = false;
                _0x63a7687f();
            }

            WLog(_0x77e3fd1c._0x60ee881a(new byte[43] { 71, 72, 121, 111, 104, 65, 60, 81, 125, 117, 114, 60, 75, 121, 126, 74, 117, 121, 107, 60, 81, 105, 112, 104, 117, 108, 112, 121, 75, 117, 114, 120, 115, 107, 60, 95, 112, 115, 111, 121, 120, 38, 60 }, 28) + _0x6103dcc9);
        };
        _0xf1080e0f.RegisterOnRequestMediaCapturePermission(_0x8d61ed1c =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private bool _0xe8c75daf()
    {
        var _0x5b03d121 = Keyboard.current;
        return _0x5b03d121 != null && _0x5b03d121.escapeKey.wasPressedThisFrame;
    }

    private bool _0x09ae64e5(string _0x5643f148)
    {
        try
        {
            using (var _0x62c2b6c2 = new AndroidJavaClass(_0x77e3fd1c._0x60ee881a(new byte[30] { 44, 32, 34, 97, 58, 33, 38, 59, 54, 124, 43, 97, 63, 35, 46, 54, 42, 61, 97, 26, 33, 38, 59, 54, 31, 35, 46, 54, 42, 61 }, 79)))
            using (var _0x14292f62 = _0x62c2b6c2.GetStatic<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[15] { 47, 57, 62, 62, 41, 34, 56, 13, 47, 56, 37, 58, 37, 56, 53 }, 76)))
            using (var _0x49f9afff = new AndroidJavaClass(_0x77e3fd1c._0x60ee881a(new byte[15] { 127, 112, 122, 108, 113, 119, 122, 48, 112, 123, 106, 48, 75, 108, 119 }, 30)))
            using (var _0x397c51d2 = _0x49f9afff.CallStatic<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[5] { 121, 104, 123, 122, 108 }, 9), _0x5643f148))
            using (var _0x14f2a213 = new AndroidJavaObject(_0x77e3fd1c._0x60ee881a(new byte[22] { 165, 170, 160, 182, 171, 173, 160, 234, 167, 171, 170, 176, 161, 170, 176, 234, 141, 170, 176, 161, 170, 176 }, 196), _0x77e3fd1c._0x60ee881a(new byte[26] { 31, 16, 26, 12, 17, 23, 26, 80, 23, 16, 10, 27, 16, 10, 80, 31, 29, 10, 23, 17, 16, 80, 40, 55, 59, 41 }, 126), _0x397c51d2))
            {
                WLog(_0x77e3fd1c._0x60ee881a(new byte[26] { 58, 17, 11, 22, 20, 28, 53, 16, 18, 28, 89, 22, 9, 28, 23, 89, 28, 1, 13, 28, 11, 23, 24, 21, 67, 89 }, 121) + _0x5643f148);
                _0x14f2a213.Call<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[11] { 237, 232, 232, 207, 237, 248, 233, 235, 227, 254, 245 }, 140), _0x77e3fd1c._0x60ee881a(new byte[33] { 172, 163, 169, 191, 162, 164, 169, 227, 164, 163, 185, 168, 163, 185, 227, 174, 172, 185, 168, 170, 162, 191, 180, 227, 143, 159, 130, 154, 158, 140, 143, 129, 136 }, 205));
                _0x14f2a213.Call<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[8] { 195, 198, 198, 228, 206, 195, 197, 209 }, 162), 0x10000000);
                _0x14292f62.Call(_0x77e3fd1c._0x60ee881a(new byte[13] { 141, 138, 159, 140, 138, 191, 157, 138, 151, 136, 151, 138, 135 }, 254), _0x14f2a213);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x77e3fd1c._0x60ee881a(new byte[28] { 69, 110, 116, 105, 107, 99, 74, 111, 109, 99, 38, 99, 126, 114, 99, 116, 104, 103, 106, 38, 96, 103, 111, 106, 99, 98, 60, 38 }, 6) + e.Message);
            Application.OpenURL(_0x5643f148);
            return true;
        }
    }

    private string _0xaf4c5f81;
    public void _0xb70ad93d()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[18] { 221, 210, 227, 245, 242, 219, 166, 202, 231, 243, 232, 229, 238, 166, 193, 231, 235, 227 }, 134));
#endif
        }

        _0xd420ada1.Instance?._0x010c2fde();
        _0xd705b3c4.Instance._0x635f95c6(_0xd9957943._0x23baba46.DEFAULT);
    }

    internal Button _0xb08699ef(string _0xbd47ab81, Transform _0xde2aef71)
    {
        var _0xe5dc3a23 = new GameObject(_0xbd47ab81 + _0x77e3fd1c._0x60ee881a(new byte[3] { 229, 211, 201 }, 167), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0xe701f534 = _0xe5dc3a23.GetComponent<RectTransform>();
        _0xe701f534.SetParent(_0xde2aef71, false);
        var _0x159435ca = _0xe5dc3a23.GetComponent<Image>();
        _0x159435ca.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x2f2d10e5 = _0xe5dc3a23.GetComponent<Button>();
        var _0x312e5b6a = _0x2f2d10e5.colors;
        _0x312e5b6a.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x312e5b6a.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x2f2d10e5.colors = _0x312e5b6a;
        var _0x5a4c40b3 = new GameObject(_0x77e3fd1c._0x60ee881a(new byte[4] { 215, 230, 251, 247 }, 131), typeof(RectTransform), typeof(Text));
        var _0x3831fc71 = _0x5a4c40b3.GetComponent<RectTransform>();
        _0x3831fc71.SetParent(_0xe5dc3a23.transform, false);
        _0x3831fc71.anchorMin = Vector2.zero;
        _0x3831fc71.anchorMax = Vector2.one;
        _0x3831fc71.offsetMin = _0x3831fc71.offsetMax = Vector2.zero;
        var _0x3e3e1dc6 = _0x5a4c40b3.GetComponent<Text>();
        _0x3e3e1dc6.text = _0xbd47ab81;
        _0x3e3e1dc6.alignment = TextAnchor.MiddleCenter;
        _0x3e3e1dc6.color = Color.black;
        _0x3e3e1dc6.font = Resources.GetBuiltinResource<Font>(_0x77e3fd1c._0x60ee881a(new byte[9] { 102, 85, 78, 70, 75, 9, 83, 83, 65 }, 39));
        _0x3e3e1dc6.fontSize = 28;
        WLog(_0x77e3fd1c._0x60ee881a(new byte[14] { 141, 188, 171, 175, 186, 171, 140, 187, 186, 186, 161, 160, 238, 233 }, 206) + _0xbd47ab81 + _0x77e3fd1c._0x60ee881a(new byte[1] { 99 }, 68));
        return _0x2f2d10e5;
    }

    private GameObject _0x99ca6651;
    private async Task<bool> _0x20c11a44()
    {
        {
#if B_LOGS
            Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[29] { 35, 44, 29, 11, 12, 37, 88, 49, 11, 40, 10, 17, 14, 25, 27, 1, 57, 22, 28, 43, 25, 14, 29, 28, 59, 16, 29, 27, 19 }, 120));
#endif
        }

        string _0x68bbfb86 = "";
        for (int _0xca21081d = 0; _0xca21081d < 2; _0xca21081d++)
        {
            if (await _0x8d79d238(1, 100))
            {
                await _0x6768c973(_0x77e3fd1c._0x60ee881a(new byte[7] { 148, 154, 153, 149, 157, 147, 146 }, 246));
                _0xb70ad93d();
                return true;
            }

            _0x68bbfb86 = await _0x26bdc77a(1, 100);
            if (!string.IsNullOrEmpty(_0x68bbfb86))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x68bbfb86))
            {
                if (!string.IsNullOrEmpty(_0xaf4c5f81))
                {
                    _0x68bbfb86 = _0xe8911729(_0x68bbfb86, _0xaf4c5f81);
                    {
#if B_LOGS
                        Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[53] { 67, 76, 125, 107, 108, 69, 56, 91, 121, 123, 112, 125, 124, 56, 126, 113, 118, 121, 116, 77, 106, 116, 56, 111, 113, 108, 112, 56, 107, 125, 118, 124, 113, 124, 56, 250, 158, 138, 56, 107, 112, 119, 111, 56, 79, 125, 122, 78, 113, 125, 111, 34, 56 }, 24) + _0x68bbfb86);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[39] { 34, 45, 28, 10, 13, 36, 89, 58, 24, 26, 17, 28, 29, 89, 31, 16, 23, 24, 21, 44, 11, 21, 89, 155, 255, 235, 89, 10, 17, 22, 14, 89, 46, 28, 27, 47, 16, 28, 14 }, 121));
#endif
                    }
                }

                _0xbf64af02 = true;
                _0x626bcdef(_0x68bbfb86);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[44] { 230, 233, 216, 206, 201, 224, 157, 248, 197, 222, 216, 205, 201, 212, 210, 211, 157, 202, 213, 212, 209, 216, 157, 222, 213, 216, 222, 214, 212, 211, 218, 157, 206, 220, 203, 216, 217, 157, 209, 212, 211, 214, 135, 157 }, 189) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private int _0xa8ed203b = 0;
    static readonly string TextAlphabet = _0x77e3fd1c._0x60ee881a(new byte[93] { 124, 125, 127, 120, 121, 122, 123, 116, 117, 118, 119, 112, 113, 114, 115, 108, 109, 110, 111, 104, 105, 106, 107, 100, 101, 102, 103, 96, 97, 98, 99, 28, 29, 30, 31, 24, 25, 26, 27, 20, 21, 22, 23, 16, 17, 18, 19, 12, 13, 14, 15, 8, 9, 10, 11, 4, 5, 6, 7, 1, 2, 3, 60, 61, 62, 63, 56, 57, 58, 59, 52, 53, 54, 55, 48, 49, 50, 51, 44, 45, 46, 47, 40, 41, 42, 43, 36, 37, 38, 39, 32, 33, 34 }, 92);
    private async void Start()
    {
        await _0x0501d7c5();
    }

    // WEB VIEW LOGIC
    public bool _0x8f4e0496 { get; set; }

    private string _0x3ee357fa()
    {
        if (string.IsNullOrEmpty(_0x64b1962c) && _0x324c9723 != null)
            _0x64b1962c = _0x324c9723.GetUserAgent();
        if (string.IsNullOrEmpty(_0x64b1962c))
            return string.Empty;
        string _0x659f3e92 = Regex.Replace(_0x64b1962c, _0x77e3fd1c._0x60ee881a(new byte[11] { 95, 112, 41, 56, 95, 112, 41, 116, 117, 95, 97 }, 3), string.Empty);
        _0x659f3e92 = Regex.Replace(_0x659f3e92, _0x77e3fd1c._0x60ee881a(new byte[15] { 3, 44, 116, 29, 42, 54, 51, 59, 112, 4, 1, 100, 118, 2, 116 }, 95), string.Empty);
        _0x659f3e92 = Regex.Replace(_0x659f3e92, _0x77e3fd1c._0x60ee881a(new byte[15] { 180, 135, 144, 145, 139, 141, 140, 205, 214, 190, 204, 210, 190, 145, 200 }, 226), string.Empty);
        return Regex.Replace(_0x659f3e92, _0x77e3fd1c._0x60ee881a(new byte[6] { 99, 76, 68, 13, 19, 66 }, 63), _0x77e3fd1c._0x60ee881a(new byte[1] { 56 }, 24)).Trim();
    }

    private string _0x2436bb38 = "";
    private IEnumerator _0x379c113a(IEnumerator _0x319dac51, TaskCompletionSource<bool> _0x4f8aacc4)
    {
        yield return _0x319dac51;
        _0x4f8aacc4.SetResult(true);
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0xa80d9e37)
    {
        if (_0xa80d9e37 == null || _0xa80d9e37.Extra == null)
            return null;
        object _0x608ee8e6;
        if (!_0xa80d9e37.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x608ee8e6))
            return null;
        return _0x608ee8e6 as string;
    }

    private async Task<bool> _0x8d79d238(int _0x7acc1019 = 5, int _0x90c44916 = 500)
    {
        CommState _0xdad0f8ae = default;
        int _0x4462a8ec = 0;
        do
        {
            try
            {
                _0xdad0f8ae = await _0xe2e253a8();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[32] { 191, 176, 129, 151, 144, 185, 196, 149, 145, 129, 150, 157, 165, 151, 157, 138, 135, 182, 129, 151, 145, 136, 144, 151, 196, 129, 150, 150, 139, 150, 222, 196 }, 228) + e.Message);
                    }
#endif
                }
            }

            if (_0xdad0f8ae.Ready)
                break;
            await Task.Delay(_0x90c44916);
        }
        while (_0x4462a8ec++ < _0x7acc1019);
        bool _0x613cd408 = _0xdad0f8ae.Ready && _0xdad0f8ae.IsPrivacy;
        {
#if B_LOGS
            {
                Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[25] { 108, 99, 82, 68, 67, 106, 23, 126, 68, 103, 69, 94, 65, 86, 84, 78, 23, 69, 82, 68, 66, 91, 67, 13, 23 }, 55) + _0x613cd408);
            }
#endif
        }

        return _0x613cd408;
    }

    private void WLog(string _0x1b38d5aa)
    {
#if B_LOGS
        {
            Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[7] { 175, 160, 145, 135, 128, 169, 212 }, 244) + _0x1b38d5aa);
        }
#endif
    }

    private string _0x0d4f9ce8 = "";
    private IEnumerator _0xe69b9a7a(string _0x09179e1c)
    {
        if (_0x324c9723 != null && _0x8f4e0496)
            yield break;
        _0x324c9723 = gameObject.AddComponent<UniWebView>();
        _0xebbcfe6b(_0x324c9723);
        _0xad572519(_0x324c9723);
        _0x324c9723.BackgroundColor = Color.clear;
        var _0x26c23eed = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xe2421f1b();
        yield return new WaitForEndOfFrame();
        _0x8f4e0496 = true;
        _0x565c6f06();
        _0x35ba8e3c(true);
        _0x90140346 = false;
        _0xbcd61f9e = false;
        _0xb10e3fc8.Clear();
        _0xc1460ae7 = -1;
        firstLoadShown = false;
        _0x865004a6 = false;
        _0xecbc6427 = false;
        _0x324c9723.SetUserAgent("");
        _0xdc4ee5b8 = Time.realtimeSinceStartup;
        _0x324c9723.Stop();
        _0x324c9723.Load(_0x09179e1c);
        _0x324c9723.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x77e3fd1c._0x60ee881a(new byte[25] { 225, 205, 197, 194, 140, 251, 201, 206, 250, 197, 201, 219, 140, 229, 194, 197, 216, 197, 205, 192, 140, 255, 196, 195, 219 }, 172));
    }

    static System.Numerics.BigInteger FromBigEndian(byte[] _0xafbb7859)
    {
        var _0xb841fbca = new byte[_0xafbb7859.Length + 1];
        for (int _0x6177b462 = 0; _0x6177b462 < _0xafbb7859.Length; _0x6177b462++)
            _0xb841fbca[_0xafbb7859.Length - 1 - _0x6177b462] = _0xafbb7859[_0x6177b462];
        return new System.Numerics.BigInteger(_0xb841fbca);
    }

    private string _0x6f1ab94d = "";
    private void _0x626bcdef(string _0x9c80c481)
    {
        _0x2ada4fb8();
        StartCoroutine(_0xe69b9a7a(_0x9c80c481));
    }

    private void OnApplicationPause(bool _0x68de2f36)
    {
        isApplicationPause = _0x68de2f36;
    }

    static byte[] CompressDeflate(byte[] _0xc9dc9e51)
    {
        using var _0xd03f6c40 = new MemoryStream();
        using (var _0xd7a2fc1f = new DeflateStream(_0xd03f6c40, SmallestCompression()))
            _0xd7a2fc1f.Write(_0xc9dc9e51, 0, _0xc9dc9e51.Length);
        return _0xd03f6c40.ToArray();
    }

    private void _0xf4a7ba9e(string _0xcfd5ec2b)
    {
        bool _0xa5d329ab = !string.IsNullOrEmpty(_0xcfd5ec2b);
        if (_0xa5d329ab)
        {
            {
#if B_LOGS
                Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[13] { 45, 34, 19, 5, 2, 43, 86, 37, 30, 25, 1, 76, 86 }, 118) + _0xcfd5ec2b);
#endif
            }

            _0x626bcdef(_0xcfd5ec2b);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[39] { 147, 156, 173, 187, 188, 149, 232, 142, 169, 164, 164, 170, 169, 171, 163, 232, 42, 78, 90, 232, 143, 169, 165, 173, 232, 224, 166, 167, 232, 174, 161, 166, 169, 164, 232, 157, 154, 132, 225 }, 200));
#endif
            }

            _0xb70ad93d();
            return;
        }
    }

    private string _0x4a95d835(string _0x77f45e95, string _0x7b5cf7fb)
    {
        try
        {
            if (string.IsNullOrEmpty(_0x77f45e95))
                return "";
            var _0x189b50d7 = Decode93(_0x77f45e95);
            if (_0x189b50d7.Length < 5)
                return "";
            var _0x0aad83f3 = new byte[4];
            Buffer.BlockCopy(_0x189b50d7, 0, _0x0aad83f3, 0, 4);
            var _0x7d2f2cd3 = new byte[_0x189b50d7.Length - 4];
            Buffer.BlockCopy(_0x189b50d7, 4, _0x7d2f2cd3, 0, _0x7d2f2cd3.Length);
            var _0xb6255406 = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x7b5cf7fb ?? ""));
            var _0x47e09290 = AesCtr(_0x7d2f2cd3, _0xb6255406, _0x0aad83f3);
            var _0x21d5c57e = new byte[_0x47e09290.Length - 1];
            Buffer.BlockCopy(_0x47e09290, 1, _0x21d5c57e, 0, _0x21d5c57e.Length);
            return Encoding.UTF8.GetString(UnpackSmallest(_0x21d5c57e, _0x47e09290[0]));
        }
        catch (Exception)
        {
            return "";
        }
    }

    private string _0x46d23418 = "";
    private static readonly string WindowsDesktopUserAgent = _0x77e3fd1c._0x60ee881a(new byte[111] { 83, 113, 100, 119, 114, 114, 127, 49, 43, 48, 46, 62, 54, 73, 119, 112, 122, 113, 105, 109, 62, 80, 74, 62, 47, 46, 48, 46, 37, 62, 73, 119, 112, 40, 42, 37, 62, 102, 40, 42, 55, 62, 95, 110, 110, 114, 123, 73, 123, 124, 85, 119, 106, 49, 43, 45, 41, 48, 45, 40, 62, 54, 85, 86, 74, 83, 82, 50, 62, 114, 119, 117, 123, 62, 89, 123, 125, 117, 113, 55, 62, 93, 118, 108, 113, 115, 123, 49, 47, 44, 46, 48, 46, 48, 46, 48, 46, 62, 77, 127, 120, 127, 108, 119, 49, 43, 45, 41, 48, 45, 40 }, 30);
    // WEB VIEW LOGIC END
    internal void _0xfec72ba0()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x88ac9d60 = new AndroidNotificationChannel
        {
            Id = _0x77e3fd1c._0x60ee881a(new byte[15] { 136, 137, 138, 141, 153, 128, 152, 179, 143, 132, 141, 130, 130, 137, 128 }, 236),
            Name = _0x77e3fd1c._0x60ee881a(new byte[15] { 54, 23, 20, 19, 7, 30, 6, 82, 49, 26, 19, 28, 28, 23, 30 }, 114),
            Importance = Importance.High,
            Description = _0x77e3fd1c._0x60ee881a(new byte[21] { 109, 79, 68, 79, 88, 75, 70, 10, 68, 69, 94, 67, 76, 67, 73, 75, 94, 67, 69, 68, 89 }, 42)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x88ac9d60);
        // Build notification
        var _0x08f5675d = new AndroidNotification
        {
            Title = _0x1e8a9829[UnityEngine.Random.Range(0, _0x1e8a9829.Length)],
            Text = _0x77e3fd1c._0x60ee881a(new byte[21] { 121, 74, 93, 24, 65, 87, 77, 24, 75, 77, 74, 93, 24, 76, 87, 24, 93, 64, 81, 76, 7 }, 56),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x08f5675d, _0x77e3fd1c._0x60ee881a(new byte[15] { 34, 35, 32, 39, 51, 42, 50, 25, 37, 46, 39, 40, 40, 35, 42 }, 70));
    }

    private async Task<string> _0x26bdc77a(int _0x09386ef9 = 5, int _0x772247ae = 500)
    {
        try
        {
            CommState _0xca26c372 = default;
            int _0x0f712334 = 0;
            do
            {
                _0xca26c372 = await _0xe2e253a8();
                if (_0xca26c372.Ready)
                    break;
                await Task.Delay(_0x772247ae);
            }
            while (_0x0f712334++ < _0x09386ef9);
            var _0x3c0e4e08 = _0xca26c372.Ready && !_0xca26c372.IsPrivacy ? _0xca26c372.SavedLink : string.Empty;
            {
#if B_LOGS
                {
                    Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[24] { 94, 81, 96, 118, 113, 88, 37, 73, 106, 100, 97, 37, 118, 100, 115, 96, 97, 37, 105, 108, 107, 110, 63, 37 }, 5) + _0x3c0e4e08);
                }
#endif
            }

            return _0x3c0e4e08 ?? string.Empty;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[39] { 147, 156, 173, 187, 188, 149, 232, 143, 173, 188, 232, 167, 186, 232, 184, 169, 186, 187, 173, 232, 187, 169, 190, 173, 172, 232, 164, 161, 166, 163, 232, 174, 169, 161, 164, 173, 172, 242, 232 }, 200) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private JObject _0x7cf29759(params string[] _0xae1b82bf)
    {
        JObject _0xff777faa = new JObject();
        foreach (var _0x7396ddb2 in _0xae1b82bf)
        {
            string _0xab6dc2e9;
            do
            {
                _0xab6dc2e9 = _0xccc2ba3f();
            }
            while (_0xff777faa.ContainsKey(_0xab6dc2e9));
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0xab6dc2e9} val={_0x7396ddb2}");
#endif
            }

            _0xff777faa.Add(_0xab6dc2e9, _0x7396ddb2 == null ? "" : _0x7396ddb2);
        }

        return _0xff777faa;
    }

    private readonly List<UniWebViewPopup> _0xb10e3fc8 = new List<UniWebViewPopup>();
    private bool _0x0dc835dd(string _0x7f91ef11)
    {
        string _0x4f0c5686 = GetUrlHost(_0x7f91ef11);
        if (!string.IsNullOrEmpty(_0x4f0c5686) && !string.IsNullOrEmpty(_0xafdb3aab) && !string.Equals(_0x4f0c5686, _0xafdb3aab, StringComparison.OrdinalIgnoreCase))
            return true;
        return _0xd94eebfa;
    }

    private Task _0xa5526ae8(IEnumerator _0xc5b2bbbe)
    {
        var _0x1628a687 = new TaskCompletionSource<bool>();
        StartCoroutine(_0x379c113a(_0xc5b2bbbe, _0x1628a687));
        return _0x1628a687.Task;
    }

    private IEnumerator _0xca83b7cd()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[26] { 221, 210, 227, 245, 242, 219, 166, 207, 232, 239, 242, 239, 231, 234, 239, 252, 227, 212, 227, 224, 224, 227, 244, 227, 244, 166 }, 134));
            }
#endif
        }

        bool _0xbbd47771 = false;
        InstallReferrer.GetReferrer((_0x5f01c067) =>
        {
            Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[24] { 225, 238, 223, 201, 206, 154, 232, 223, 220, 223, 200, 200, 223, 200, 231, 154, 221, 223, 206, 154, 88, 60, 40, 154 }, 186) + _0x8e5d46cf);
            if (_0x5f01c067.IsSuccess)
            {
                _0x8e5d46cf = _0x5f01c067.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[28] { 140, 131, 178, 164, 163, 247, 133, 178, 177, 178, 165, 165, 178, 165, 138, 247, 132, 162, 180, 180, 178, 164, 164, 247, 53, 81, 69, 247 }, 215) + _0x8e5d46cf);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[27] { 102, 105, 88, 78, 73, 29, 111, 88, 91, 88, 79, 79, 88, 79, 96, 29, 123, 92, 84, 81, 88, 89, 29, 223, 187, 175, 29 }, 61) + _0x5f01c067);
#endif
                }

                _0x8e5d46cf = "";
            }

            _0xcaf2ae5c = true;
        });
        StartCoroutine(_0x6afed5bd(2f));
        yield return new WaitUntil(() => _0xcaf2ae5c);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x8e5d46cf}");
#endif
        }

        bool _0xf51ed703 = _0x8e5d46cf.Contains(_0x77e3fd1c._0x60ee881a(new byte[6] { 11, 15, 0, 5, 8, 81 }, 108));
        _0xbbd47771 = _0xf51ed703 || _0x8e5d46cf.Contains(_0x77e3fd1c._0x60ee881a(new byte[18] { 169, 184, 184, 187, 230, 161, 166, 187, 188, 169, 175, 186, 169, 165, 230, 171, 167, 165 }, 200)) || _0x8e5d46cf.Contains(_0x77e3fd1c._0x60ee881a(new byte[17] { 38, 55, 55, 52, 105, 33, 38, 36, 34, 37, 40, 40, 44, 105, 36, 40, 42 }, 71));
        _0x2e20f7ae = _0xf51ed703 ? "" : (_0xbbd47771 ? "" : _0x2e20f7ae);
        _0x2e20f7ae = _0x2e20f7ae ?? "";
        _0xd8ec734a = _0xd8ec734a ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x2e20f7ae}");
#endif
        }
    }

    private float _0xdc4ee5b8 = 0f;
    private string _0x10e2e194 = "";
    static string Encode93(byte[] _0xdf0d86e5)
    {
        var _0x846b2cf1 = new byte[_0xdf0d86e5.Length + 1];
        _0x846b2cf1[0] = 1;
        Buffer.BlockCopy(_0xdf0d86e5, 0, _0x846b2cf1, 1, _0xdf0d86e5.Length);
        var _0x157fdefd = FromBigEndian(_0x846b2cf1);
        var _0x535831ba = new Stack<char>();
        var _0x1d4c93d8 = new System.Numerics.BigInteger(TextAlphabet.Length);
        while (_0x157fdefd > 0)
        {
            _0x157fdefd = System.Numerics.BigInteger.DivRem(_0x157fdefd, _0x1d4c93d8, out var rem);
            _0x535831ba.Push(TextAlphabet[(int)rem]);
        }

        return new string (_0x535831ba.ToArray());
    }

    static readonly int[] _0x3bd3ad21 = BuildTextAlphabetIndex();
    static byte[] UnpackSmallest(byte[] _0x9f94f024, byte _0xd7642a29)
    {
        if (_0xd7642a29 == 0)
            return _0x9f94f024;
        if (_0xd7642a29 == 1)
            return DecompressBrotli(_0x9f94f024);
        if (_0xd7642a29 == 2)
            return DecompressDeflate(_0x9f94f024);
        throw new FormatException();
    }

    private string _0xd82510cd = "";
    private async Task<bool> _0x9c6ed764()
    {
        _0xd420ada1.Instance?._0x48cfface();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x20e769e5) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[32] { 103, 104, 89, 79, 72, 97, 28, 105, 82, 85, 72, 69, 28, 108, 73, 79, 84, 28, 114, 83, 72, 85, 90, 85, 95, 93, 72, 85, 83, 82, 6, 28 }, 60) + string.Join(_0x77e3fd1c._0x60ee881a(new byte[1] { 192 }, 201), _0x20e769e5));
                }
#endif
            }
        };
        try
        {
            _0x49775885 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[31] { 145, 158, 175, 185, 190, 151, 234, 140, 171, 163, 166, 175, 174, 234, 190, 165, 234, 173, 175, 190, 234, 186, 191, 185, 162, 234, 190, 165, 161, 175, 164 }, 202));
                }
#endif
            }

            _0x49775885 = "";
        }

        _0x1cffc1fb = !string.IsNullOrEmpty(_0x49775885);
        _0xa5615324 = _0xda1e9fb2();
        {
#if B_LOGS
            Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[25] { 45, 34, 19, 5, 2, 43, 86, 35, 24, 31, 2, 15, 86, 38, 3, 5, 30, 86, 34, 25, 29, 19, 24, 76, 86 }, 118) + _0x49775885);
#endif
        }

        _0xd420ada1.Instance?._0x8720d606();
        return false;
    }

    private string _0x73c6d8f4 = "";
    // NATIVE WEB VIEW METHODS
    private UniWebView _0x324c9723 = null;
    internal bool isApplicationPause = false;
    private bool _0x0323c0ec = false;
    internal bool isDestroyedForce = false;
    private ApplicationInstallMode _0x6170e5ae = ApplicationInstallMode.Unknown;
    private string GetUrlHost(string _0xd22a27d3)
    {
        if (string.IsNullOrEmpty(_0xd22a27d3))
            return null;
        Uri _0x9dd0e3d3;
        if (!Uri.TryCreate(_0xd22a27d3, UriKind.Absolute, out _0x9dd0e3d3))
            return null;
        string _0xf0ff711c = _0x9dd0e3d3.Host;
        if (_0xf0ff711c.StartsWith(_0x77e3fd1c._0x60ee881a(new byte[4] { 114, 114, 114, 43 }, 5), StringComparison.OrdinalIgnoreCase))
            _0xf0ff711c = _0xf0ff711c.Substring(4);
        return _0xf0ff711c;
    }

    private async Task _0x0501d7c5()
    {
        if (await _0xe3a35823())
            return;
        if (await _0x9c6ed764())
            return;
        if (await _0x20c11a44())
            return;
        _0x20e6cece();
        await _0xa5526ae8(_0xca83b7cd());
        _0x73c6d8f4 = await _0x31f864cc();
        await _0xd2e74689();
    }

    readonly System.Random _0xfcc8c738 = new System.Random();
    private bool _0x4720fff2(string _0xbb339322)
    {
        try
        {
            using (var _0xbd92c57b = new AndroidJavaClass(_0x77e3fd1c._0x60ee881a(new byte[30] { 183, 187, 185, 250, 161, 186, 189, 160, 173, 231, 176, 250, 164, 184, 181, 173, 177, 166, 250, 129, 186, 189, 160, 173, 132, 184, 181, 173, 177, 166 }, 212)))
            using (var _0xec896f34 = _0xbd92c57b.GetStatic<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[15] { 237, 251, 252, 252, 235, 224, 250, 207, 237, 250, 231, 248, 231, 250, 247 }, 142)))
            using (var _0x8bcbb95d = _0xec896f34.Call<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[17] { 166, 164, 181, 145, 160, 162, 170, 160, 166, 164, 140, 160, 175, 160, 166, 164, 179 }, 193)))
            using (var _0x5d9c1c36 = new AndroidJavaClass(_0x77e3fd1c._0x60ee881a(new byte[22] { 102, 105, 99, 117, 104, 110, 99, 41, 100, 104, 105, 115, 98, 105, 115, 41, 78, 105, 115, 98, 105, 115 }, 7)))
            using (var _0x77744389 = _0x5d9c1c36.CallStatic<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[8] { 21, 4, 23, 22, 0, 48, 23, 12 }, 101), _0xbb339322, 1))
            {
                string _0x91ec1065 = _0x77744389.Call<string>(_0x77e3fd1c._0x60ee881a(new byte[14] { 253, 255, 238, 201, 238, 232, 243, 244, 253, 223, 226, 238, 232, 251 }, 154), _0x77e3fd1c._0x60ee881a(new byte[20] { 88, 72, 85, 77, 73, 95, 72, 101, 92, 91, 86, 86, 88, 91, 89, 81, 101, 79, 72, 86 }, 58));
                string _0x2847011b = _0x77744389.Call<string>(_0x77e3fd1c._0x60ee881a(new byte[10] { 18, 16, 1, 37, 20, 22, 30, 20, 18, 16 }, 117));
                _0x77744389.Call<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[11] { 137, 140, 140, 171, 137, 156, 141, 143, 135, 154, 145 }, 232), _0x77e3fd1c._0x60ee881a(new byte[33] { 10, 5, 15, 25, 4, 2, 15, 69, 2, 5, 31, 14, 5, 31, 69, 8, 10, 31, 14, 12, 4, 25, 18, 69, 41, 57, 36, 60, 56, 42, 41, 39, 46 }, 107));
                _0x77744389.Call<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[11] { 120, 111, 103, 101, 124, 111, 79, 114, 126, 120, 107 }, 10), _0x77e3fd1c._0x60ee881a(new byte[20] { 59, 43, 54, 46, 42, 60, 43, 6, 63, 56, 53, 53, 59, 56, 58, 50, 6, 44, 43, 53 }, 89));
                if (_0x77744389.Call<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[15] { 99, 116, 98, 126, 125, 103, 116, 80, 114, 101, 120, 103, 120, 101, 104 }, 17), _0x8bcbb95d) != null)
                {
                    WLog(_0x77e3fd1c._0x60ee881a(new byte[24] { 158, 181, 175, 178, 176, 184, 145, 180, 182, 184, 253, 178, 173, 184, 179, 253, 180, 179, 169, 184, 179, 169, 231, 253 }, 221) + _0xbb339322);
                    _0x77744389.Call<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[8] { 4, 1, 1, 35, 9, 4, 2, 22 }, 101), 0x10000000);
                    _0xec896f34.Call(_0x77e3fd1c._0x60ee881a(new byte[13] { 73, 78, 91, 72, 78, 123, 89, 78, 83, 76, 83, 78, 67 }, 58), _0x77744389);
                    return true;
                }

                if (_0x7e30d8e2(_0x2847011b))
                    return true;
                if (!string.IsNullOrEmpty(_0x91ec1065))
                {
                    WLog(_0x77e3fd1c._0x60ee881a(new byte[28] { 30, 53, 47, 50, 48, 56, 17, 52, 54, 56, 125, 52, 51, 41, 56, 51, 41, 125, 59, 60, 49, 49, 63, 60, 62, 54, 103, 125 }, 93) + _0x91ec1065);
                    if (_0x8e21def3(_0x91ec1065))
                        return _0x3577653a(_0x91ec1065, _0x2847011b);
                    return _0x09ae64e5(_0x91ec1065);
                }

                WLog(_0x77e3fd1c._0x60ee881a(new byte[30] { 88, 115, 105, 116, 118, 126, 87, 114, 112, 126, 59, 114, 117, 111, 126, 117, 111, 59, 117, 116, 59, 115, 122, 117, 127, 119, 126, 105, 33, 59 }, 27) + _0xbb339322);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x77e3fd1c._0x60ee881a(new byte[26] { 2, 41, 51, 46, 44, 36, 13, 40, 42, 36, 97, 40, 47, 53, 36, 47, 53, 97, 39, 32, 40, 45, 36, 37, 123, 97 }, 65) + e.Message);
            return true;
        }
    }

    static byte[] ToBigEndian(System.Numerics.BigInteger _0xb649e1db)
    {
        var _0x8f9917f2 = _0xb649e1db.ToByteArray();
        int _0x7c5cdfec = _0x8f9917f2.Length;
        if (_0x7c5cdfec > 1 && _0x8f9917f2[_0x7c5cdfec - 1] == 0)
            _0x7c5cdfec--;
        var _0xd6686720 = new byte[_0x7c5cdfec];
        for (int _0x229be653 = 0; _0x229be653 < _0x7c5cdfec; _0x229be653++)
            _0xd6686720[_0x229be653] = _0x8f9917f2[_0x7c5cdfec - 1 - _0x229be653];
        return _0xd6686720;
    }

    private RectTransform _0x1d4f9f52;
    private async Task _0x6768c973(string _0x84cfb3d0)
    {
        if (_0x29f57d15 || string.IsNullOrEmpty(_0x2baa9e67) || string.IsNullOrEmpty(_0x84cfb3d0) || _0xbf64af02)
            return;
        _0x29f57d15 = true;
        try
        {
            JObject _0x3b437521 = _0x7cf29759(_0x84cfb3d0, _0x2baa9e67, _0xda1e9fb2());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x84cfb3d0} payload: {_0x3b437521}");
                }
#endif
            }

            var _0x3b39b5e7 = _0x218f14ff(_0x3b437521.ToString(), _0x2baa9e67);
            await _0x323abc28(LeaderboardId, 2d, _0x3b39b5e7);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[24] { 234, 229, 244, 226, 229, 236, 145, 253, 222, 208, 213, 145, 193, 208, 194, 194, 145, 212, 195, 195, 222, 195, 139, 145 }, 177) + e.Message);
#endif
            }
        }
    }

    private string _0xd8ec734a { get; set; }

    private string _0xafdb3aab;
    private UniWebViewPopup _0x5b881302()
    {
        for (int _0xda6c72e7 = _0xb10e3fc8.Count - 1; _0xda6c72e7 >= 0; _0xda6c72e7--)
        {
            var _0x83b4bb7d = _0xb10e3fc8[_0xda6c72e7];
            if (_0x83b4bb7d != null && _0x83b4bb7d.IsAlive)
                return _0x83b4bb7d;
            _0xb10e3fc8.RemoveAt(_0xda6c72e7);
        }

        return null;
    }

    private bool _0x3577653a(string _0x3bb8199f, string _0xeeb3626f)
    {
        string _0x2e422500 = _0xf2db617f(_0x3bb8199f);
        if (string.IsNullOrEmpty(_0x2e422500))
            _0x2e422500 = _0xeeb3626f;
        if (_0x7e30d8e2(_0x2e422500))
            return true;
        string _0x06a96bed = string.IsNullOrEmpty(_0x2e422500) ? _0x77e3fd1c._0x60ee881a(new byte[29] { 123, 103, 103, 99, 96, 41, 60, 60, 99, 127, 114, 106, 61, 116, 124, 124, 116, 127, 118, 61, 112, 124, 126, 60, 96, 103, 124, 97, 118 }, 19) : _0x77e3fd1c._0x60ee881a(new byte[46] { 199, 219, 219, 223, 220, 149, 128, 128, 223, 195, 206, 214, 129, 200, 192, 192, 200, 195, 202, 129, 204, 192, 194, 128, 220, 219, 192, 221, 202, 128, 206, 223, 223, 220, 128, 203, 202, 219, 206, 198, 195, 220, 144, 198, 203, 146 }, 175) + _0x2e422500;
        WLog(_0x77e3fd1c._0x60ee881a(new byte[35] { 116, 95, 69, 88, 90, 82, 123, 94, 92, 82, 23, 90, 86, 69, 92, 82, 67, 23, 81, 86, 91, 91, 85, 86, 84, 92, 23, 86, 68, 23, 64, 82, 85, 13, 23 }, 55) + _0x06a96bed);
        return _0x09ae64e5(_0x06a96bed);
    }

    static byte[] PackSmallest(byte[] _0x6bfada2f, out byte _0x3f9983b5)
    {
        var _0x3e3b084d = CompressBrotli(_0x6bfada2f);
        var _0xdb6b7200 = CompressDeflate(_0x6bfada2f);
        if (_0x3e3b084d.Length < _0x6bfada2f.Length && _0x3e3b084d.Length <= _0xdb6b7200.Length)
        {
            _0x3f9983b5 = 1;
            return _0x3e3b084d;
        }

        if (_0xdb6b7200.Length < _0x6bfada2f.Length)
        {
            _0x3f9983b5 = 2;
            return _0xdb6b7200;
        }

        _0x3f9983b5 = 0;
        return _0x6bfada2f;
    }

    private string _0x8e5d46cf = "";
    static byte[] DecompressBrotli(byte[] _0x5863ca5d)
    {
        using var _0x375f01de = new MemoryStream(_0x5863ca5d);
        using var _0x2bcd5f16 = new BrotliStream(_0x375f01de, CompressionMode.Decompress);
        using var _0xf559a9f7 = new MemoryStream();
        _0x2bcd5f16.CopyTo(_0xf559a9f7);
        return _0xf559a9f7.ToArray();
    }

    private string _0x99532399 = "";
    private string _0x2e20f7ae { get; set; }

    private string _0x49775885 = "";
    private string _0xda1e9fb2()
    {
        float _0x8f3496fa = Time.realtimeSinceStartup;
        if (_0x8f3496fa < 0f)
            _0x8f3496fa = 0f;
        int _0xc2a53dad = (int)(_0x8f3496fa * 1000f);
        int _0x571302ae = _0xc2a53dad / 60000;
        int _0x7c99ac51 = (_0xc2a53dad / 1000) % 60;
        int _0x66a5cc6f = _0xc2a53dad % 1000;
        return string.Format(_0x77e3fd1c._0x60ee881a(new byte[21] { 219, 144, 154, 144, 144, 221, 154, 219, 145, 154, 144, 144, 221, 154, 219, 146, 154, 144, 144, 144, 221 }, 160), _0x571302ae, _0x7c99ac51, _0x66a5cc6f);
    }

    private void _0x181da240(string _0x7e578544)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[34] { 113, 126, 79, 89, 94, 119, 10, 108, 79, 94, 73, 66, 10, 111, 82, 94, 88, 75, 10, 122, 95, 89, 66, 10, 110, 75, 94, 75, 10, 120, 75, 93, 16, 10 }, 42) + _0x7e578544);
#endif
            }
        }

        var _0x8b8556be = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x7e578544);
        StartCoroutine(_0xc567d78e(_0x8b8556be));
    }

    private string _0xde7c4dac()
    {
        string _0xe120ce17 = _0x3ee357fa();
        if (string.IsNullOrEmpty(_0xe120ce17))
            return _0x77e3fd1c._0x60ee881a(new byte[7] { 85, 76, 74, 71, 3, 19, 24 }, 35);
        string _0x643a6d70 = _0xe120ce17.Replace(_0x77e3fd1c._0x60ee881a(new byte[1] { 43 }, 119), _0x77e3fd1c._0x60ee881a(new byte[2] { 42, 42 }, 118)).Replace(_0x77e3fd1c._0x60ee881a(new byte[1] { 247 }, 208), _0x77e3fd1c._0x60ee881a(new byte[2] { 244, 143 }, 168));
        var _0x658758ca = Regex.Match(_0xe120ce17, _0x77e3fd1c._0x60ee881a(new byte[12] { 46, 5, 31, 2, 0, 8, 66, 69, 49, 9, 70, 68 }, 109));
        string _0x730865d6 = _0x658758ca.Success ? _0x658758ca.Groups[1].Value : _0x77e3fd1c._0x60ee881a(new byte[3] { 26, 25, 27 }, 43);
        return _0x77e3fd1c._0x60ee881a(new byte[12] { 31, 81, 66, 89, 84, 67, 94, 88, 89, 31, 30, 76 }, 55) + _0x77e3fd1c._0x60ee881a(new byte[8] { 4, 19, 0, 82, 7, 19, 79, 85 }, 114) + _0x643a6d70 + _0x77e3fd1c._0x60ee881a(new byte[2] { 212, 200 }, 243) + _0x77e3fd1c._0x60ee881a(new byte[30] { 249, 238, 253, 175, 255, 253, 224, 251, 224, 178, 193, 238, 249, 230, 232, 238, 251, 224, 253, 161, 255, 253, 224, 251, 224, 251, 246, 255, 234, 180 }, 143) + _0x77e3fd1c._0x60ee881a(new byte[121] { 77, 94, 69, 72, 95, 66, 68, 69, 11, 79, 78, 77, 3, 68, 73, 65, 7, 64, 78, 82, 7, 93, 74, 71, 2, 80, 95, 89, 82, 80, 100, 73, 65, 78, 72, 95, 5, 79, 78, 77, 66, 69, 78, 123, 89, 68, 91, 78, 89, 95, 82, 3, 68, 73, 65, 7, 64, 78, 82, 7, 80, 76, 78, 95, 17, 77, 94, 69, 72, 95, 66, 68, 69, 3, 2, 80, 89, 78, 95, 94, 89, 69, 11, 93, 74, 71, 16, 86, 7, 72, 68, 69, 77, 66, 76, 94, 89, 74, 73, 71, 78, 17, 95, 89, 94, 78, 86, 2, 16, 86, 72, 74, 95, 72, 67, 3, 78, 2, 80, 86, 86 }, 43) + _0x77e3fd1c._0x60ee881a(new byte[26] { 15, 14, 13, 67, 27, 25, 4, 31, 4, 71, 76, 30, 24, 14, 25, 42, 12, 14, 5, 31, 76, 71, 30, 10, 66, 80 }, 107) + _0x77e3fd1c._0x60ee881a(new byte[52] { 167, 166, 165, 235, 179, 177, 172, 183, 172, 239, 228, 162, 179, 179, 149, 166, 177, 176, 170, 172, 173, 228, 239, 182, 162, 237, 177, 166, 179, 175, 162, 160, 166, 235, 236, 157, 142, 172, 185, 170, 175, 175, 162, 159, 236, 236, 239, 228, 228, 234, 234, 248 }, 195) + _0x77e3fd1c._0x60ee881a(new byte[37] { 248, 249, 250, 180, 236, 238, 243, 232, 243, 176, 187, 236, 240, 253, 232, 250, 243, 238, 241, 187, 176, 187, 208, 245, 242, 233, 228, 188, 253, 238, 241, 234, 164, 240, 187, 181, 167 }, 156) + _0x77e3fd1c._0x60ee881a(new byte[34] { 104, 105, 106, 36, 124, 126, 99, 120, 99, 32, 43, 122, 105, 98, 104, 99, 126, 43, 32, 43, 75, 99, 99, 107, 96, 105, 44, 69, 98, 111, 34, 43, 37, 55 }, 12) + _0x77e3fd1c._0x60ee881a(new byte[30] { 235, 234, 233, 167, 255, 253, 224, 251, 224, 163, 168, 226, 238, 247, 219, 224, 250, 236, 231, 223, 224, 230, 225, 251, 252, 168, 163, 186, 166, 180 }, 143) + _0x77e3fd1c._0x60ee881a(new byte[48] { 170, 172, 167, 165, 168, 191, 172, 254, 171, 191, 186, 227, 165, 188, 172, 191, 176, 186, 173, 228, 133, 165, 188, 172, 191, 176, 186, 228, 249, 157, 182, 172, 177, 179, 183, 171, 179, 249, 242, 168, 187, 172, 173, 183, 177, 176, 228, 249 }, 222) + _0x730865d6 + _0x77e3fd1c._0x60ee881a(new byte[35] { 60, 102, 55, 96, 121, 105, 122, 117, 127, 33, 60, 92, 116, 116, 124, 119, 126, 59, 88, 115, 105, 116, 118, 126, 60, 55, 109, 126, 105, 104, 114, 116, 117, 33, 60 }, 27) + _0x730865d6 + _0x77e3fd1c._0x60ee881a(new byte[238] { 150, 204, 157, 202, 211, 195, 208, 223, 213, 139, 150, 255, 222, 197, 140, 240, 142, 243, 195, 208, 223, 213, 150, 157, 199, 212, 195, 194, 216, 222, 223, 139, 150, 131, 133, 150, 204, 236, 157, 220, 222, 211, 216, 221, 212, 139, 197, 195, 196, 212, 157, 193, 221, 208, 197, 215, 222, 195, 220, 139, 150, 240, 223, 213, 195, 222, 216, 213, 150, 157, 214, 212, 197, 249, 216, 214, 217, 244, 223, 197, 195, 222, 193, 200, 231, 208, 221, 196, 212, 194, 139, 215, 196, 223, 210, 197, 216, 222, 223, 153, 152, 202, 195, 212, 197, 196, 195, 223, 145, 225, 195, 222, 220, 216, 194, 212, 159, 195, 212, 194, 222, 221, 199, 212, 153, 202, 208, 195, 210, 217, 216, 197, 212, 210, 197, 196, 195, 212, 139, 150, 208, 195, 220, 150, 157, 211, 216, 197, 223, 212, 194, 194, 139, 150, 135, 133, 150, 157, 220, 222, 211, 216, 221, 212, 139, 197, 195, 196, 212, 157, 220, 222, 213, 212, 221, 139, 150, 150, 157, 193, 221, 208, 197, 215, 222, 195, 220, 139, 150, 240, 223, 213, 195, 222, 216, 213, 150, 157, 193, 221, 208, 197, 215, 222, 195, 220, 231, 212, 195, 194, 216, 222, 223, 139, 150, 128, 133, 159, 129, 159, 129, 150, 157, 196, 208, 247, 196, 221, 221, 231, 212, 195, 194, 216, 222, 223, 139, 150 }, 177) + _0x730865d6 + _0x77e3fd1c._0x60ee881a(new byte[117] { 81, 79, 81, 79, 81, 79, 88, 2, 86, 68, 2, 2, 68, 48, 29, 21, 26, 28, 11, 81, 27, 26, 25, 22, 17, 26, 47, 13, 16, 15, 26, 13, 11, 6, 87, 15, 13, 16, 11, 16, 83, 88, 10, 12, 26, 13, 62, 24, 26, 17, 11, 59, 30, 11, 30, 88, 83, 4, 24, 26, 11, 69, 25, 10, 17, 28, 11, 22, 16, 17, 87, 86, 4, 13, 26, 11, 10, 13, 17, 95, 10, 30, 27, 68, 2, 83, 28, 16, 17, 25, 22, 24, 10, 13, 30, 29, 19, 26, 69, 11, 13, 10, 26, 2, 86, 68, 2, 28, 30, 11, 28, 23, 87, 26, 86, 4, 2 }, 127) + _0x77e3fd1c._0x60ee881a(new byte[5] { 81, 5, 4, 5, 23 }, 44);
    }

    private bool _0x2335182e()
    {
        var _0x8254f8f4 = _0x5b881302();
        if (_0x8254f8f4 == null)
            return false;
        WLog(_0x77e3fd1c._0x60ee881a(new byte[31] { 197, 236, 255, 233, 250, 236, 255, 232, 173, 239, 236, 238, 230, 173, 160, 179, 173, 253, 226, 253, 248, 253, 173, 202, 226, 207, 236, 238, 230, 183, 173 }, 141) + _0x8254f8f4.Id);
        _0x8254f8f4.GoBack();
        return true;
    }

    private void OnApplicationFocus(bool _0x61c327f6)
    {
        isApplicationFocus = _0x61c327f6;
        if (_0x61c327f6 && _0x8f4e0496)
        {
            _0x2ada4fb8();
        }
    }

    private int _0xc1460ae7 = -1;
    internal bool IsAboutBlank(string _0xd94275f0)
    {
        if (string.IsNullOrEmpty(_0xd94275f0))
            return false;
        return _0xd94275f0.StartsWith(_0x77e3fd1c._0x60ee881a(new byte[11] { 2, 1, 12, 22, 23, 89, 1, 15, 2, 13, 8 }, 99), StringComparison.OrdinalIgnoreCase);
    }

    private void _0x62c12c6e()
    {
        WLog(_0x77e3fd1c._0x60ee881a(new byte[21] { 69, 108, 127, 105, 122, 108, 127, 104, 45, 111, 108, 110, 102, 45, 125, 127, 104, 126, 126, 104, 105 }, 13));
        if (Time.frameCount == _0xc1460ae7)
            return;
        _0xc1460ae7 = Time.frameCount;
        if (_0xe464c478())
            return;
        _0xb0be0169();
    }

    readonly struct CommState
    {
        public readonly bool Ready;
        public readonly bool IsPrivacy;
        public readonly string SavedLink;
        public CommState(bool _0xddfb082c, bool _0x1da130d2, string _0xc00207d0)
        {
            Ready = _0xddfb082c;
            IsPrivacy = _0x1da130d2;
            SavedLink = _0xc00207d0 ?? "";
        }
    }

    private IEnumerator _0xc567d78e(Dictionary<string, object> _0x46c39f8c)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[30] { 134, 137, 184, 174, 169, 128, 253, 155, 184, 169, 190, 181, 253, 152, 165, 169, 175, 188, 253, 141, 168, 174, 181, 253, 153, 188, 169, 188, 231, 253 }, 221) + string.Join(_0x77e3fd1c._0x60ee881a(new byte[1] { 167 }, 174), _0x46c39f8c));
#endif
            }
        }

        string _0x2e3b8694 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x46c39f8c != null && _0x46c39f8c.TryGetValue(_0x77e3fd1c._0x60ee881a(new byte[16] { 231, 230, 253, 224, 239, 224, 234, 232, 253, 224, 230, 231, 205, 232, 253, 232 }, 137), out var raw))
        {
            try
            {
                var _0x97515774 = raw?.ToString();
                var _0x7ecd67c9 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x97515774);
                if (_0x7ecd67c9 != null && _0x7ecd67c9.TryGetValue(_0x77e3fd1c._0x60ee881a(new byte[6] { 176, 166, 173, 167, 170, 167 }, 195), out var val))
                {
                    _0x2e3b8694 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x77e3fd1c._0x60ee881a(new byte[30] { 171, 164, 149, 131, 132, 208, 160, 133, 131, 152, 173, 208, 186, 163, 191, 190, 208, 128, 145, 130, 131, 149, 208, 149, 130, 130, 159, 130, 202, 208 }, 240) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x2e3b8694) && _0x46c39f8c != null && _0x46c39f8c.TryGetValue(_0x77e3fd1c._0x60ee881a(new byte[6] { 86, 64, 75, 65, 76, 65 }, 37), out var lab))
        {
            _0x2e3b8694 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[38] { 12, 3, 50, 36, 35, 119, 7, 34, 36, 63, 10, 119, 17, 50, 35, 52, 63, 50, 51, 119, 36, 50, 57, 51, 62, 51, 119, 49, 37, 56, 58, 119, 61, 36, 56, 57, 109, 119 }, 87) + _0x2e3b8694);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x2e3b8694))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[38] { 121, 118, 71, 81, 86, 2, 114, 87, 81, 74, 127, 2, 117, 67, 75, 86, 2, 86, 77, 2, 77, 82, 71, 76, 2, 85, 75, 86, 74, 2, 81, 71, 76, 70, 75, 70, 24, 2 }, 34) + _0x2e3b8694);
            }
#endif
        }

        _0xaf4c5f81 = _0x2e3b8694;
        yield return new WaitUntil(() => _0x8f4e0496);
        var _0xd2cb3a43 = _0x26bdc77a(2, 100);
        yield return new WaitUntil(() => _0xd2cb3a43.IsCompleted);
        string _0xc6e1ead0 = _0xd2cb3a43.Result;
        if (!string.IsNullOrEmpty(_0xc6e1ead0))
        {
            string _0x6c80c117 = _0xe8911729(_0xc6e1ead0, _0x2e3b8694);
            {
#if B_LOGS
                Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[33] { 128, 143, 190, 168, 175, 251, 139, 174, 168, 179, 134, 251, 137, 190, 183, 180, 186, 191, 251, 140, 190, 185, 141, 178, 190, 172, 251, 172, 178, 175, 179, 225, 251 }, 219) + _0x6c80c117);
#endif
            }

            _0x324c9723.Load(_0x6c80c117);
        }
    }

    private void _0xebbcfe6b(UniWebView _0x5530a46d)
    {
        _0x5530a46d.BackgroundColor = Color.clear;
        _0x5530a46d.SetSupportMultipleWindows(true, true);
        _0x5530a46d.SetBackButtonEnabled(false);
        _0x324c9723.SetUserAgent(_0x3ee357fa());
    }

    static int[] BuildTextAlphabetIndex()
    {
        var _0x9af9108c = new int[128];
        for (int _0x5ca59bb0 = 0; _0x5ca59bb0 < _0x9af9108c.Length; _0x5ca59bb0++)
            _0x9af9108c[_0x5ca59bb0] = -1;
        for (int _0xdd94d83b = 0; _0xdd94d83b < TextAlphabet.Length; _0xdd94d83b++)
            _0x9af9108c[TextAlphabet[_0xdd94d83b]] = _0xdd94d83b;
        return _0x9af9108c;
    }

    async Task<CommState> _0xe2e253a8()
    {
        var _0xb826a1af = await LeaderboardsService.Instance.GetPlayerScoreAsync(LeaderboardId, new GetPlayerScoreOptions { IncludeMetadata = true });
        var _0x22e738ec = ReadScoreMetadata(_0xb826a1af != null ? _0xb826a1af.Metadata : null);
        if (string.IsNullOrEmpty(_0x22e738ec.isMeta))
            return default;
        var _0xa24463ac = _0x4a95d835(_0x22e738ec.isMeta, _0x2baa9e67);
        if (_0xa24463ac != _0x77e3fd1c._0x60ee881a(new byte[4] { 55, 49, 54, 38 }, 67) && _0xa24463ac != _0x77e3fd1c._0x60ee881a(new byte[5] { 66, 69, 72, 87, 65 }, 36))
            return default;
        var _0xe01ea104 = _0x4a95d835(_0x22e738ec.meta ?? "", _0x2baa9e67);
        return new CommState(true, _0xa24463ac == _0x77e3fd1c._0x60ee881a(new byte[4] { 183, 177, 182, 166 }, 195), _0xe01ea104);
    }

    private string _0xa9eac2c4()
    {
        try
        {
            using (var _0xa860e560 = new AndroidJavaClass(_0x77e3fd1c._0x60ee881a(new byte[30] { 192, 204, 206, 141, 214, 205, 202, 215, 218, 144, 199, 141, 211, 207, 194, 218, 198, 209, 141, 246, 205, 202, 215, 218, 243, 207, 194, 218, 198, 209 }, 163)))
            {
                var _0x690d594d = _0xa860e560.GetStatic<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[15] { 35, 53, 50, 50, 37, 46, 52, 1, 35, 52, 41, 54, 41, 52, 57 }, 64));
                var _0x473b883a = _0x690d594d.Call<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[21] { 154, 152, 137, 188, 141, 141, 145, 148, 158, 156, 137, 148, 146, 147, 190, 146, 147, 137, 152, 133, 137 }, 253));
                using (var _0x91391641 = new AndroidJavaClass(_0x77e3fd1c._0x60ee881a(new byte[26] { 188, 179, 185, 175, 178, 180, 185, 243, 170, 184, 191, 182, 180, 169, 243, 138, 184, 191, 142, 184, 169, 169, 180, 179, 186, 174 }, 221)))
                {
                    return _0x91391641.CallStatic<string>(_0x77e3fd1c._0x60ee881a(new byte[19] { 69, 71, 86, 102, 71, 68, 67, 87, 78, 86, 119, 81, 71, 80, 99, 69, 71, 76, 86 }, 34), _0x473b883a);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    internal bool firstLoadShown = false;
    private bool _0x7e30d8e2(string _0x9f4cf7fb)
    {
        if (string.IsNullOrEmpty(_0x9f4cf7fb))
            return false;
        try
        {
            using (var _0x82d2ab27 = new AndroidJavaClass(_0x77e3fd1c._0x60ee881a(new byte[30] { 253, 241, 243, 176, 235, 240, 247, 234, 231, 173, 250, 176, 238, 242, 255, 231, 251, 236, 176, 203, 240, 247, 234, 231, 206, 242, 255, 231, 251, 236 }, 158)))
            using (var _0x55258a3b = _0x82d2ab27.GetStatic<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[15] { 138, 156, 155, 155, 140, 135, 157, 168, 138, 157, 128, 159, 128, 157, 144 }, 233)))
            using (var _0xa65280a4 = _0x55258a3b.Call<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[17] { 178, 176, 161, 133, 180, 182, 190, 180, 178, 176, 152, 180, 187, 180, 178, 176, 167 }, 213)))
            using (var _0xab3cbea2 = _0xa65280a4.Call<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[25] { 119, 117, 100, 92, 113, 101, 126, 115, 120, 89, 126, 100, 117, 126, 100, 86, 127, 98, 64, 113, 115, 123, 113, 119, 117 }, 16), _0x9f4cf7fb))
            {
                if (_0xab3cbea2 == null)
                    return false;
                WLog(_0x77e3fd1c._0x60ee881a(new byte[37] { 179, 152, 130, 159, 157, 149, 188, 153, 155, 149, 208, 156, 145, 133, 158, 147, 152, 208, 153, 158, 131, 132, 145, 156, 156, 149, 148, 208, 128, 145, 147, 155, 145, 151, 149, 202, 208 }, 240) + _0x9f4cf7fb);
                _0xab3cbea2.Call<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[8] { 55, 50, 50, 16, 58, 55, 49, 37 }, 86), 0x10000000);
                _0x55258a3b.Call(_0x77e3fd1c._0x60ee881a(new byte[13] { 215, 208, 197, 214, 208, 229, 199, 208, 205, 210, 205, 208, 221 }, 164), _0xab3cbea2);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private void _0x35ba8e3c(bool _0xc0671a11)
    {
        _0x565c6f06();
        _0x99ca6651.SetActive(_0xc0671a11);
        _0x0323c0ec = _0xc0671a11;
        if (_0xc0671a11)
        {
            _0x99ca6651.transform.SetAsLastSibling();
            if (_0x1d4f9f52 != null)
                _0x1d4f9f52.localRotation = Quaternion.identity;
        }
    }

    private string _0x2baa9e67 = "";
    private string _0x08a89073()
    {
        return _0x77e3fd1c._0x60ee881a(new byte[12] { 141, 195, 208, 203, 198, 209, 204, 202, 203, 141, 140, 222 }, 165) + _0x77e3fd1c._0x60ee881a(new byte[8] { 244, 227, 240, 162, 247, 227, 191, 165 }, 130) + WindowsDesktopUserAgent + _0x77e3fd1c._0x60ee881a(new byte[2] { 232, 244 }, 207) + _0x77e3fd1c._0x60ee881a(new byte[30] { 106, 125, 110, 60, 108, 110, 115, 104, 115, 33, 82, 125, 106, 117, 123, 125, 104, 115, 110, 50, 108, 110, 115, 104, 115, 104, 101, 108, 121, 39 }, 28) + _0x77e3fd1c._0x60ee881a(new byte[121] { 136, 155, 128, 141, 154, 135, 129, 128, 206, 138, 139, 136, 198, 129, 140, 132, 194, 133, 139, 151, 194, 152, 143, 130, 199, 149, 154, 156, 151, 149, 161, 140, 132, 139, 141, 154, 192, 138, 139, 136, 135, 128, 139, 190, 156, 129, 158, 139, 156, 154, 151, 198, 129, 140, 132, 194, 133, 139, 151, 194, 149, 137, 139, 154, 212, 136, 155, 128, 141, 154, 135, 129, 128, 198, 199, 149, 156, 139, 154, 155, 156, 128, 206, 152, 143, 130, 213, 147, 194, 141, 129, 128, 136, 135, 137, 155, 156, 143, 140, 130, 139, 212, 154, 156, 155, 139, 147, 199, 213, 147, 141, 143, 154, 141, 134, 198, 139, 199, 149, 147, 147 }, 238) + _0x77e3fd1c._0x60ee881a(new byte[26] { 205, 204, 207, 129, 217, 219, 198, 221, 198, 133, 142, 220, 218, 204, 219, 232, 206, 204, 199, 221, 142, 133, 220, 200, 128, 146 }, 169) + _0x77e3fd1c._0x60ee881a(new byte[130] { 145, 144, 147, 221, 133, 135, 154, 129, 154, 217, 210, 148, 133, 133, 163, 144, 135, 134, 156, 154, 155, 210, 217, 210, 192, 219, 197, 213, 221, 162, 156, 155, 145, 154, 130, 134, 213, 187, 161, 213, 196, 197, 219, 197, 206, 213, 162, 156, 155, 195, 193, 206, 213, 141, 195, 193, 220, 213, 180, 133, 133, 153, 144, 162, 144, 151, 190, 156, 129, 218, 192, 198, 194, 219, 198, 195, 213, 221, 190, 189, 161, 184, 185, 217, 213, 153, 156, 158, 144, 213, 178, 144, 150, 158, 154, 220, 213, 182, 157, 135, 154, 152, 144, 218, 196, 199, 197, 219, 197, 219, 197, 219, 197, 213, 166, 148, 147, 148, 135, 156, 218, 192, 198, 194, 219, 198, 195, 210, 220, 206 }, 245) + _0x77e3fd1c._0x60ee881a(new byte[30] { 140, 141, 142, 192, 152, 154, 135, 156, 135, 196, 207, 152, 132, 137, 156, 142, 135, 154, 133, 207, 196, 207, 191, 129, 134, 219, 218, 207, 193, 211 }, 232) + _0x77e3fd1c._0x60ee881a(new byte[34] { 119, 118, 117, 59, 99, 97, 124, 103, 124, 63, 52, 101, 118, 125, 119, 124, 97, 52, 63, 52, 84, 124, 124, 116, 127, 118, 51, 90, 125, 112, 61, 52, 58, 40 }, 19) + _0x77e3fd1c._0x60ee881a(new byte[30] { 167, 166, 165, 235, 179, 177, 172, 183, 172, 239, 228, 174, 162, 187, 151, 172, 182, 160, 171, 147, 172, 170, 173, 183, 176, 228, 239, 243, 234, 248 }, 195) + _0x77e3fd1c._0x60ee881a(new byte[449] { 190, 184, 179, 177, 188, 171, 184, 234, 191, 171, 174, 247, 177, 168, 184, 171, 164, 174, 185, 240, 145, 177, 168, 184, 171, 164, 174, 240, 237, 137, 162, 184, 165, 167, 163, 191, 167, 237, 230, 188, 175, 184, 185, 163, 165, 164, 240, 237, 251, 248, 250, 237, 183, 230, 177, 168, 184, 171, 164, 174, 240, 237, 141, 165, 165, 173, 166, 175, 234, 137, 162, 184, 165, 167, 175, 237, 230, 188, 175, 184, 185, 163, 165, 164, 240, 237, 251, 248, 250, 237, 183, 230, 177, 168, 184, 171, 164, 174, 240, 237, 132, 165, 190, 247, 139, 245, 136, 184, 171, 164, 174, 237, 230, 188, 175, 184, 185, 163, 165, 164, 240, 237, 248, 254, 237, 183, 151, 230, 167, 165, 168, 163, 166, 175, 240, 172, 171, 166, 185, 175, 230, 186, 166, 171, 190, 172, 165, 184, 167, 240, 237, 157, 163, 164, 174, 165, 189, 185, 237, 230, 173, 175, 190, 130, 163, 173, 162, 143, 164, 190, 184, 165, 186, 179, 156, 171, 166, 191, 175, 185, 240, 172, 191, 164, 169, 190, 163, 165, 164, 226, 227, 177, 184, 175, 190, 191, 184, 164, 234, 154, 184, 165, 167, 163, 185, 175, 228, 184, 175, 185, 165, 166, 188, 175, 226, 177, 171, 184, 169, 162, 163, 190, 175, 169, 190, 191, 184, 175, 240, 237, 178, 242, 252, 237, 230, 168, 163, 190, 164, 175, 185, 185, 240, 237, 252, 254, 237, 230, 167, 165, 168, 163, 166, 175, 240, 172, 171, 166, 185, 175, 230, 167, 165, 174, 175, 166, 240, 237, 237, 230, 186, 166, 171, 190, 172, 165, 184, 167, 240, 237, 157, 163, 164, 174, 165, 189, 185, 237, 230, 186, 166, 171, 190, 172, 165, 184, 167, 156, 175, 184, 185, 163, 165, 164, 240, 237, 251, 255, 228, 250, 228, 250, 237, 230, 191, 171, 140, 191, 166, 166, 156, 175, 184, 185, 163, 165, 164, 240, 237, 251, 248, 250, 228, 250, 228, 250, 228, 250, 237, 183, 227, 241, 183, 183, 241, 133, 168, 160, 175, 169, 190, 228, 174, 175, 172, 163, 164, 175, 154, 184, 165, 186, 175, 184, 190, 179, 226, 186, 184, 165, 190, 165, 230, 237, 191, 185, 175, 184, 139, 173, 175, 164, 190, 142, 171, 190, 171, 237, 230, 177, 173, 175, 190, 240, 172, 191, 164, 169, 190, 163, 165, 164, 226, 227, 177, 184, 175, 190, 191, 184, 164, 234, 191, 171, 174, 241, 183, 230, 169, 165, 164, 172, 163, 173, 191, 184, 171, 168, 166, 175, 240, 190, 184, 191, 175, 183, 227, 241, 183, 169, 171, 190, 169, 162, 226, 175, 227, 177, 183 }, 202) + _0x77e3fd1c._0x60ee881a(new byte[112] { 217, 216, 219, 149, 206, 222, 207, 216, 216, 211, 145, 154, 202, 212, 217, 201, 213, 154, 145, 140, 132, 143, 141, 148, 134, 217, 216, 219, 149, 206, 222, 207, 216, 216, 211, 145, 154, 213, 216, 212, 218, 213, 201, 154, 145, 140, 141, 133, 141, 148, 134, 217, 216, 219, 149, 206, 222, 207, 216, 216, 211, 145, 154, 220, 203, 220, 212, 209, 234, 212, 217, 201, 213, 154, 145, 140, 132, 143, 141, 148, 134, 217, 216, 219, 149, 206, 222, 207, 216, 216, 211, 145, 154, 220, 203, 220, 212, 209, 245, 216, 212, 218, 213, 201, 154, 145, 140, 141, 137, 141, 148, 134 }, 189) + _0x77e3fd1c._0x60ee881a(new byte[45] { 213, 211, 216, 218, 214, 200, 207, 197, 206, 214, 143, 206, 207, 213, 206, 212, 194, 201, 210, 213, 192, 211, 213, 156, 212, 207, 197, 196, 199, 200, 207, 196, 197, 154, 220, 194, 192, 213, 194, 201, 137, 196, 136, 218, 220 }, 161) + _0x77e3fd1c._0x60ee881a(new byte[721] { 6, 0, 11, 9, 4, 19, 0, 82, 29, 0, 27, 21, 79, 5, 27, 28, 22, 29, 5, 92, 31, 19, 6, 17, 26, 63, 23, 22, 27, 19, 92, 16, 27, 28, 22, 90, 5, 27, 28, 22, 29, 5, 91, 73, 5, 27, 28, 22, 29, 5, 92, 31, 19, 6, 17, 26, 63, 23, 22, 27, 19, 79, 20, 7, 28, 17, 6, 27, 29, 28, 90, 3, 91, 9, 4, 19, 0, 82, 1, 79, 33, 6, 0, 27, 28, 21, 90, 3, 91, 92, 6, 29, 62, 29, 5, 23, 0, 49, 19, 1, 23, 90, 91, 73, 27, 20, 90, 1, 92, 27, 28, 22, 23, 10, 61, 20, 90, 85, 2, 29, 27, 28, 6, 23, 0, 72, 82, 17, 29, 19, 0, 1, 23, 85, 91, 76, 79, 66, 14, 14, 1, 92, 27, 28, 22, 23, 10, 61, 20, 90, 85, 26, 29, 4, 23, 0, 72, 82, 28, 29, 28, 23, 85, 91, 76, 79, 66, 14, 14, 1, 92, 27, 28, 22, 23, 10, 61, 20, 90, 85, 31, 19, 10, 95, 5, 27, 22, 6, 26, 85, 91, 76, 79, 66, 14, 14, 1, 92, 27, 28, 22, 23, 10, 61, 20, 90, 85, 31, 19, 10, 95, 22, 23, 4, 27, 17, 23, 95, 5, 27, 22, 6, 26, 85, 91, 76, 79, 66, 91, 0, 23, 6, 7, 0, 28, 82, 9, 31, 19, 6, 17, 26, 23, 1, 72, 20, 19, 30, 1, 23, 94, 31, 23, 22, 27, 19, 72, 3, 94, 29, 28, 17, 26, 19, 28, 21, 23, 72, 28, 7, 30, 30, 94, 19, 22, 22, 62, 27, 1, 6, 23, 28, 23, 0, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 15, 94, 0, 23, 31, 29, 4, 23, 62, 27, 1, 6, 23, 28, 23, 0, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 15, 94, 19, 22, 22, 55, 4, 23, 28, 6, 62, 27, 1, 6, 23, 28, 23, 0, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 15, 94, 0, 23, 31, 29, 4, 23, 55, 4, 23, 28, 6, 62, 27, 1, 6, 23, 28, 23, 0, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 15, 94, 22, 27, 1, 2, 19, 6, 17, 26, 55, 4, 23, 28, 6, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 0, 23, 6, 7, 0, 28, 82, 20, 19, 30, 1, 23, 73, 15, 15, 73, 27, 20, 90, 1, 92, 27, 28, 22, 23, 10, 61, 20, 90, 85, 2, 29, 27, 28, 6, 23, 0, 72, 82, 20, 27, 28, 23, 85, 91, 76, 79, 66, 14, 14, 1, 92, 27, 28, 22, 23, 10, 61, 20, 90, 85, 26, 29, 4, 23, 0, 72, 82, 26, 29, 4, 23, 0, 85, 91, 76, 79, 66, 91, 0, 23, 6, 7, 0, 28, 82, 9, 31, 19, 6, 17, 26, 23, 1, 72, 6, 0, 7, 23, 94, 31, 23, 22, 27, 19, 72, 3, 94, 29, 28, 17, 26, 19, 28, 21, 23, 72, 28, 7, 30, 30, 94, 19, 22, 22, 62, 27, 1, 6, 23, 28, 23, 0, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 15, 94, 0, 23, 31, 29, 4, 23, 62, 27, 1, 6, 23, 28, 23, 0, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 15, 94, 19, 22, 22, 55, 4, 23, 28, 6, 62, 27, 1, 6, 23, 28, 23, 0, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 15, 94, 0, 23, 31, 29, 4, 23, 55, 4, 23, 28, 6, 62, 27, 1, 6, 23, 28, 23, 0, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 15, 94, 22, 27, 1, 2, 19, 6, 17, 26, 55, 4, 23, 28, 6, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 0, 23, 6, 7, 0, 28, 82, 20, 19, 30, 1, 23, 73, 15, 15, 73, 0, 23, 6, 7, 0, 28, 82, 29, 0, 27, 21, 90, 3, 91, 73, 15, 73, 15, 17, 19, 6, 17, 26, 90, 23, 91, 9, 15 }, 114) + _0x77e3fd1c._0x60ee881a(new byte[5] { 253, 169, 168, 169, 187 }, 128);
    }

    private bool _0x24c3609b = false;
    static readonly string LeaderboardId = _0x77e3fd1c._0x60ee881a(new byte[1] { 254 }, 206);
    private void _0xb453e2d2(string _0x84dfa35b)
    {
        Dictionary<string, object> _0xef43bddc;
        try
        {
            _0xef43bddc = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x84dfa35b);
        }
        catch
        {
            return;
        }

        var _0xb2a48fe0 = ReadPushField(_0xef43bddc, _0x77e3fd1c._0x60ee881a(new byte[3] { 77, 74, 84 }, 56));
        if (string.IsNullOrWhiteSpace(_0xb2a48fe0))
            return;
        _0xb2a48fe0 = _0xb2a48fe0.Trim();
        if (!IsHttpUrl(_0xb2a48fe0))
            return;
        if (string.Equals(_0xb2a48fe0, _0x7fe3c753, StringComparison.Ordinal))
            return;
        _0x7fe3c753 = _0xb2a48fe0;
        OpenUrlExternally(_0xb2a48fe0);
    }

    private IEnumerator _0x6afed5bd(float _0x7788ab04)
    {
        yield return new WaitForSeconds(_0x7788ab04);
        if (!_0xcaf2ae5c)
        {
            _0xcaf2ae5c = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x8e5d46cf}");
                }
#endif
            }
        }
    }

    private bool _0xbcd61f9e = false;
    static System.IO.Compression.CompressionLevel SmallestCompression()
    {
        return Enum.IsDefined(typeof(System.IO.Compression.CompressionLevel), 3) ? (System.IO.Compression.CompressionLevel)3 : System.IO.Compression.CompressionLevel.Optimal;
    }

    private void _0x35f28e12()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private string _0x4c861003 = "";
    private string _0x7fe3c753;
    private void _0x2ada4fb8()
    {
        using (var _0x74b4a73d = new AndroidJavaClass(_0x77e3fd1c._0x60ee881a(new byte[30] { 106, 102, 100, 39, 124, 103, 96, 125, 112, 58, 109, 39, 121, 101, 104, 112, 108, 123, 39, 92, 103, 96, 125, 112, 89, 101, 104, 112, 108, 123 }, 9)))
        using (var _0x26d7db1d = _0x74b4a73d.GetStatic<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[15] { 236, 250, 253, 253, 234, 225, 251, 206, 236, 251, 230, 249, 230, 251, 246 }, 143)))
        using (var _0x82150eb0 = _0x26d7db1d.Call<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[9] { 231, 229, 244, 201, 238, 244, 229, 238, 244 }, 128)))
        {
            if (_0x82150eb0 == null)
                return;
            using (var _0xb9865df9 = _0x82150eb0.Call<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[9] { 31, 29, 12, 61, 0, 12, 10, 25, 11 }, 120)))
            {
                if (_0xb9865df9 == null)
                    return;
                using (var _0x341856a2 = new AndroidJavaObject(_0x77e3fd1c._0x60ee881a(new byte[19] { 39, 58, 47, 102, 34, 59, 39, 38, 102, 2, 27, 7, 6, 7, 42, 34, 45, 43, 60 }, 72)))
                using (var _0xbb923f11 = _0xb9865df9.Call<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[6] { 128, 142, 146, 184, 142, 159 }, 235)))
                using (var _0x39bb7023 = _0xbb923f11.Call<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[8] { 246, 235, 250, 237, 254, 235, 240, 237 }, 159)))
                {
                    while (_0x39bb7023.Call<bool>(_0x77e3fd1c._0x60ee881a(new byte[7] { 117, 124, 110, 83, 120, 101, 105 }, 29)))
                    {
                        string _0x252a973e = _0x39bb7023.Call<string>(_0x77e3fd1c._0x60ee881a(new byte[4] { 188, 183, 170, 166 }, 210));
                        using (var _0x0de3323b = _0xb9865df9.Call<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[3] { 58, 56, 41 }, 93), _0x252a973e))
                        {
                            _0x341856a2.Call<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[3] { 253, 248, 249 }, 141), _0x252a973e, _0x0de3323b);
                        }
                    }

                    string _0x293fe375 = _0x341856a2.Call<string>(_0x77e3fd1c._0x60ee881a(new byte[8] { 214, 205, 241, 214, 208, 203, 204, 197 }, 162));
                    if (!string.IsNullOrEmpty(_0x293fe375))
                    {
                        _0xb453e2d2(_0x293fe375);
                        _0x181da240(_0x293fe375);
                    }
                }
            }
        }
    }

    private async Task<bool> _0xe3a35823()
    {
        {
#if B_LOGS
            Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[37] { 214, 217, 232, 254, 249, 208, 173, 222, 228, 234, 227, 196, 227, 216, 227, 228, 249, 244, 222, 232, 255, 251, 228, 238, 232, 254, 204, 227, 226, 227, 244, 224, 226, 248, 254, 225, 244 }, 141));
#endif
        }

        try
        {
            var _0x97e2bce9 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x97e2bce9);
            {
#if B_LOGS
                Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[32] { 167, 168, 153, 143, 136, 161, 220, 169, 146, 149, 136, 133, 175, 153, 142, 138, 149, 159, 153, 143, 220, 181, 146, 149, 136, 149, 157, 144, 149, 134, 153, 152 }, 252));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[20] { 191, 174, 184, 191, 203, 190, 133, 130, 159, 146, 184, 142, 153, 157, 130, 136, 142, 152, 209, 203 }, 235) + ex.Message);
#endif
            }

            _0x4eb01ff6?._0xb70ad93d();
            return true;
        }

        bool _0xfc157cf5 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0xfc157cf5 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[37] { 2, 13, 60, 42, 45, 4, 121, 10, 48, 62, 55, 116, 48, 55, 121, 24, 55, 54, 55, 32, 52, 54, 44, 42, 119, 121, 9, 53, 56, 32, 60, 43, 121, 16, 29, 99, 121 }, 89) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x2baa9e67 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[25] { 176, 161, 183, 176, 196, 183, 141, 131, 138, 201, 141, 138, 196, 165, 145, 144, 140, 196, 161, 182, 182, 171, 182, 222, 196 }, 228) + ex.Message);
#endif
                }

                _0x4eb01ff6?._0xb70ad93d();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[28] { 75, 90, 76, 75, 63, 76, 118, 120, 113, 50, 118, 113, 63, 77, 122, 110, 106, 122, 108, 107, 63, 90, 77, 77, 80, 77, 37, 63 }, 31) + ex.Message);
#endif
                }

                _0x4eb01ff6?._0xb70ad93d();
                return true;
            }
        }
        while (!_0xfc157cf5);
        return false;
    }

    private Canvas _0xe6863624;
    private void _0xb0be0169()
    {
        if (_0xecbc6427)
        {
            WLog(_0x77e3fd1c._0x60ee881a(new byte[18] { 43, 22, 7, 26, 78, 15, 2, 28, 11, 15, 10, 23, 78, 29, 6, 1, 25, 0 }, 110));
            return;
        }

        _0x35ba8e3c(false);
        WLog(_0x77e3fd1c._0x60ee881a(new byte[46] { 25, 53, 61, 58, 116, 3, 49, 54, 2, 61, 49, 35, 116, 4, 33, 39, 60, 116, 26, 59, 32, 61, 50, 61, 55, 53, 32, 61, 59, 58, 116, 124, 60, 53, 38, 48, 35, 53, 38, 49, 116, 54, 53, 55, 63, 125 }, 84));
        ++_0xa8ed203b;
        _0xfec72ba0();
        if (_0xa8ed203b <= 1)
            return;
        if (_0xb7155f8f())
        {
            WLog(_0x77e3fd1c._0x60ee881a(new byte[37] { 121, 68, 85, 72, 28, 79, 87, 85, 76, 76, 89, 88, 28, 17, 2, 28, 76, 83, 76, 73, 76, 79, 28, 79, 72, 85, 80, 80, 28, 83, 76, 89, 82, 89, 88, 6, 28 }, 60) + _0xb10e3fc8.Count);
            return;
        }

        Application.Quit();
    }

    private IEnumerator _0x6a6d11ea(string _0xf9ff9b6b)
    {
        if (Permission.HasUserAuthorizedPermission(_0xf9ff9b6b))
            yield break;
        bool _0xf605c68a = false;
        var _0xd8cd8db4 = new PermissionCallbacks();
        _0xd8cd8db4.PermissionGranted += _0x38f8bd22 => _0xf605c68a = true;
        _0xd8cd8db4.PermissionDenied += _0x38f8bd22 => _0xf605c68a = true;
        Permission.RequestUserPermission(_0xf9ff9b6b, _0xd8cd8db4);
        yield return new WaitUntil(() => _0xf605c68a);
    }

    internal void _0xe2421f1b()
    {
        Rect _0x59a04219 = Screen.safeArea;
        Vector2 _0xb6a3d9ca = new Vector2(Screen.width, Screen.height);
        if (_0x59a04219 == lastSafe && _0xb6a3d9ca == lastSize)
            return;
        // Apply manual padding
        _0x59a04219.xMin += _0x84fbadac;
        _0x59a04219.xMax -= _0x5201338c;
        _0x59a04219.yMin += _0x59f19325;
        _0x59a04219.yMax -= _0xf377ce83;
        // Convert Unity safe area -> native WebView frame
        Rect _0x756a579a = new Rect(_0x59a04219.x, _0xb6a3d9ca.y - _0x59a04219.y - _0x59a04219.height, // Y flip for native coordinate system
 _0x59a04219.width, _0x59a04219.height);
        _0x324c9723.Frame = _0x756a579a;
        lastSafe = Screen.safeArea;
        lastSize = _0xb6a3d9ca;
    }

    public void _0xf53d361b()
    {
        if (_0x8f4e0496)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[33] { 104, 103, 86, 64, 71, 110, 19, 103, 90, 94, 86, 65, 19, 92, 70, 71, 19, 30, 13, 19, 94, 92, 69, 86, 19, 71, 92, 19, 64, 80, 86, 93, 86 }, 51));
            }
#endif
        }

        _0xb70ad93d();
    }

    // WS_SOURCE MONO
    public static _0xdd507af9 _0x4eb01ff6 { get; private set; }

    private string _0x218f14ff(string _0x3936476d, string _0x6cd8ba23)
    {
        try
        {
            var _0x150b2240 = Encoding.UTF8.GetBytes(_0x3936476d ?? "");
            var _0xa9289c47 = PackSmallest(_0x150b2240, out var mode);
            var _0x8583718f = new byte[4];
            using (var _0x3c5e3fd2 = RandomNumberGenerator.Create())
                _0x3c5e3fd2.GetBytes(_0x8583718f);
            var _0x9d86ee7b = new byte[1 + _0xa9289c47.Length];
            _0x9d86ee7b[0] = mode;
            Buffer.BlockCopy(_0xa9289c47, 0, _0x9d86ee7b, 1, _0xa9289c47.Length);
            var _0xdc55f7d4 = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x6cd8ba23 ?? ""));
            var _0x20a0c869 = AesCtr(_0x9d86ee7b, _0xdc55f7d4, _0x8583718f);
            var _0x7b206065 = new byte[_0x8583718f.Length + _0x20a0c869.Length];
            Buffer.BlockCopy(_0x8583718f, 0, _0x7b206065, 0, _0x8583718f.Length);
            Buffer.BlockCopy(_0x20a0c869, 0, _0x7b206065, _0x8583718f.Length, _0x20a0c869.Length);
            return Encode93(_0x7b206065);
        }
        catch (Exception)
        {
            return "";
        }
    }

    internal bool ContainsIgnoreCase(string _0x3b322331, string _0x77291e1e)
    {
        if (string.IsNullOrEmpty(_0x3b322331) || string.IsNullOrEmpty(_0x77291e1e))
            return false;
        return _0x3b322331.IndexOf(_0x77291e1e, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal bool IsGoogleAuthFlowUrl(string _0x4588c09f)
    {
        if (string.IsNullOrEmpty(_0x4588c09f))
            return false;
        return _0x4588c09f.IndexOf(_0x77e3fd1c._0x60ee881a(new byte[19] { 82, 80, 80, 92, 70, 93, 71, 64, 29, 84, 92, 92, 84, 95, 86, 29, 80, 92, 94 }, 51), StringComparison.OrdinalIgnoreCase) >= 0 || _0x4588c09f.IndexOf(_0x77e3fd1c._0x60ee881a(new byte[16] { 44, 46, 46, 34, 56, 35, 57, 62, 99, 42, 34, 34, 42, 33, 40, 99 }, 77), StringComparison.OrdinalIgnoreCase) >= 0 || _0x4588c09f.IndexOf(_0x77e3fd1c._0x60ee881a(new byte[21] { 92, 84, 84, 92, 87, 94, 78, 72, 94, 73, 88, 84, 85, 79, 94, 85, 79, 21, 88, 84, 86 }, 59), StringComparison.OrdinalIgnoreCase) >= 0 || _0x4588c09f.IndexOf(_0x77e3fd1c._0x60ee881a(new byte[11] { 214, 194, 197, 208, 197, 216, 210, 159, 210, 222, 220 }, 177), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private bool _0xecbc6427 = false;
    // PART 3
    private string _0x9165c405()
    {
        try
        {
            var _0xb36047b8 = new AndroidJavaClass(_0x77e3fd1c._0x60ee881a(new byte[30] { 189, 177, 179, 240, 171, 176, 183, 170, 167, 237, 186, 240, 174, 178, 191, 167, 187, 172, 240, 139, 176, 183, 170, 167, 142, 178, 191, 167, 187, 172 }, 222));
            var _0xebd94f17 = _0xb36047b8.GetStatic<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[15] { 22, 0, 7, 7, 16, 27, 1, 52, 22, 1, 28, 3, 28, 1, 12 }, 117));
            var _0x86149577 = new AndroidJavaClass(_0x77e3fd1c._0x60ee881a(new byte[57] { 35, 47, 45, 110, 39, 47, 47, 39, 44, 37, 110, 33, 46, 36, 50, 47, 41, 36, 110, 39, 45, 51, 110, 33, 36, 51, 110, 41, 36, 37, 46, 52, 41, 38, 41, 37, 50, 110, 1, 36, 54, 37, 50, 52, 41, 51, 41, 46, 39, 9, 36, 3, 44, 41, 37, 46, 52 }, 64));
            var _0xafbbd911 = _0x86149577.CallStatic<AndroidJavaObject>(_0x77e3fd1c._0x60ee881a(new byte[20] { 90, 88, 73, 124, 89, 75, 88, 79, 73, 84, 78, 84, 83, 90, 116, 89, 116, 83, 91, 82 }, 61), _0xebd94f17);
            var _0x0203e869 = _0xafbbd911.Call<string>(_0x77e3fd1c._0x60ee881a(new byte[5] { 200, 202, 219, 230, 203 }, 175));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x0203e869}");
#endif
            }

            return string.IsNullOrEmpty(_0x0203e869) ? "" : _0x0203e869;
        }
        catch
        {
            return "";
        }
    }

    private string _0x7a43fe03 = "";
    private static string ReadPushField(Dictionary<string, object> _0x853c0620, string _0x7df32049)
    {
        if (_0x853c0620 == null || string.IsNullOrEmpty(_0x7df32049))
            return string.Empty;
        if (_0x853c0620.TryGetValue(_0x77e3fd1c._0x60ee881a(new byte[16] { 112, 113, 106, 119, 120, 119, 125, 127, 106, 119, 113, 112, 90, 127, 106, 127 }, 30), out var raw))
        {
            try
            {
                var _0x5c40d437 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x5c40d437 != null && _0x5c40d437.TryGetValue(_0x7df32049, out var nestedVal))
                {
                    var _0xf3242432 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0xf3242432))
                        return _0xf3242432;
                }
            }
            catch
            {
            }
        }

        if (_0x853c0620.TryGetValue(_0x7df32049, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private int _0xf377ce83 = 5, _0x59f19325 = 5, _0x84fbadac = 5, _0x5201338c = 5;
    private string _0x64b1962c = "";
    private void OnDestroy()
    {
        StopAllCoroutines();
        _0xb70ad93d();
    }

    internal Vector2 lastSize = Vector2.zero;
    static byte[] DecompressDeflate(byte[] _0x19d0d6d3)
    {
        using var _0x17c1ebef = new MemoryStream(_0x19d0d6d3);
        using var _0x059d5bac = new DeflateStream(_0x17c1ebef, CompressionMode.Decompress);
        using var _0xbd5c9729 = new MemoryStream();
        _0x059d5bac.CopyTo(_0xbd5c9729);
        return _0xbd5c9729.ToArray();
    }

    static byte[] CompressBrotli(byte[] _0xf2b9b667)
    {
        using var _0x1a5ce11a = new MemoryStream();
        using (var _0x83a2310c = new BrotliStream(_0x1a5ce11a, SmallestCompression()))
            _0x83a2310c.Write(_0xf2b9b667, 0, _0xf2b9b667.Length);
        return _0x1a5ce11a.ToArray();
    }

    private bool _0xbf64af02 = false;
    private string _0xd3693ed9 = "";
    async Task _0x323abc28(string _0xcf9884e6, double _0x324150db, string _0x63097ddb)
    {
        var _0x0b356eab = new _0xb0480650
        {
            payload = _0x63097ddb ?? ""
        };
        if (_0x324150db != 1d)
        {
            try
            {
                var _0xe7607428 = await LeaderboardsService.Instance.GetPlayerScoreAsync(_0xcf9884e6, new GetPlayerScoreOptions { IncludeMetadata = true });
                var _0xde14bd8e = ReadScoreMetadata(_0xe7607428 != null ? _0xe7607428.Metadata : null);
                if (!string.IsNullOrEmpty(_0xde14bd8e.isMeta) || !string.IsNullOrEmpty(_0xde14bd8e.meta))
                {
                    _0x0b356eab.isMeta = _0xde14bd8e.isMeta;
                    _0x0b356eab.meta = _0xde14bd8e.meta;
                }
            }
            catch (Exception)
            {
            }
        }

        await LeaderboardsService.Instance.AddPlayerScoreAsync(_0xcf9884e6, _0x324150db, new AddPlayerScoreOptions { Metadata = _0x0b356eab });
    }

    private string _0xd0d1168b = "";
    private bool OpenUrlExternally(string _0x4b7ada62)
    {
        return _0x09ae64e5(_0x4b7ada62);
    }

    private bool IsSslError(int _0x3d7764da, string _0xa8fe773a)
    {
        if (_0x3d7764da == -1202 || _0x3d7764da == -1200 || _0x3d7764da == -11 || _0x3d7764da == -202)
            return true;
        if (string.IsNullOrEmpty(_0xa8fe773a))
            return false;
        return _0xa8fe773a.IndexOf(_0x77e3fd1c._0x60ee881a(new byte[3] { 79, 79, 80 }, 28), StringComparison.OrdinalIgnoreCase) >= 0 || _0xa8fe773a.IndexOf(_0x77e3fd1c._0x60ee881a(new byte[11] { 253, 251, 236, 234, 247, 248, 247, 253, 255, 234, 251 }, 158), StringComparison.OrdinalIgnoreCase) >= 0 || _0xa8fe773a.IndexOf(_0x77e3fd1c._0x60ee881a(new byte[4] { 68, 66, 85, 83 }, 7), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x31f864cc()
    {
        var _0x9cd96d74 = _0x77e3fd1c._0x60ee881a(new byte[40] { 10, 22, 22, 18, 17, 88, 77, 77, 21, 21, 21, 76, 1, 14, 13, 23, 6, 4, 14, 3, 16, 7, 76, 1, 13, 15, 77, 1, 6, 12, 79, 1, 5, 11, 77, 22, 16, 3, 1, 7 }, 98);
        using (UnityWebRequest _0x9db5a4d3 = UnityWebRequest.Get(_0x9cd96d74))
        {
            await _0x9db5a4d3.SendWebRequest();
            string[] _0x7e3aa641 = _0x9db5a4d3.downloadHandler.text.Split('\n');
            foreach (string _0x17db5c4e in _0x7e3aa641)
            {
                if (_0x17db5c4e.StartsWith(_0x77e3fd1c._0x60ee881a(new byte[3] { 189, 164, 233 }, 212)))
                {
                    string _0x58e6a64b = _0x17db5c4e.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x58e6a64b} from {_0x9cd96d74}");
                        }
#endif
                    }

                    return _0x58e6a64b;
                }
            }
        }

        return "";
    }

    private void MarkMainFrameCommitted(string _0x5360f1d1)
    {
        _0xd94eebfa = true;
        string _0x9158646a = GetUrlHost(_0x5360f1d1);
        if (!string.IsNullOrEmpty(_0x9158646a))
            _0xafdb3aab = _0x9158646a;
    }

    private async Task _0xd2e74689()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x8208e484 = _0x77e3fd1c._0x60ee881a(new byte[5] { 74, 77, 64, 95, 73 }, 44);
        _0x7a43fe03 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0xd82510cd = DateTime.UtcNow.Ticks.ToString();
        _0x99532399 = "";
        JObject _0x6b5edc38 = _0x7cf29759(_0x10e2e194, _0x2436bb38, _0x49775885, _0x8e5d46cf, _0x2e20f7ae, _0xd8ec734a, _0x64b1962c, _0x73c6d8f4, _0xe04e6286, _0x8208e484, _0xd3693ed9, _0x0d4f9ce8, _0x6170e5ae.ToString(), _0xd0d1168b, _0xd82510cd, _0x2baa9e67, _0x6f1ab94d, _0x4c861003, _0xa5615324, _0xda1e9fb2());
        var _0xa826489b = _0x218f14ff(_0x6b5edc38.ToString(), _0x2baa9e67);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x6b5edc38}");
            }
#endif
        }

        try
        {
            await _0x323abc28(LeaderboardId, 1d, _0xa826489b);
            await Task.Delay(500);
            string _0xea8e0f24 = "";
            for (int _0x4fb75c38 = 0; _0x4fb75c38 < 20; _0x4fb75c38++)
            {
                if (await _0x8d79d238(1, 1))
                {
                    await _0x6768c973(_0x77e3fd1c._0x60ee881a(new byte[7] { 63, 49, 50, 62, 54, 56, 57 }, 93));
                    _0xb70ad93d();
                    return;
                }

                _0xea8e0f24 = await _0x26bdc77a(1, 500);
                if (!string.IsNullOrEmpty(_0xea8e0f24))
                    break;
            }

            _0xf4a7ba9e(_0xea8e0f24);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[22] { 205, 194, 211, 197, 194, 203, 182, 209, 243, 248, 243, 228, 247, 250, 182, 243, 228, 228, 249, 228, 172, 182 }, 150) + e.Message);
#endif
            }

            _0xb70ad93d();
        }
    }

    internal void Update()
    {
        if (_0x324c9723 == null)
            return;
        if (_0xe8c75daf())
            _0x62c12c6e();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xe2421f1b();
        if (_0x0323c0ec && _0x1d4f9f52 != null)
            _0x1d4f9f52.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private AndroidJavaObject _0x107e25c0 { get; set; }

    static byte[] AesCtr(byte[] _0x185a8dc2, byte[] _0xca889cec, byte[] _0x34b3ce3f)
    {
        using var _0x8bd9bb34 = Aes.Create();
        _0x8bd9bb34.Mode = CipherMode.ECB;
        _0x8bd9bb34.Padding = PaddingMode.None;
        _0x8bd9bb34.Key = _0xca889cec;
        using var _0xdcad0e0b = _0x8bd9bb34.CreateEncryptor();
        var _0x30b5ebe9 = new byte[_0x185a8dc2.Length];
        var _0xb23d597e = new byte[16];
        var _0xd0b79e1b = new byte[16];
        Buffer.BlockCopy(_0x34b3ce3f, 0, _0xb23d597e, 0, 4);
        int _0x0e46b860 = 0;
        while (_0x0e46b860 < _0x185a8dc2.Length)
        {
            if (_0xdcad0e0b.TransformBlock(_0xb23d597e, 0, 16, _0xd0b79e1b, 0) != 16)
                throw new CryptographicException();
            int n = Math.Min(16, _0x185a8dc2.Length - _0x0e46b860);
            for (int _0x7f822d8d = 0; _0x7f822d8d < n; _0x7f822d8d++)
                _0x30b5ebe9[_0x0e46b860 + _0x7f822d8d] = (byte)(_0x185a8dc2[_0x0e46b860 + _0x7f822d8d] ^ _0xd0b79e1b[_0x7f822d8d]);
            for (int _0xf7a9c2b0 = _0xb23d597e.Length - 1; _0xf7a9c2b0 >= 4; _0xf7a9c2b0--)
            {
                _0xb23d597e[_0xf7a9c2b0]++;
                if (_0xb23d597e[_0xf7a9c2b0] != 0)
                    break;
            }

            _0x0e46b860 += n;
        }

        return _0x30b5ebe9;
    }

    internal bool isApplicationFocus = false;
    private void _0x565c6f06()
    {
        if (_0x99ca6651 != null)
            return;
        var _0x4680207a = _0x1f7fd9dd();
        _0x99ca6651 = new GameObject(_0x77e3fd1c._0x60ee881a(new byte[14] { 102, 84, 83, 103, 88, 84, 70, 98, 65, 88, 95, 95, 84, 67 }, 49), typeof(RectTransform), typeof(Text));
        _0x1d4f9f52 = _0x99ca6651.GetComponent<RectTransform>();
        _0x1d4f9f52.SetParent(_0x4680207a.transform, false);
        _0x1d4f9f52.anchorMin = new Vector2(0.5f, 0.5f);
        _0x1d4f9f52.anchorMax = new Vector2(0.5f, 0.5f);
        _0x1d4f9f52.pivot = new Vector2(0.5f, 0.5f);
        _0x1d4f9f52.sizeDelta = new Vector2(600f, 600f);
        _0x1d4f9f52.anchoredPosition = Vector2.zero;
        _0x21c1475e = _0x99ca6651.GetComponent<Text>();
        _0x21c1475e.text = _0x77e3fd1c._0x60ee881a(new byte[1] { 210 }, 253);
        _0x21c1475e.font = Resources.GetBuiltinResource<Font>(_0x77e3fd1c._0x60ee881a(new byte[17] { 81, 120, 122, 124, 126, 100, 79, 104, 115, 105, 116, 112, 120, 51, 105, 105, 123 }, 29));
        _0x21c1475e.fontSize = 200;
        _0x21c1475e.alignment = TextAnchor.MiddleCenter;
        _0x21c1475e.color = Color.white;
        _0x21c1475e.raycastTarget = false;
        _0x99ca6651.SetActive(false);
    }

    private string _0xa5615324 = "";
    internal bool IsHttpUrl(string _0x9883ba0b)
    {
        if (string.IsNullOrEmpty(_0x9883ba0b))
            return false;
        return _0x9883ba0b.StartsWith(_0x77e3fd1c._0x60ee881a(new byte[7] { 36, 56, 56, 60, 118, 99, 99 }, 76), StringComparison.OrdinalIgnoreCase) || _0x9883ba0b.StartsWith(_0x77e3fd1c._0x60ee881a(new byte[8] { 0, 28, 28, 24, 27, 82, 71, 71 }, 104), StringComparison.OrdinalIgnoreCase);
    }

    private void Awake()
    {
        if (_0x4eb01ff6 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x4eb01ff6 = gameObject.GetComponent<_0xdd507af9>();
        DontDestroyOnLoad(gameObject);
        _0x49775885 = _0x2e20f7ae = _0xd8ec734a = "";
        _0x46d23418 = "";
        _0x8f4e0496 = false;
    }

    private string _0x3e8b650a = "";
    private void StopCurrentFailedLoad(UniWebView _0xf0f983ca)
    {
        _0x35ba8e3c(false);
        if (_0xf0f983ca == null)
            return;
        _0xf0f983ca.Stop();
        if (_0xf0f983ca.CanGoBack)
            _0xf0f983ca.GoBack();
    }

    private bool _0x1cffc1fb = false;
    internal bool _0x8e21def3(string _0x72923398)
    {
        return _0x72923398.StartsWith(_0x77e3fd1c._0x60ee881a(new byte[9] { 43, 39, 52, 45, 35, 50, 124, 105, 105 }, 70), StringComparison.OrdinalIgnoreCase) || _0x72923398.StartsWith(_0x77e3fd1c._0x60ee881a(new byte[24] { 236, 240, 240, 244, 247, 190, 171, 171, 244, 232, 229, 253, 170, 227, 235, 235, 227, 232, 225, 170, 231, 235, 233, 171 }, 132), StringComparison.OrdinalIgnoreCase) || _0x72923398.StartsWith(_0x77e3fd1c._0x60ee881a(new byte[23] { 174, 178, 178, 182, 252, 233, 233, 182, 170, 167, 191, 232, 161, 169, 169, 161, 170, 163, 232, 165, 169, 171, 233 }, 198), StringComparison.OrdinalIgnoreCase);
    }

    internal string _0xf2db617f(string _0xf15d203b)
    {
        int _0x2044c8b0 = _0xf15d203b.IndexOf(_0x77e3fd1c._0x60ee881a(new byte[3] { 180, 185, 224 }, 221), StringComparison.OrdinalIgnoreCase);
        if (_0x2044c8b0 < 0)
            return null;
        string _0x5a493a7d = _0xf15d203b.Substring(_0x2044c8b0 + 3);
        int _0x83498f11 = _0x5a493a7d.IndexOf('&');
        return _0x83498f11 >= 0 ? _0x5a493a7d.Substring(0, _0x83498f11) : _0x5a493a7d;
    }

    private bool _0x865004a6 = false;
    private void _0x2bcc7b8c()
    {
        _0xbcd61f9e = true;
        if (_0x324c9723 != null)
            _0x324c9723.SetUserAgent(_0x3ee357fa());
    }

    private Canvas _0x1f7fd9dd()
    {
        if (_0xe6863624 != null)
            return _0xe6863624;
        var _0x034530f7 = gameObject.GetComponentInChildren<Canvas>();
        if (_0x034530f7 == null)
        {
            var _0x99c6a875 = new GameObject(_0x77e3fd1c._0x60ee881a(new byte[6] { 38, 4, 11, 19, 4, 22 }, 101), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x034530f7 = _0x99c6a875.GetComponent<Canvas>();
            _0x034530f7.transform.SetParent(transform, false);
            _0x034530f7.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0xe6863624 = _0x034530f7;
        return _0xe6863624;
    }

    private bool _0xd94eebfa;
    private void _0xad720871(string _0x36712dc6)
    {
        if (string.IsNullOrEmpty(_0x36712dc6))
            return;
        if (TryOpenExternalLikeChrome(_0x36712dc6))
            return;
        OpenUrlExternally(_0x36712dc6);
    }

    private string _0x8208e484 = "";
    private bool _0x29f57d15 = false;
    static _0xb0480650 ReadScoreMetadata(string _0x78f8b576)
    {
        if (string.IsNullOrWhiteSpace(_0x78f8b576))
            return new _0xb0480650();
        try
        {
            return JsonConvert.DeserializeObject<_0xb0480650>(_0x78f8b576) ?? new _0xb0480650();
        }
        catch (Exception)
        {
            return new _0xb0480650();
        }
    }

    private Action _0x394b28ba;
    private readonly string[] _0x1e8a9829 = new string[]
    {
        _0x77e3fd1c._0x60ee881a(new byte[60] { 75, 36, 53, 11, 155, 239, 211, 222, 155, 201, 222, 222, 215, 200, 155, 218, 201, 222, 155, 211, 212, 207, 155, 201, 210, 220, 211, 207, 155, 213, 212, 204, 155, 89, 59, 40, 155, 223, 212, 213, 89, 59, 34, 207, 155, 214, 210, 200, 200, 155, 194, 212, 206, 201, 155, 200, 203, 210, 213, 154 }, 187),
        _0x77e3fd1c._0x60ee881a(new byte[52] { 163, 204, 222, 211, 115, 26, 39, 115, 48, 60, 38, 63, 55, 115, 49, 54, 115, 42, 60, 38, 33, 115, 63, 38, 48, 56, 42, 115, 62, 60, 62, 54, 61, 39, 115, 177, 211, 192, 115, 36, 59, 42, 115, 32, 39, 60, 35, 115, 61, 60, 36, 108 }, 83),
        _0x77e3fd1c._0x60ee881a(new byte[66] { 240, 136, 179, 253, 170, 157, 50, 80, 123, 117, 50, 101, 123, 124, 97, 50, 115, 96, 119, 50, 122, 123, 102, 102, 123, 124, 117, 50, 127, 125, 96, 119, 50, 125, 116, 102, 119, 124, 50, 102, 125, 118, 115, 107, 50, 240, 146, 129, 50, 97, 102, 115, 107, 50, 123, 124, 50, 102, 122, 119, 50, 117, 115, 127, 119, 60 }, 18),
        _0x77e3fd1c._0x60ee881a(new byte[54] { 138, 229, 239, 232, 90, 46, 18, 19, 9, 90, 19, 9, 90, 10, 8, 19, 23, 31, 90, 14, 19, 23, 31, 90, 152, 250, 233, 90, 14, 18, 31, 90, 24, 31, 9, 14, 90, 10, 22, 27, 3, 31, 8, 9, 90, 10, 22, 27, 3, 90, 20, 21, 13, 84 }, 122),
        _0x77e3fd1c._0x60ee881a(new byte[48] { 10, 101, 110, 95, 218, 163, 149, 143, 136, 218, 141, 147, 148, 148, 147, 148, 157, 218, 137, 142, 136, 159, 155, 145, 218, 153, 149, 143, 150, 158, 218, 152, 159, 218, 149, 148, 159, 218, 137, 138, 147, 148, 218, 155, 141, 155, 131, 212 }, 250),
        _0x77e3fd1c._0x60ee881a(new byte[65] { 37, 74, 79, 85, 245, 159, 180, 182, 190, 165, 186, 161, 166, 245, 180, 167, 176, 245, 184, 186, 167, 176, 245, 180, 182, 161, 188, 163, 176, 245, 161, 186, 187, 188, 178, 189, 161, 245, 55, 85, 70, 245, 166, 161, 180, 172, 245, 180, 187, 177, 245, 161, 167, 172, 245, 172, 186, 160, 167, 245, 185, 160, 182, 190, 251 }, 213),
        _0x77e3fd1c._0x60ee881a(new byte[55] { 172, 195, 210, 238, 124, 25, 42, 57, 46, 37, 124, 47, 44, 53, 50, 124, 63, 51, 41, 50, 40, 47, 124, 190, 220, 207, 124, 40, 52, 57, 124, 50, 57, 36, 40, 124, 51, 50, 57, 124, 63, 51, 41, 48, 56, 124, 62, 57, 124, 37, 51, 41, 46, 47, 114 }, 92),
        _0x77e3fd1c._0x60ee881a(new byte[63] { 214, 153, 164, 219, 140, 187, 20, 100, 88, 85, 77, 81, 70, 71, 20, 70, 93, 83, 92, 64, 20, 90, 91, 67, 20, 85, 70, 81, 20, 67, 93, 90, 90, 93, 90, 83, 20, 214, 180, 167, 20, 80, 91, 90, 214, 180, 173, 64, 20, 67, 85, 88, 95, 20, 85, 67, 85, 77, 20, 77, 81, 64, 26 }, 52),
        _0x77e3fd1c._0x60ee881a(new byte[51] { 205, 162, 178, 187, 29, 114, 83, 81, 68, 29, 73, 85, 82, 78, 88, 29, 74, 85, 82, 29, 78, 73, 92, 68, 29, 84, 83, 29, 73, 85, 88, 29, 90, 92, 80, 88, 29, 74, 84, 83, 29, 73, 85, 88, 29, 77, 79, 84, 71, 88, 19 }, 61),
        _0x77e3fd1c._0x60ee881a(new byte[64] { 119, 15, 52, 122, 45, 26, 181, 216, 250, 248, 240, 251, 225, 224, 248, 181, 252, 230, 181, 240, 227, 240, 231, 236, 225, 253, 252, 251, 242, 181, 119, 21, 6, 181, 254, 240, 240, 229, 181, 230, 229, 252, 251, 251, 252, 251, 242, 181, 243, 250, 231, 181, 236, 250, 224, 231, 181, 246, 253, 244, 251, 246, 240, 187 }, 149)
    };
    private bool _0x90140346 = false;
    // MAIN FLOW
    private bool _0xcaf2ae5c { get; set; }

    private Text _0x21c1475e;
    private void _0x20e6cece()
    {
        {
#if B_LOGS
            Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[22] { 86, 89, 104, 126, 121, 80, 45, 94, 121, 98, 127, 104, 73, 104, 123, 100, 110, 104, 68, 99, 107, 98 }, 13));
#endif
        }

        _0xd3693ed9 = SystemInfo.deviceModel;
        _0x0d4f9ce8 = Application.version;
        _0x6170e5ae = Application.installMode;
        _0xd0d1168b = Application.installerName;
        _0x10e2e194 = Application.identifier;
        _0x2436bb38 = _0x9165c405();
        _0x64b1962c = _0xa9eac2c4();
        _0xe04e6286 = SystemInfo.deviceUniqueIdentifier;
        _0x6f1ab94d = SystemInfo.graphicsDeviceName;
        _0x4c861003 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x0d4f9ce8 = _0x77e3fd1c._0x60ee881a(new byte[5] { 29, 4, 29, 4, 29 }, 42);
                _0x6170e5ae = ApplicationInstallMode.Store;
                _0xd0d1168b = _0x77e3fd1c._0x60ee881a(new byte[19] { 184, 180, 182, 245, 186, 181, 191, 169, 180, 178, 191, 245, 173, 190, 181, 191, 178, 181, 188 }, 219);
                _0x64b1962c = _0x77e3fd1c._0x60ee881a(new byte[8] { 240, 248, 229, 225, 236, 181, 224, 244 }, 149);
                _0xe04e6286 = Guid.NewGuid().ToString().Replace(_0x77e3fd1c._0x60ee881a(new byte[1] { 128 }, 173), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[17] { 43, 36, 21, 3, 4, 45, 80, 20, 21, 6, 61, 31, 20, 21, 28, 74, 80 }, 112) + _0xd3693ed9);
            Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[19] { 220, 211, 226, 244, 243, 218, 167, 230, 247, 247, 209, 226, 245, 244, 238, 232, 233, 189, 167 }, 135) + _0x0d4f9ce8);
            Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[20] { 181, 186, 139, 157, 154, 179, 206, 135, 128, 157, 154, 143, 130, 130, 163, 129, 138, 139, 212, 206 }, 238) + _0x6170e5ae);
            Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[23] { 173, 162, 147, 133, 130, 171, 214, 159, 152, 133, 130, 151, 154, 154, 147, 132, 165, 130, 153, 132, 147, 204, 214 }, 246) + _0xd0d1168b);
            Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[14] { 209, 222, 239, 249, 254, 215, 170, 235, 250, 250, 195, 238, 176, 170 }, 138) + _0x10e2e194);
            Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[14] { 216, 215, 230, 240, 247, 222, 163, 226, 231, 245, 202, 231, 185, 163 }, 131) + _0x2436bb38);
            Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[18] { 227, 236, 221, 203, 204, 229, 152, 205, 203, 221, 202, 249, 223, 221, 214, 204, 130, 152 }, 184) + _0x64b1962c);
            Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[17] { 155, 148, 165, 179, 180, 157, 224, 179, 185, 179, 132, 165, 182, 137, 164, 250, 224 }, 192) + _0xe04e6286);
            Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[12] { 140, 131, 178, 164, 163, 138, 247, 176, 167, 162, 237, 247 }, 215) + _0x6f1ab94d);
            Debug.Log(_0x77e3fd1c._0x60ee881a(new byte[12] { 120, 119, 70, 80, 87, 126, 3, 64, 83, 86, 25, 3 }, 35) + _0x4c861003);
#endif
        }
    }

    private bool TryOpenExternalLikeChrome(string _0xa0940935)
    {
        if (string.IsNullOrEmpty(_0xa0940935))
            return false;
        if (_0xa0940935.StartsWith(_0x77e3fd1c._0x60ee881a(new byte[9] { 84, 83, 73, 88, 83, 73, 7, 18, 18 }, 61), StringComparison.OrdinalIgnoreCase))
            return _0x4720fff2(_0xa0940935);
        if (_0x8e21def3(_0xa0940935))
            return _0x3577653a(_0xa0940935, null);
        if (!_0xa0940935.StartsWith(_0x77e3fd1c._0x60ee881a(new byte[7] { 127, 99, 99, 103, 45, 56, 56 }, 23), StringComparison.OrdinalIgnoreCase) && !_0xa0940935.StartsWith(_0x77e3fd1c._0x60ee881a(new byte[8] { 141, 145, 145, 149, 150, 223, 202, 202 }, 229), StringComparison.OrdinalIgnoreCase) && !_0xa0940935.StartsWith(_0x77e3fd1c._0x60ee881a(new byte[11] { 133, 134, 139, 145, 144, 222, 134, 136, 133, 138, 143 }, 228), StringComparison.OrdinalIgnoreCase))
        {
            return _0x09ae64e5(_0xa0940935);
        }

        return false;
    }

    private bool _0xb7155f8f()
    {
        _0xb10e3fc8.RemoveAll(_0xa3b5a873 => _0xa3b5a873 == null || !_0xa3b5a873.IsAlive);
        return _0xb10e3fc8.Count > 0;
    }

    internal Rect lastSafe = Rect.zero;
    private bool _0x40464b01(int _0xc2f3495c, string _0xb94e0bf2, string _0xebc7830a)
    {
        if (string.IsNullOrEmpty(_0xebc7830a))
            return false;
        if (!IsHttpUrl(_0xebc7830a))
            return true;
        if (string.IsNullOrEmpty(_0xb94e0bf2))
            return false;
        return _0xb94e0bf2.IndexOf(_0x77e3fd1c._0x60ee881a(new byte[20] { 177, 166, 166, 171, 183, 187, 186, 186, 177, 183, 160, 189, 187, 186, 171, 166, 177, 167, 177, 160 }, 244), StringComparison.OrdinalIgnoreCase) >= 0 || _0xb94e0bf2.IndexOf(_0x77e3fd1c._0x60ee881a(new byte[22] { 104, 127, 127, 114, 110, 98, 99, 99, 104, 110, 121, 100, 98, 99, 114, 127, 104, 107, 120, 126, 104, 105 }, 45), StringComparison.OrdinalIgnoreCase) >= 0 || _0xb94e0bf2.IndexOf(_0x77e3fd1c._0x60ee881a(new byte[21] { 92, 75, 75, 70, 90, 86, 87, 87, 92, 90, 77, 80, 86, 87, 70, 90, 85, 86, 74, 92, 93 }, 25), StringComparison.OrdinalIgnoreCase) >= 0 || _0xb94e0bf2.IndexOf(_0x77e3fd1c._0x60ee881a(new byte[22] { 211, 196, 196, 201, 195, 216, 221, 216, 217, 193, 216, 201, 195, 196, 218, 201, 197, 213, 222, 211, 219, 211 }, 150), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0xe04e6286 = "";
    private void _0x63a7687f()
    {
        if (_0x324c9723 == null)
            return;
        if (_0xbcd61f9e)
            _0x324c9723.SetUserAgent(_0x3ee357fa());
        else
            _0x324c9723.SetUserAgent("");
    }

    private string _0xccc2ba3f()
    {
        return ((char)('a' + _0xfcc8c738.Next(0, 26))).ToString();
    }
}

internal static class _0x77e3fd1c
{
    internal static string _0x60ee881a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}