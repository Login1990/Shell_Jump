using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookDir : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos;
    public bool isFacingLeft;
    public Vector2 lookDir;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        gun_direction();
    }
    private void gun_direction(){
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePos - transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        if (rotZ > 90 || rotZ < -90){
            isFacingLeft = true;
        }
        else {
            isFacingLeft = false;
        }
        if (isFacingLeft){
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else{
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
