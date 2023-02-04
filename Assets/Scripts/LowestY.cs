using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowestY : MonoBehaviour
{
    [HideInInspector]
    private float lowY = 0f;

    public void NewY(float Ypos)
    {
        lowY = Ypos;
    }

    public float GetY()
    {
        return lowY;
    }
}
