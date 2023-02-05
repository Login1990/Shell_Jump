using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlatform : MonoBehaviour
{
    [SerializeField] Transform destination;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   /* void OnCollisionEnter2D(Collision2D other)
    {
        StartCoroutine(WaitForPlatform());
    }

    private IEnumerator WaitForPlatform()
    {
        yield return new WaitForSeconds(3f);    
        UnityEngine.Debug.Log("We waited");
        while (Vector3.Distance(destination.position, gameObject.transform.position) > 0.1f)
        {
            gameObject.transform.position = Vector3.MoveTowards(destination.position,gameObject.transform.position, 0.01f);
            UnityEngine.Debug.Log(Vector3.Distance(destination.position, gameObject.transform.position));
        }
    }*/
}
