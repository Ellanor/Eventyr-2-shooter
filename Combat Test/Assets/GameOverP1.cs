using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverP1 : MonoBehaviour
{
    public GameObject GameOverScreen1;
    public GameObject GameOverScreen2;
   
    // Start is called before the first frame update
    void Start()
    {
        GameOverScreen1.SetActive(false);
        GameOverScreen2.SetActive(false);
       
    }
    private void Update()
    {
        
  
        Debug.Log("test");
        Debug.Log(Player2Move.GameOverUpdate);

        if (Player2Move.GameOverUpdate)
        {
            Debug.Log("test");
            GameOverScreen2.SetActive(true);
        }
        if (PlayerMove.GameOverUpdate)
        {
            GameOverScreen1.SetActive(true);
        }
    }
}
