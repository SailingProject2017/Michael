using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultUI : BaseObject {

    [SerializeField]
    private Sprite win;

    [SerializeField]
    private Sprite lose;

    private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () 
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Singleton<GameParam>.instance.Depth > Singleton<GameParam>.instance.EnemyDepth)
        {
            spriteRenderer.sprite = win;
        }
        else 
        {
            spriteRenderer.sprite = lose;
        }
	}
}
