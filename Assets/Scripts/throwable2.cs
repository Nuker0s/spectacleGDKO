using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwable2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        Destroy(transform.parent.gameObject);
    }
}
