using UnityEngine;
using System.Collections;

public class LevelTransition : MonoBehaviour
{
    public void Retry()
    {
        Application.LoadLevel("NetworkTests");
    }
    public void Main()
    {
        Application.LoadLevel("MainMenu");
    }
}