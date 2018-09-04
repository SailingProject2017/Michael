using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum SCENE
{
    TITLE,
    SINGLE_GAME,
    MULTI_GAME,
    RESULT,
    MATCHING,
    NULL
}

namespace Scene
{
    public static class SceneManager
    {
        public static void SceneMove(SCENE NextScene)
        {
            FadeManager.instance.Load((int)NextScene);
        }
       
    }
}