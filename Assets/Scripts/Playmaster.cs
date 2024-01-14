using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using SpeechLib;

public class Playmaster : MonoBehaviour
{
    //SPVoice voice = new SpVoice();
    public Audience audience;
    public Jokes jokes;
    public PlayerInput pinput;
    public InputAction right;
    public bool say = false;
    //public bool jokesaid = true;
    public Text wholejoke;
    public RectTransform nextwordrect;
    public Text nextword;
    public Text hptext;
    public int hp;
    public Text scoretext;
    public static int score;
    public Text timetext;
    public float timeleft;
    // Start is called before the first frame update

    void Start()
    {
        right = pinput.actions.FindAction("Right");
        StartCoroutine(joking());
    }
    public void damage() 
    {
        hp -= 1;
        hptext.text = hp.ToString();
        if (hp <= 0) 
        {
            loose();
        }
    }
    public void scoret() 
    {
        score += 1;
        scoretext.text = score.ToString();
    }
    public void loose() 
    {
        SceneManager.LoadScene("SampleScene");
    }
    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;
        timeleft= Mathf.Clamp(timeleft, -10, 80);
        timetext.text = Mathf.Floor(timeleft).ToString();
        if (timeleft <= 0)
        {

        }
    }
    public IEnumerator joking() 
    {
        while (true)
        {
            //Debug.Log("corstart");
            
            //nextwordrect.position = new Vector2(Random.Range(-300, 300), Random.Range(-300, 300));

            var randomjoke = jokes.terribleJokes[Random.Range(0, jokes.terribleJokes.Count)];
            wholejoke.text = "";
            
            //int jokelenght = randomjoke[0].Count;
            foreach (string word in randomjoke[0])
            {
                
                moveword();
                nextword.text = word;
                //Debug.Log(word)
                yield return new WaitUntil(() => say);
                wholejoke.text += " " + word;

                say = false;

            }
            nextword.text = "punchline";
            moveword();
            

            yield return new WaitUntil(() => say);
            wholejoke.text += "\n";
            foreach (var item in randomjoke[1])
            {
                //Debug.Log(item);
                wholejoke.text += " " + item;
                yield return new WaitForSeconds(0.2f);
            }
            say = false;
            nextword.text = "Okay another one";
            yield return new WaitUntil(() => say);
            say = false;
            Debug.Log("ebe");


        }
    }
    public void moveword() 
    {
        float width = Screen.width / 2;
        float height = Screen.height / 2;   
        nextwordrect.position = new Vector2(width, height) + new Vector2(Random.Range(-width*0.5f, width * 0.5f), Random.Range(-height * 0.5f, height * 0.5f));
    }
}
