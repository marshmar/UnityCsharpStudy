using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public ForeachTest ft;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in ft)
            Debug.Log($"{item}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
