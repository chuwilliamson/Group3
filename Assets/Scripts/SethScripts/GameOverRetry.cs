using UnityEngine;
using System.Collections;

public class GameOverRetry : MonoBehaviour
{
    public void Retry()
    {
        Application.LoadLevel("NetworkTests");
    }
}