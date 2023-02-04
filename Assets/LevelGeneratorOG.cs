using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneratorOG : MonoBehaviour
{
    [SerializeField] private Transform levelPart_1;
    [SerializeField] private Transform levelPart_Start;
    [SerializeField] private GameObject player;

    private const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 10f;

    private Vector3 lastEndPosition;

    private void Awake()
    {
        lastEndPosition = levelPart_Start.Find("EndPoint").position;
        SpawnLevelPart();
       /* UnityEngine.Debug.Log("The Awake last end is "+lastEndPosition);*/

    private void Update()
    {
        if (Vector3.Distance(player.transform.position, lastEndPosition) < PLAYER_DISTANCE_SPAWN_LEVEL_PART)
        {
            UnityEngine.Debug.Log("The last end pos is "+lastEndPosition+" player transform pos is "+player.transform.position+" and their distance is "+Vector3.Distance(player.transform.position, lastEndPosition));
            SpawnLevelPart();
        }
    }
    private void SpawnLevelPart()
    {
        Transform lastLevelPartTransform = SpawnLevelPart(lastEndPosition);
        lastEndPosition = lastLevelPartTransform.Find("EndPoint").position;

    }

    private Transform SpawnLevelPart(Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart_1, spawnPosition ,Quaternion.identity);
        return levelPartTransform;
    }
}
