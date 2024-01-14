using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rtoatetomato : MonoBehaviour
{
    public float maxspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
        transform.Rotate(rot * maxspeed * Time.deltaTime);
    }
}
