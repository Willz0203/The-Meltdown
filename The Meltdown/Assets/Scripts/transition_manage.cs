using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class transition_manage : MonoBehaviour
{
   
    
    
    private void OnEnable()
    {

        var Screen = GetComponent<UIDocument>().rootVisualElement;

        Screen.Q("play").RegisterCallback<ClickEvent>(en => StartGame());

        
    }

    
    void StartGame()
    {
        SceneManager.LoadScene("Area_01");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
