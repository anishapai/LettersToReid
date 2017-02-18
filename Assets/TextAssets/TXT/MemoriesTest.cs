using UnityEngine;

/* Author: Anisha Pai
 * Description: Tests converting a single json file
 */

public class Memories : MonoBehaviour 
{

    public TextAsset jsonMemory;

    public void Start() {

            Memory memories = JsonUtility.FromJson<Memory>(jsonMemory.text);
            print(memories.body);
 
    }
}
