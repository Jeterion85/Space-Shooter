using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Speaker", menuName = "Dialogue/new Speaker")]
public class Speaker : ScriptableObject
{
    [SerializeField] private string speakerName;
    [SerializeField] private Sprite speakerImage;

    public string GetName()
    {
        return speakerName;
    }
    public Sprite GetImage()
    {
        return speakerImage;
    }
}