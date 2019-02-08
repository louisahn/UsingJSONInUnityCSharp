using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JSonFactory;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    void Awake()
    {

        NarrativeEvent testEvent = JSonAssembly.RunJSonFactory4Scene(1);
        Debug.Log(testEvent.dialogues[0].sceneImgs[0].imgName);

        Debug.Log(testEvent.dialogues[0].sceneImgs[0].posX);
    }


}
