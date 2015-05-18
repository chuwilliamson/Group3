using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	private float lastSynchronizationTime = 0f;
	private float syncDelay = 0f;
	private float syncTime = 0f;
	private Vector3 syncStartPosition = Vector3.zero;
	private Vector3 syncEndPosition = Vector3.zero;
	public float speed = 10f;



	void Update()
	{
		if (GetComponent<NetworkView> ().isMine) 
				{
					InputMovement ();
					//InputColorChange ();
				} 
		else 	{
					SyncedMovement ();
				}

	}

	/*
	private void InputColorChange()
	{
		if (Input.GetKeyDown (KeyCode.R))
			ChangeColorTo (new Vector3 (Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f)));
	
	}    
	*/
	/*
	 *[RPC] void ChangeColorTo(Vector3 Color)
	{
		GetComponent<Renderer>().material.color = new Color (Color.x, Color.y, Color.z, 1f);
		if (GetComponent<NetworkView>().isMine)
						GetComponent<NetworkView>().RPC ("ChangeColorTo", RPCMode.OthersBuffered, Color);
	}
	*/

	void InputMovement()
	{
		if (Input.GetKey(KeyCode.W))
			GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + Vector3.forward * speed * Time.deltaTime);
		
		if (Input.GetKey(KeyCode.S))
			GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position - Vector3.forward * speed * Time.deltaTime);
		
		if (Input.GetKey(KeyCode.D))
			GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + Vector3.right * speed * Time.deltaTime);
		
		if (Input.GetKey(KeyCode.A))
			GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position - Vector3.right * speed * Time.deltaTime);
	}

	void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info)
	{
		Vector3 syncPosition = Vector3.zero;
		Vector3 syncVelocity = Vector3.zero;
		if (stream.isWriting) 
		{
			syncPosition = GetComponent<Rigidbody>().position;
			stream.Serialize (ref syncPosition);

			syncVelocity = GetComponent<Rigidbody>().velocity;
			stream.Serialize (ref syncVelocity);
		} 
		else 	
		{
			stream.Serialize (ref syncPosition);
			stream.Serialize (ref syncVelocity);
			
			syncTime = 0f;
			syncDelay = Time.time - lastSynchronizationTime;
			lastSynchronizationTime = Time.time;

			syncEndPosition = syncPosition + syncVelocity * syncDelay;
			syncStartPosition = GetComponent<Rigidbody>().position;
			
		}
	}

	private void SyncedMovement()
	{
		syncTime += Time.deltaTime;
		GetComponent<Rigidbody>().position = Vector3.Lerp (syncStartPosition, syncEndPosition, syncTime / syncDelay);


	}

		
}