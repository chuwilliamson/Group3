using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


    public float speed;
    public float rotSpeed;
    private CharacterController charCon ;
    private float charYPos;
    private Vector3 forwardVec;
    private Vector3 rightVec;

void Awake()
    {
        rightVec = new Vector3(1, 0, 0);
        forwardVec = new Vector3(0, 0, 1);
        charCon = GetComponent< CharacterController > ();
    }

    void Start()
    {

        charYPos = transform.position.y;
    }

    void FixedUpdate()
    {

        transform.position = new Vector3(transform.position.x, charYPos, transform.position.z);

        if (Input.GetAxis("Vertical") > -1 || Input.GetAxis("Vertical") < 1)
        {

            charCon.Move(forwardVec * Input.GetAxis("Vertical") * Time.deltaTime * speed);
        }

        if (Input.GetAxis("Horizontal") > -1 || Input.GetAxis("Horizontal") < 1)
        {

            charCon.Move(rightVec * Input.GetAxis("Horizontal") * Time.deltaTime * speed);
        }

        var playerPlane = MakePlane(Vector3.up, transform.position);
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitDist = 0.0f;

        if (playerPlane.Raycast(ray, out hitDist))
        {

            var targetPoint = ray.GetPoint(hitDist);
            var targetRotation = Quaternion.LookRotation(targetPoint - transform.position);

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotSpeed);
        }
    }

    Plane MakePlane( Vector3 dir,Vector3 pos)
    {

        var plane = new Plane(dir, pos);
        return plane;
    }
}
