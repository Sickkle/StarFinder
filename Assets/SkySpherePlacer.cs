using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkySpherePlacer : MonoBehaviour
{
    public GameObject spherePrefab;
    public int numOfSpherees = 10;
    public Vector3[] fixedPositions;

    // Start is called before the first frame update
    void Start()
    {
        if (fixedPositions.Length == 0)
        {
            fixedPositions = new Vector3[numOfSpherees];
            for (int i = 0; i < numOfSpherees; i++)
            {
                fixedPositions[i] = new Vector3(
                    Random.Range(-10f, 10f),
                    Random.Range(5f, 15f),
                    Random.Range(-10f, 10)
                    );
            
            }
        }
        foreach (Vector3 position in fixedPositions)
        {
            Instantiate(spherePrefab, position, Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
