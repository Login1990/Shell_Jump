using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDown : MonoBehaviour
{
    public Camera cam;
    public int offset;
    [HideInInspector] public bool outOfBounds;
    [HideInInspector] public Vector3 screenPos;
    [HideInInspector] public Vector3 newscreenPos;

    void Update()
    {
        screenPos = cam.WorldToScreenPoint(GameObject.FindGameObjectWithTag("Player").transform.position);
        newscreenPos = new Vector3(screenPos.x, screenPos.y - offset, screenPos.z);
        outOfBounds = !Screen.safeArea.Contains(newscreenPos);
    }
}

