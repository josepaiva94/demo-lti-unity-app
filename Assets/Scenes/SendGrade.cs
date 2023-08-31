using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

using TMPro;

public class SendGrade : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void OnSubmitGrade(int grade);

    public TMP_InputField gradeInput;

    public void OnSendGradeClick()
    {
        OnSubmitGrade(int.Parse(gradeInput.text));
        Debug.Log("Grade: " + gradeInput.text);
    }
}
