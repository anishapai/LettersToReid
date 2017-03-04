using UnityEngine;
using UnityEngine.UI;
/* Author: Anisha Pai
* Description: Tests the Memory retrieval system by asking to print a random memory
*/
public sealed class TestingMemory : MonoBehaviour
{
    MemoriesParser parse;
    System.Random IDgen = new System.Random();
    Text text;

    public void Start() {

        parse = GetComponent<MemoriesParser>();
        text = GetComponent<Text>();


                text.text = parse.getMemory(IDgen.Next(1, parse.getLength()));
                // the getMemory input can be changed to test a specific memory
                print(parse.getMemory(IDgen.Next(1, parse.getLength())));
    }
}
