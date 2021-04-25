using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerformanceManager : MonoBehaviour
{
    void Awake()
    {
        // int TargetWidth = Screen.currentResolution.width / 2;
        // int TargetHeight = Screen.currentResolution.height / 2;
        // Screen.SetResolution(TargetWidth, TargetWidth, false);

        Application.targetFrameRate = 30;
    }
}
