using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexerTest : MonoBehaviour
{
    private Dictionary<string, GameObject> indexerObjects;

    public GameObject this[string skillName]
    {
        get
        {
            return indexerObjects[skillName];
        }
        set
        {
            indexerObjects.Add(skillName, value);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        indexerObjects = new Dictionary<string, GameObject>() { };
        indexerObjects.Add("a", new GameObject());
        indexerObjects.Add("b", new GameObject());
        indexerObjects.Add("c", new GameObject());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
