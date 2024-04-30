using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverP1 : MonoBehaviour
{
    public GameObject GameOverScreen;
   
    // Start is called before the first frame update
    void Start()
    {
        GameOverScreen.SetActive(false);
       
    }
    private void Update()
    {
        
  
        Debug.Log("test");
        Debug.Log(Player2Move.GameOverUpdate);

        if (Player2Move.GameOverUpdate)
        {
            Debug.Log("test");
            GameOverScreen.SetActive(true);
        }
    }
}
