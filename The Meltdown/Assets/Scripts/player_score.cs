using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_score : MonoBehaviour
{

    public GameObject character;

    public int score = 0;

    public string level;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        ++score;

        SceneManager.LoadScene(level);
        character = GameObject.FindWithTag("Player");
        character.transform.Translate(-2,2,0);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(score);
    }


    public int SendScoreUpdate()
    {

        return score;   


    }

}
