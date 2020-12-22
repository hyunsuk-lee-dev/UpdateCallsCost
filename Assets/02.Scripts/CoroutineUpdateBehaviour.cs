using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CoroutineUpdateBehaviour : MonoBehaviour
{
    private int count = 0;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(UpdateCoroutine());
    }

    private IEnumerator UpdateCoroutine()
    {
        while(true)
        {
            count++;
            yield return null;
        }
    }
}
