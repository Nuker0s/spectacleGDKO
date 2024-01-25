using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Jokebub : MonoBehaviour//, IPointerClickHandler
{

    /*public void OnPointerClick(PointerEventData eventData)
    {
        /*if (eventData.button == PointerEventData.InputButton.Left)
            Debug.Log("Left click");
        else if (eventData.button == PointerEventData.InputButton.Middle)
            Debug.Log("Middle click");
        else
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            //Debug.Log("Right click");
            playmaster.say = true;
        }
    }*/
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1)) // 1 represents the right mouse button
        {
            playmaster.say = true;
            // Add your right-click logic here
        }
    }

    public Playmaster playmaster;
    // Start is called before the first frame update
    void Start()
    {
        playmaster = GameObject.Find("Playmaster").GetComponent<Playmaster>();
    }

}
