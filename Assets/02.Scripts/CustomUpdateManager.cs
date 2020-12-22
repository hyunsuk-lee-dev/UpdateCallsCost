using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomUpdateManager : MonoBehaviour
{
    private CustomUpdateBehaviour[] customUpdateBehaviours;

    void Start()
    {
        customUpdateBehaviours = GetComponents<CustomUpdateBehaviour>();
    }

    void Update()
    {
        foreach(var customUpdateBehaviour in customUpdateBehaviours)
        {
            customUpdateBehaviour.CustomUpdate();
        }
    }
}
