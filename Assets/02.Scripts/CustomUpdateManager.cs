using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomUpdateManager : MonoBehaviour
{
    private CustomUpdateBehaviour[] customUpdateBehaviours;

    private void Start()
    {
        customUpdateBehaviours = GetComponentsInChildren<CustomUpdateBehaviour>();
    }

    private void Update()
    {
        foreach(var customUpdateBehaviour in customUpdateBehaviours)
        {
            customUpdateBehaviour.CustomUpdate();
        }
    }
}
