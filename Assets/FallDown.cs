using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDown : MonoBehaviour
{
    public Camera cam;
    [HideInInspector] public bool outOfBounds;
    [HideInInspector] public Vector3 screenPos;

    void Update()
    {
        screenPos = cam.WorldToScreenPoint(GameObject.FindGameObjectWithTag("Player").transform.position);
        outOfBounds = !Screen.safeArea.Contains(screenPos);
    }
}
