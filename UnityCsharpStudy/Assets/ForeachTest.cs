using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachTest : MonoBehaviour
{
    int[] numbers = { 1, 2, 3, 4 };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator GetEnumerator()
    {
        foreach (var i in numbers)
            yield return i;
    }
}
