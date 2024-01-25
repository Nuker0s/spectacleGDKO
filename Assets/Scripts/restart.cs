using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restart : MonoBehaviour
{
    public Text final;
    // Start is called before the first frame update
    void Start()
    {
        final.text = "YOU LOST \n final score:" + Playmaster.score.ToString() + "\n Press on me to restart";
        Playmaster.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void restat() 
    {
        SceneManager.LoadScene("SampleScene");
    }
}
