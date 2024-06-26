using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumeratorTest : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(PrintHelloWorld());
    }

    public IEnumerator PrintHelloWorld()
    {
        Debug.Log("Hello World!");

        yield return new WaitForSeconds(1.0f);

        Debug.Log("Hello Wolrd!");
    }
}
