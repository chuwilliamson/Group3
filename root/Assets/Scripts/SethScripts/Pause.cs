using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{
    public bool paused;
    void Update()
    {
     // OnApplicationPause(true);
      //return;
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
                    OnApplicationPause(true);
                if (GUILayout.Button("Quit."))
                    Application.Quit();
            }
            GUILayout.EndVertical();
        }

    }

    void OnApplicationPause(bool pauseStatus)
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        paused = pauseStatus;
        return;
    }
}