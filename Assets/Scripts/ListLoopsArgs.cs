using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListLoopsArgs : MonoBehaviour
{
    [SerializeField]
    private int cubeCount;
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private float spacing = 1.1f;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cubeCount; i++)
        {
            Vector3 position = new Vector3(0, 0, i * spacing);
            Instantiate(prefab, position, Quaternion.identity,transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
