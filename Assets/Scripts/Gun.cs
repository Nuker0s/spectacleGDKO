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
        crosshair.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,5));
    }
}
