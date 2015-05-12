using UnityEngine;
using System.Collections;

public class CButton : MonoBehaviour {

    [SerializeField]
    private string levelIndex;

    void OnMouseDown() {
        GameObject stateManager = GameObject.Find("StateManager");
        Application.LoadLevel(levelIndex);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
