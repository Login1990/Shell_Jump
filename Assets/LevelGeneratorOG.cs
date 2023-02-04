using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneratorOG : MonoBehaviour
{
    [SerializeField] private Transform levelPart_1;
    [SerializeField] private Transform levelPart_Start;

    private void Awake()
    {
        Transform lastLevelPartTransform;
        lastLevelPartTransform = SpawnLevelPart(levelPart_Start.Find("EndPoint").position);
    }

    private Transform SpawnLevelPart(Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart_1, spawnPosition ,Quaternion.identity);
        return levelPartTransform;
    }


    /*private const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 200f;

    [SerializeField] Transform levelPart_Start;
    [SerializeField] List<Transform> levelPartList;
    [SerializeField] GameObject player;

    private Vector3 lastEndPosition;

    private void Awake() {
        lastEndPosition = levelPart_Start.Find("EndPosition").position;

        int startingSpawnLevelParts = 5;
        for (int i = 0; i < startingSpawnLevelParts; i++) {
            SpawnLevelPart();
        }
    }

    private void Update() {
        if (Vector3.Distance(player.transform.position, lastEndPosition) < PLAYER_DISTANCE_SPAWN_LEVEL_PART) {
            // Spawn another level part
            SpawnLevelPart();
        }
    }

    private void SpawnLevelPart() {
        Transform chosenLevelPart = levelPartList[Random.Range(0, levelPartList.Count)];
        Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, lastEndPosition);
        lastEndPosition = lastLevelPartTransform.Find("EndPosition").position;
    }

    private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition) {
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }*/
}
