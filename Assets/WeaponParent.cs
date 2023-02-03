using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponParent : MonoBehaviour
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
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePos - transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0,0,rotZ);

        lookDir = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (rotZ > 90 || rotZ < -90){
            isFacingLeft = true;
     }
        else {
            isFacingLeft = false;
     }
        if (isFacingLeft){
            gameObject.GetComponentInChildren<SpriteRenderer>().flipY = true;
     }
        else{
            gameObject.GetComponentInChildren<SpriteRenderer>().flipY = false;
     }

    }
}
