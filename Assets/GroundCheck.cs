using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public Vector3 boxSize;
    public float maxDistance;
    public LayerMask layerMask;
    public WeaponParent MyWeapon;

    public AudioSource land;

    // Update is called once per frame
    void Update(){
        if (Ground()){
            MyWeapon.isCol = true;
        }
        else{
            MyWeapon.isCol = false;
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color=Color.red;
        Gizmos.DrawCube(transform.position-transform.up*maxDistance,boxSize);
    }
    private bool Ground()
    {
        if(Physics2D.BoxCast(transform.position,boxSize,0,-transform.up,maxDistance,layerMask))
        {
            //land.Play();
            return true;
        }
        else{
            return false;
        }
    }

}
