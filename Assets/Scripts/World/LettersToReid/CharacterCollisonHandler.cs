using UnityEngine;
using System.Collections;

public class CharacterCollisonHandler : MonoBehaviour{
	public MyCharacterController charactor;
	public MemoryBehvior memory;
	public bool memoryRead = false;
	public int  enemyHits = 0;

	Vector3[] memoryLocations = { new Vector3(5.76f, 0.26f, 0), new Vector3(16.21f, 2.37f, 0),
		new Vector3(7.1f, 2.43f, 0), new Vector3(-6.06f, 2.43f, 0), new Vector3(-10.66f, 4.55f, 0),
		new Vector3(-16.82f, 6.74f, 0), new Vector3(3.77f, 6.69f, 0), new Vector3(11.13f, 4.56f, 0),
		new Vector3(13.46f, 8.91f, 0), new Vector3(15.87f, 11.08f, 0)};

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.collider.tag == "ground") {
			charactor.isGrounded = true;
		} 
		else if (col.gameObject.tag == "ladder") {
			charactor.canClimb = true;
			Debug.Log ("Enter");
		} 
		else if (col.gameObject.tag == "enemy") {
			
			transform.position = memoryLocations [enemyHits];

			if (enemyHits < 9) {
				enemyHits++;
			} else if (enemyHits >= 9) {
				enemyHits = 0;
			}
		} 
		else if (col.gameObject.tag == "memory") {
			if (!memoryRead) {
				memory.showMemory ();
				memoryRead = true;
				memory.closeMemory ();
			} 
			else {
				memory.showMemory ();
			}
		}
	}

	void OnCollisionExit2D(Collision2D col2)
	{
		if (col2.gameObject.tag == "ladder")
		{
			charactor.canClimb = false;
			Debug.Log("Exit");
		}
	}
		
}