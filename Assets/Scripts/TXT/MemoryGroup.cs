using System;
using UnityEngine;
/* 
 * Author: Anisha Pai
 * Description: Allows json to store multiple memories
*/

[System.Serializable]
public class MemoryGroup : SerializableDataCollection<Memory>
{
    public Memory[] mmrs;

}
