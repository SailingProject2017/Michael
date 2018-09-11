using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : BaseObject
{


    [SerializeField]
    private Sprite[] sprite;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject playerSprite;

    private SpriteRenderer spriteRenderer;


    private void Start()
    {
        spriteRenderer = playerSprite.GetComponent<SpriteRenderer>();
    }

    public override void OnUpdate()
    {
        base.OnUpdate();

        if (BaseObjectSingleton<CommandController>.Instance.IsMove)
        {
            this.transform.position += new Vector3(0, 1, 0);


            if(spriteRenderer.sprite == sprite[0])
            {
                spriteRenderer.sprite = sprite[1];
            }
            else if(spriteRenderer.sprite == sprite[1])
            {
                spriteRenderer.sprite = sprite[0];   
            }

            Singleton<GameParam>.instance.Depth += 1;
            BaseObjectSingleton<CommandController>.Instance.IsMove = false;
        }
    }


}