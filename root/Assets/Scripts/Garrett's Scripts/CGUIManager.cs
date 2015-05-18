using UnityEngine;
using System.Collections;

public enum GameState { eMainMenu, ePlaying, ePause}

public class CGUIManager : MonoBehaviour {

    private static CGUIManager instance;
    private CGUIManager() { }

    public static CGUIManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = GameObject.FindObjectOfType<CGUIManager>();
                DontDestroyOnLoad(instance);
            }
            return instance;
        }
    }

    public void ChangeLevel(string level)
    {
        Application.LoadLevel(level);
    }

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }

        else
        {
            if (this != instance)
                Destroy(this);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
