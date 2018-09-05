using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimMan : BaseObject {

    [SerializeField]
    private Sprite[] sprite;

    private SpriteRenderer spriteRenderer;

    private int cnt;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        cnt = 0;
    }
	
	// Update is called once per frame
	public override void OnUpdate () 
    {
        base.OnUpdate();
        cnt++;


        if (cnt == 5)
        {
            spriteRenderer.sprite = sprite[0];
        }
        else if(cnt == 10)
        {
            spriteRenderer.sprite = sprite[1];
            cnt = 0;
        }
	}
}
