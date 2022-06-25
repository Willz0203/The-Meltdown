using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MMtransition : MonoBehaviour
{
   
    private Button play;
    
    private void OnEnable()
    {

        var rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

        play = rootVisualElement.Q<Button>();

        play.clickable.clicked += () => Debug.Log("clicked!");
    }

    


    // Update is called once per frame
    void Update()
    {
        
    }
}
