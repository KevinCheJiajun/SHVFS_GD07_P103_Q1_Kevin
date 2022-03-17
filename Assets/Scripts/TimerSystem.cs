using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSystem : MonoBehaviour
{
    public float Time = 1.5f;
    private bool DoOnce;

    private void Start()
    {
        DoOnce = true;
    }
    void Update()
    {
        if (DoOnce)
        {
            Invoke("LogMessage", Time);
            DoOnce = false;
        }
    }

    void LogMessage()
    {
        Debug.Log(".");
        DoOnce = true;
    }
}
