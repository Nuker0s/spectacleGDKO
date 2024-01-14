using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class throwable : MonoBehaviour
{
    public Transform target;
    public float speed;
    public float offsetspeed;
    public float distance;
    public float traveled = 0;
    public float heightmult;
    public AnimationCurve ycurve;
    public AnimationCurve xcurve;
    public Transform col;
    public Playmaster playmaster;
    
    // Start is called before the first frame update
    void Start()
    {
        playmaster = GameObject.Find("Playmaster").GetComponent<Playmaster>();
        distance = Vector3.Distance(transform.position,target.position);
        col = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += (target.position - transform.position).normalized * speed * Time.deltaTime;

        evaluatepos(Vector3.Distance(transform.position, target.position) / distance);
        //evaluatepos((Vector3.Distance(transform.position, target.position)/offsetspeed-math.floor(Vector3.Distance(transform.position, target.position)/offsetspeed)));
        if (Vector3.Distance(transform.position,target.position) < 0.5f)
        {
            playmaster.damage();
            Destroy(gameObject);
        }
    }
    public void evaluatepos(float trav) 
    {
        col.localPosition = new Vector3(0, ycurve.Evaluate(trav) * heightmult, 0);
    }

}
