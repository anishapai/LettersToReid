using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;
using System.IO;
/* Author: Anisha Pai
* Description: Retrieves a memory with method getMemory(int id)
*/

public class MemoriesParser: MonoBehaviour {

    public TextAsset jsonMemory;
    MemoryGroup allMemories;

    public void Awake() {

        jsonMemory = (TextAsset)Resources.Load("jsonMemories") as TextAsset;
        allMemories = JsonUtility.FromJson<MemoryGroup>(jsonMemory.text);
    }

    public String getMemory(int id) {
        foreach (Memory searchMemory in allMemories.mmrs) {
            if (searchMemory.id == id) {
                return searchMemory.Body;
            }
        }
        return "Memory not found. Choose an id number that is an integer between 1 and " + allMemories.mmrs.Length;
    }

    public int getLength() {
        return allMemories.mmrs.Length;
    }

    public TextAsset getJson() {
        return jsonMemory;
    }
}
