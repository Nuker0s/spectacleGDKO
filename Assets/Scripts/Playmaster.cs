using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
public class Playmaster : MonoBehaviour
{
    public Audience audience;
    public Jokes jokes;
    public PlayerInput pinput;
    public InputAction right;
    public bool say = false;
    public bool jokesaid = true;
    public TextMeshProUGUI wholejoke;
    // Start is called before the first frame update
    void Start()
    {
        right = pinput.actions.FindAction("Right");
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
        var randomjoke = jokes.terribleJokes[Random.Range(0,jokes.terribleJokes.Count)];
        //int jokelenght = randomjoke[0].Count;
        foreach (string word in randomjoke[0])
        {
            //Debug.Log(word);
            wholejoke.text += " " + word; 
            yield return new WaitUntil(() => say);
            say = false;

        }
        foreach (var item in randomjoke[1])
        {
            //Debug.Log(item);
            wholejoke.text += " " + item;
        }
        
        jokesaid = true;
        
    }
}
