using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponParent : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos;
    public bool isFacingLeft;
    public Vector2 lookDir;
    public float recoilForce;
    public Rigidbody2D rb;
    public Vector3 boxSize;
    public float maxDistance;
    public LayerMask layerMask;
    public int ammo;
    public bool isCol;
    public bool isReloading;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        int ammo = 2;
    }

    // Update is called once per frame
    void Update()
    {
        gun_direction();
        if (Input.GetMouseButtonDown(0) && ammo>0){
            Shoot();
            ammo = ammo-1;
        }
        if(isCol && !isReloading && ammo==0){
            StartCoroutine(Reload());
        }
    }
    private void gun_direction(){
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
    private void Shoot(){
        Vector3 rotation = mousePos - transform.position;
        rb.AddForce(-rotation.normalized * recoilForce, ForceMode2D.Impulse);

    }
    private IEnumerator Reload(){
        isReloading = true;
        yield return new WaitForSeconds(0.5f);
        ammo = 2;
        isReloading = false;
    }
}
