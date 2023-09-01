using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Runtime.InteropServices;

using TMPro;

public class ModifyHelloTxt : MonoBehaviour
{

    [DllImport("__Internal")]
    private static extern void GetLtiUsername();

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
        GetLtiUsername();
    }
}

