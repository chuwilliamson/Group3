using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MaterialLib : MonoBehaviour
{

    private void Awake()
    {

        if (instance != null)
        {
            MaterialLib other = FindObjectOfType<MaterialLib>();
            Destroy(other);

        }
        else
        {
            instance = this.gameObject;

        }
    }

    public Material Get(string index)
    {
        Material mat = Resources.Load(index) as Material;
        Debug.Log(mat);
        return mat;
    }
    // Use this for initialization
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

    }


    public static GameObject Instance
    {
        get
        {
            return  instance;
        }

    }
    static GameObject instance;
}



