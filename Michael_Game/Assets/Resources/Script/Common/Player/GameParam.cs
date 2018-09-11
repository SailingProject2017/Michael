using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameParam {


    private int _depth;

    private int _enemyDepth;

    private bool isStartMy;
    private bool isStartYou;

    private float totalTime;

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

    public bool IsStartMy
    {
        set { isStartMy = value; }
        get { return isStartMy; }
    }

    public bool IsStartYou
    {
        set { isStartYou = value; }
        get { return isStartYou; }
    }

    public float TotalTime
    {
        set { totalTime = value; }
        get { return totalTime; }
    }
}
