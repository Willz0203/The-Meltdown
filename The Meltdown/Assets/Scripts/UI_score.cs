using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UI_score : MonoBehaviour
{

    private Label scoreLabel;

    private int score;

    private void OnEnable()
    {

        var rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

        scoreLabel = rootVisualElement.Q<Label>("current-score");

    }

    public void UpdateScore()
    {

        score = FindObjectOfType<player_score>().SendScoreUpdate();

        scoreLabel.text = $"Score: {score}";  
    }  


    void Update()
    {
        UpdateScore();
    }



}

