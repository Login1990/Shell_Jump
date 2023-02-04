using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour
{
    public Transform objectToFollow;
    void Update(){
        
        transform.position = new Vector3 (transform.position.x,objectToFollow.position.y);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
}
