using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class endTutorialLevel : abstractEndLevel
{
    // Start is called before the first frame update
    protected override void Start()
    {
        sceneNameToChangeInto = "Level 2";
    }

}
