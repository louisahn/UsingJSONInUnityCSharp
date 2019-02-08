using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrativeEvent
{
    public List<Dialogue> dialogues;
}

public struct Dialogue
{
    public CharacterType characterType;
    public string name;
    public string characterImageName;
    public string dialogText;
    public List<SceneImg> sceneImgs;
}
public struct SceneImg
{
    public float posX;
    public float posY;
    public float scale;
    public string imgName;
}

public enum CharacterType
{
    Gina, Rocky
}