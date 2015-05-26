using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{
    public bool paused;
    public float savedTimeScale;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        paused = togglePause();
       
    }

    void OnGUI()
    {
        if (paused)
        {
            GUILayout.BeginVertical(GUILayout.Height(Screen.height));
            {

                GUILayout.FlexibleSpace();

                GUILayout.Label("Game is paused.");
                if (GUILayout.Button("Unpause"))
                    paused = togglePause();
                if (GUILayout.Button("Quit."))
                    Application.Quit();
            }
            GUILayout.EndVertical();
        }

    }

    bool togglePause()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            return (false);
        }
        else
        {
            Time.timeScale = 0f;
            return (true);
        }
    }
}