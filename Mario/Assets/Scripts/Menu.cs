﻿using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
     public void StartGame ()
    {
        //loadar fyrsta Leveli
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
