using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Runtime.InteropServices;

using TMPro;

public class ModifyHelloTxt : MonoBehaviour
{

    [DllImport("__Internal")]
    private static extern void GetLtiUsername([MarshalAs(UnmanagedType.FunctionPtr)] LtiUsernameCallback callback);

    public TMP_Text helloTxt;

    // Start is called before the first frame update
    void Start()
    {
        helloTxt.text = "test";
        ConnectLtiUser();
    }

    void SetLtiUsername(string username)
    {
        helloTxt.text = username;
    }

    void ConnectLtiUser()
    {
        GetLtiUsername(OnLtiUserConnected);
    }

    [AOT.MonoPInvokeCallback(typeof(LtiUsernameCallback))]
    private static void OnLtiUserConnected(string username)
    {
        if (username != "")
        {
            ModifyHelloTxt instance = new ModifyHelloTxt();
            instance.helloTxt.text = username;
        }
    }

    // Define the callback delegate type
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void LtiUsernameCallback(string username);
}

