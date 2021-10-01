using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitTheGame()
    {
            Debug.Log ("The game is closed");
            Application.Quit();
            
    }
}
