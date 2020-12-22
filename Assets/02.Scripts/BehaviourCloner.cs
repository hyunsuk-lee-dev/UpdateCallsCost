using System.Collections;
using System.Collections.Generic;

using UnityEditor;

using UnityEngine;

public class BehaviourCloner : MonoBehaviour
{
    public int length;
    public MonoBehaviour behaviourComponent;

    // Start is called before the first frame update
    private void Awake()
    {
        for(int i = 0 ; i < length ; i++)
        {
            gameObject.AddComponent(behaviourComponent.GetType());
        }
    }
}
