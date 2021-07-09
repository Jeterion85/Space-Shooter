using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Conversation", menuName = "Dialogue/new Conversation")]
public class Conversation : ScriptableObject
{
    [SerializeField] public Dialogue[] dialoguelines;

    public Dialogue GetLineByIndex(int index)
    {
        return dialoguelines[index];
    }
    public int Getlength()
    {
        return dialoguelines.Length -1;
    }
}
