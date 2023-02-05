using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{

    [SerializeField]
    private GameObject[] _platformPrefabs;


    public int numberOfPlatforms;
    public float levelWidth = 3f;
    public float minY =.2f;
    public float maxY =1.5f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++){
            spawnPosition.y += Random.Range(minY,maxY);
            spawnPosition.x = Random.Range(-levelWidth,levelWidth);
            Instantiate(_platformPrefabs[Random.Range(0, 3)], spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
