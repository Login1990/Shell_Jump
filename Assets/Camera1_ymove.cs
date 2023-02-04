using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera1_ymove : MonoBehaviour
{
    public float XPosition = 0f;
    [HideInInspector] public float YPosition;
    [HideInInspector] private float XPos;
    [HideInInspector] private float YPos;
    [HideInInspector] private float ZPos;
    [HideInInspector] private float highY = 0f;
    [HideInInspector] private Vector3 Pos;
    [HideInInspector] private Vector3 myVector;

    void Update()
    {
        Pos = GameObject.FindGameObjectWithTag("MainCamera").transform.position;
        YPosition = GameObject.FindGameObjectWithTag("Player").transform.position.y;
        XPos = XPosition;
        YPos = YPosition;
        ZPos = Pos.z;
        if (YPos < highY)
        {
            YPos = highY;
        }
        else
        {
            highY = YPos;
        }
        myVector = new Vector3(XPos, YPos, ZPos);
        GameObject.FindGameObjectWithTag("MainCamera").transform.position = myVector;
    }
}
