using UnityEngine;
using System.Collections;

public class CWeaponPickup : MonoBehaviour {

    
    
    private void Awake()
    {

        disabledat();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _weapon.SetActive(true);
            //GetComponentInChildren<Transform>().gameObject.SetActive(true);
            // set players current weapon equal 
            // to the weapon data for this pickup
            //GetComponentInChildren<CWeapon>().transform.gameObject.SetActive(true);
            other.GetComponentInChildren<CPlayerWeapon>().WeaponPickup(_weapon.GetComponent<CWeapon>());
            Destroy(this.gameObject);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /// <summary>
    /// the weapon to set active when weaponpickup trigger event happens
    /// </summary>
    [SerializeField]
    private GameObject _weapon;


    [ContextMenu ("Garrethub")]
    void disabledat()
    {
        _weapon.SetActive(false);
    }
}
