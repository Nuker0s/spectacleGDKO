using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Audience : MonoBehaviour
{
    public List<GameObject> throwables = new List<GameObject>();
    public float cooldown = 1;
    public int throwers = 1;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator audience() 
    {
        while (true) 
        {
            for (int i = 0; i < throwers; i++)
            {
                yeet(transform.GetChild(Random.Range(0, transform.childCount)).position);
            }
            
            yield return new WaitForSeconds(cooldown);
        }
        
    }
    public void yeet(Vector3 from) 
    {

    }
}
