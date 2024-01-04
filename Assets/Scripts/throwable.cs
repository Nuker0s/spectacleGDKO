using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwable : MonoBehaviour
{
    public Transform target;
    public float speed;
    public Vector3 startpos;
    public AnimationCurve flightpath;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, speed);
        if (Vector3.Distance(transform.position,target.position) > 0.2f)
        {
            Destroy(gameObject);
        }
    }
}
