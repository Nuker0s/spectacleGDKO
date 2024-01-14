using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Audience : MonoBehaviour
{
    public List<GameObject> throwables = new List<GameObject>();
    public float cooldown = 1;
    public int throwers = 1;
    public float getup = 1f;
    public float getupspeed = 0.2f;
    public Transform player;
    public Vector2 minmaxthrowspeed;
    public Vector2 offsetspeedminmax;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(audience());
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

                //yeet(transform.GetChild(Random.Range(0, transform.childCount)).position);
                StartCoroutine(thrower());
            }
            
            yield return new WaitForSeconds(cooldown);
        }
        
    }
    
    public IEnumerator thrower() 
    {
        Transform hecler;
        while (true) 
        {
            hecler = transform.GetChild(Random.Range(0, transform.childCount));
            if (hecler.gameObject.GetComponent<MeshRenderer>().staticShadowCaster == true)
            {
                hecler.gameObject.GetComponent<MeshRenderer>().staticShadowCaster = false;
                
                
                break;
            }
            yield return new WaitForEndOfFrame();
        }
        
        Vector3 initpos = hecler.position;
        while (hecler.position.y<initpos.y + getup-0.05f)
        {
            hecler.position = Vector3.Lerp(hecler.position, new Vector3(hecler.position.x, initpos.y + getup, hecler.position.z), getupspeed*Time.deltaTime);
            yield return new WaitForEndOfFrame();
        }
        
        //Debug.Log("toyeet");
        yeet(hecler.position);
        while (hecler.position.y > initpos.y)
        {
            //Debug.Log("plswork");
            hecler.position = Vector3.Lerp(hecler.position, new Vector3(hecler.position.x, initpos.y, hecler.position.z), getupspeed*Time.deltaTime);
            yield return new WaitForEndOfFrame();
        }
        hecler.gameObject.GetComponent<MeshRenderer>().staticShadowCaster = true;
        yield return null;
    }
    public void yeet(Vector3 from) 
    {
       // Debug.Log("yeet");
        throwable toyeet = Instantiate(throwables[0], from, Quaternion.identity).GetComponent<throwable>();
        toyeet.target = player;
        toyeet.speed = Random.Range(minmaxthrowspeed.x, minmaxthrowspeed.y);
        toyeet.offsetspeed = offsetspeedminmax.x;
    }
}
