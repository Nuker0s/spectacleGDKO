using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playmaster : MonoBehaviour
{
    public Audience audience;
    public Jokes jokes;
    public PlayerInput pinput;
    public InputAction right;
    public bool say = false;
    public bool jokesaid = true;
    // Start is called before the first frame update
    void Start()
    {
        right = pinput.actions.FindAction("Right");
    }

    // Update is called once per frame
    void Update()
    {
        if (right.WasPressedThisFrame()) 
        {
            Debug.Log("rightpress");
            if (jokesaid) 
            {
                Debug.Log("jokesaid");
                StartCoroutine(joking());
                jokesaid = false;
            }
            else
            {
                Debug.Log("say");
                say = true;
            }
        }
    }
    public IEnumerator joking() 
    {
        Debug.Log("corstart");
        var randomjoke = jokes.terribleJokes[Random.Range(0,jokes.terribleJokes.Count)];
        //int jokelenght = randomjoke[0].Count;
        foreach (string word in randomjoke[0])
        {
            Debug.Log(word);
            yield return new WaitUntil(() => say);
            say = false;

        }
        foreach (var item in randomjoke[1])
        {
            Debug.Log(item);
        }
        
        jokesaid = true;
        
    }
}
