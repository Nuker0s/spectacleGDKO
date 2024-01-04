using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class throwable : MonoBehaviour
{
    public Transform target;
    public float speed;
    public float distance;
    public float traveled = 0;
    public float primaly;
    public float heightmult;
    public AnimationCurve flightpath;
    // Start is called before the first frame update
    void Start()
    {
        primaly = transform.position.y;
        distance = Vector3.Distance(transform.position,target.position);
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);

        traveled = (distance - Vector3.Distance(transform.position, target.position)) / distance;
        float y = math.lerp(primaly, transform.position.y, traveled) + flightpath.Evaluate(traveled) * heightmult;
        transform.position= new Vector3(transform.position.x,y,transform.position.z);

        if (Vector3.Distance(transform.position,target.position) < 1)
        {
            Destroy(gameObject);
        }
    }
}
