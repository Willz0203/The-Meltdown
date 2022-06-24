using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class platform_spawn : MonoBehaviour
{

    public GameObject platform;
    public GameObject goal;

    public int[,] gameMap = new int[26,16];
    
    int pCnt = 5;

    int xPos = 0;
    int yPos = 0;


    


    //this function fills an array that represents the level space 
    public static void FillArray(int[,] array, int val)
    {
        
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = val;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //1s represent unfilled space
        FillArray(gameMap, 0);


        //loop for a predetermined number of platforms per level
        for (int a = 0; a <= pCnt; a++)
        {
            
            
                
            //determine a random position to place a platform
            xPos = Random.Range(3,24);
            yPos = Random.Range(1,15);

            //check if that position has already been filled
            while (gameMap[xPos,yPos]!=0 || gameMap[xPos,yPos-1]!=0 || gameMap[xPos,yPos+1]!=0 || gameMap[xPos+2,yPos]!=0 || gameMap[xPos-2,yPos]!=0 )
            {
            xPos = Random.Range(3,24);
            yPos = Random.Range(1,15);
            }

            //when a suitable position has been found, place a platform
            Instantiate(platform, new Vector3(xPos, yPos, 0), Quaternion.identity);

            //update the array to reflect the new platform
            gameMap[xPos, yPos] = 1;
            gameMap[xPos+1, yPos] = 1;
            gameMap[xPos-1, yPos] = 1;
            gameMap[xPos+1,yPos+1] = 2;
            gameMap[xPos+1,yPos-1] = 2;
            gameMap[xPos-1,yPos+1] = 2;
            gameMap[xPos-1,yPos-1] = 2;

                


                    // for (int b = 0; b < 3; b++)
                    // {
                    //     --xPos;
                    //     Instantiate(platform, new Vector3(xPos, yPos, 0), Quaternion.identity);
                    //     gameMap[xPos, yPos] = 1;
                    // }
                    
                    // genMode = 1;
                    // break;                    
        }

        xPos = Random.Range(3,24);
        yPos = Random.Range(1,15);

        while (gameMap[xPos,yPos]!=1)
        {
            xPos = Random.Range(3,24);
            yPos = Random.Range(1,15);           
        }

        Instantiate(goal, new Vector3(xPos, yPos + 1.5f, 0), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
       //print(array1); 
    }
}
