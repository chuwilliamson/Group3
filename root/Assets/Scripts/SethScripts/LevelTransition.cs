using UnityEngine;
using System.Collections;

public class LevelTransition : MonoBehaviour
{
    public void Retry()
    {
        Application.LoadLevel("NetworkTests");
    }
    
     public void MainM()
    {
        Application.LoadLevel("MainMenu");
    }

     public void Quit()
     {
         Application.Quit();
     }
      
}