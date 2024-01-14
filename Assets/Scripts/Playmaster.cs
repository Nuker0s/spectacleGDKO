using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class Playmaster : MonoBehaviour
{
    public Audience audience;
    public Jokes jokes;
    public PlayerInput pinput;
    public InputAction right;
    public bool say = false;
    public bool jokesaid = true;
    public TextMeshProUGUI wholejoke;
    public GameObject nextword;
    // Start is called before the first frame update
    void Start()
    {
        right = pinput.actions.FindAction("Right");
        StartCoroutine(joking());
    }

    // Update is called once per frame
    void Update()
    {
        if (say) 
        {
            //Debug.Log("rightpress");
            if (jokesaid) 
            {
                //Debug.Log("jokesaid");
                StartCoroutine(joking());
                jokesaid = false;
            }
        }
    }
    public IEnumerator joking() 
    {
        //Debug.Log("corstart");
        wholejoke.text = "";
        var randomjoke = jokes.terribleJokes[Random.Range(0,jokes.terribleJokes.Count)];
        //int jokelenght = randomjoke[0].Count;
        foreach (string word in randomjoke[0])
        {
            //Debug.Log(word);
            wholejoke.text += " " + word; 
            yield return new WaitUntil(() => say);
            say = false;

        }
        wholejoke.text += "\n";
        foreach (var item in randomjoke[1])
        {
            //Debug.Log(item);
            wholejoke.text += " " + item;
        }
        
        jokesaid = true;
        
    }
}
