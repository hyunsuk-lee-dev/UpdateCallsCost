using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

using UnityEngine;

public class FrameCounter : MonoBehaviour
{
    private long frameTime;
    private long totalTime;

    private float startTime = 1f;
    private int updateCount;

    private Stopwatch stopwatch;

    private void Awake()
    {
        stopwatch = new Stopwatch();
        StartCoroutine(Log());
    }

    private void Update()
    {
        if(Time.time < startTime)
            return;
        stopwatch.Start();
    }

    private void LateUpdate()
    {
        if(Time.time < startTime)
            return;

        stopwatch.Stop();
        updateCount++;
        frameTime = stopwatch.ElapsedTicks;
        totalTime += frameTime;
        stopwatch.Reset();
    }


    private IEnumerator Log()
    {
        WaitForSeconds delay = new WaitForSeconds(1f);

        while(true)
        {
            yield return delay;

            if(updateCount > 0)
            {
                UnityEngine.Debug.Log("Last time: " + (float)frameTime / Stopwatch.Frequency * 1000f + "ms. " +
                    "Average time: " + (float)(totalTime / updateCount) / Stopwatch.Frequency * 1000f + "ms.");
            }
        }
    }
}
