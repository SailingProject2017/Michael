using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameParam {


    private int _depth;

    private int _enemyDepth;

    public int Depth
    {
        set { _depth = value; }
        get { return _depth; }
    }

    public int EnemyDepth
    {
        set { _enemyDepth = value; }
        get { return _enemyDepth; }
    }
}
