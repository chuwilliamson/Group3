using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CGameGUI : MonoBehaviour {
    public float health;
    [SerializeField]
    private Text healthText;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        healthText.text = health.ToString();	
	}
}
