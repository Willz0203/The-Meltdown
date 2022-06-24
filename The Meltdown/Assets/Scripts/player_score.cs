using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_score : MonoBehaviour
{

    public int score = 0;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        ++score;

        SceneManager.LoadScene("SampleScene");

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
