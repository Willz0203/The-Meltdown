using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_score : MonoBehaviour
{

    public GameObject character;

    public int score = 0;

    public int direction;

    public string level;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        ++score;

        SceneManager.LoadScene(level);
        character = GameObject.FindWithTag("Player");

        switch (direction)
        {
            case 1:
                character.transform.Translate(2,0.01f,0);
                break;
            
            case 2:
                character.transform.Translate(-2,0.01f,0);
                break;


        }

    
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
