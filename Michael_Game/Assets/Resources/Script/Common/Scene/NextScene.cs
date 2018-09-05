using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scene;

public class NextScene : BaseObject {

    [SerializeField]
    private SCENE nextScene;

    public void OnTap()
    {
        SceneManager.SceneMove(nextScene);
    }
}
