using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class transition_manage : MonoBehaviour
{
   
    public GameObject Player;
    public GameObject UI;
    
    private void OnEnable()
    {

        var Screen = GetComponent<UIDocument>().rootVisualElement;

        Screen.Q("play").RegisterCallback<ClickEvent>(en => StartGame());
        Screen.Q("exit").RegisterCallback<ClickEvent>(en => ExitGame());

        
    }

    
    void StartGame()
    {
        SceneManager.LoadScene("Area_01");
        Instantiate(Player, new Vector3(4.5f, 1.5f, 0), Quaternion.identity);
        Instantiate(UI, new Vector3(0, 0, 0), Quaternion.identity);
    }

    void ExitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
