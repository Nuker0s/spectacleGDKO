using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class pickup : MonoBehaviour
{
    public PlayerInput pinput;
    public InputAction grab;
    public grabbable grabbedobj;
    public Transform grabpoint;
    public Camera cam;
    public LayerMask layers;
    public LayerMask pickeduplayer;
    public float maxdistance;
    public float force;

    private void Awake()
    {
        grab = pinput.actions.FindAction("Pickup");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (grab.WasPressedThisFrame())
        {


            switch (grabbedobj)
            {
                default:
                    grabbedobj.rb.drag = grabbedobj.defaultdrag;
                    grabbedobj.gameObject.layer = grabbedobj.defaultlayer;
                    grabbedobj = null;
                    break;
                case null:
                    grabbable grabcheck = castray().collider.gameObject.GetComponent<grabbable>();
                    if(grabcheck!=null)
                    {
                        grabbedobj = grabcheck;
                        grabbedobj.gameObject.layer = pickeduplayer;
                        grabbedobj.rb.drag = grabbedobj.pickupdrag;
                    }
                    break;
                
                    
            }

        }
    }
    RaycastHit castray()
    {
        RaycastHit hit;
        Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, maxdistance,layers);
        return hit;
    }
    private void FixedUpdate()
    {
        if (grabbedobj!=null)
        {
            Vector3 dir = grabpoint.position - grabbedobj.transform.position;
            grabbedobj.rb.AddForce(dir * force * Time.deltaTime * grabbedobj.force);
        }
    }
}
