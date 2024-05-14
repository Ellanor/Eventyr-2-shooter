using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverP1 : MonoBehaviour
{
    public GameObject GameOverScreen1;
    public GameObject GameOverScreen2;
   
    // Start is called before the first frame update
    void Start()
    {

       
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
        if (GameOverScreen1 == true || GameOverScreen2 == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerMove.GameOverUpdate = false;
                Player2Move.GameOverUpdate = false;
                UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            }
        }
    }
}
