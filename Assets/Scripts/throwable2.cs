using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwable2 : MonoBehaviour
{
    public Playmaster playmaster;
    // Start is called before the first frame update
    void Start()
    {
        playmaster = GameObject.Find("Playmaster").GetComponent<Playmaster>();
    }
    // Update is called once per frame
    private void OnMouseDown()
    {
        playmaster.scoret();
        Destroy(transform.parent.gameObject);
    }
}
