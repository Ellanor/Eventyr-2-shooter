using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class COntrols : MonoBehaviour
{
    public void OnBackButton()
    {
        SceneManager.LoadScene(0);
    }
}
