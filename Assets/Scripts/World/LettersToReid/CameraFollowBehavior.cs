using UnityEngine;
using System.Collections;

public class CameraFollowBehavior : MonoBehaviour {

    //Script for camera following character

    public Camera cameraFollow;
    public Canvas memoryCanvas;
    public GameObject character;
    public float xOffset = 2;
    public float yOffset = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        cameraFollow.transform.position = new Vector3(character.transform.position.x + xOffset, character.transform.position.y + yOffset, -10);
        memoryCanvas.transform.position = new Vector3(character.transform.position.x + xOffset, character.transform.position.y + yOffset, 0);
	
	}
}
