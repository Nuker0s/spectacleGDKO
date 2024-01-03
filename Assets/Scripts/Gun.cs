using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Camera cam;
    public Transform crosshair;
    public float cdist;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        crosshair.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,cdist));
        transform.rotation = Quaternion.LookRotation(crosshair.position - transform.position);
    }
    private void OnDrawGizmos()
    {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position,transform.position+transform.forward*cdist*5);
    }
}
