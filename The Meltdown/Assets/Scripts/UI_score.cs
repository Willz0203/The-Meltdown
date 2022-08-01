using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UI_score : MonoBehaviour
{

    private Label scoreLabel;

    private int temp_score;

    private int score;

    private void OnEnable()
    {

        var rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

        scoreLabel = rootVisualElement.Q<Label>("Score");

    }

    public void UpdateScore()
    {

        temp_score = FindObjectOfType<player_score>().SendScoreUpdate();

        score = score + temp_score;

        scoreLabel.text = $"Score: {score}";  
    }  


    void Update()
    {
        UpdateScore();
    }



}

