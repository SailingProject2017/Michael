using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class PlayerMove : CommandController
{
    
    private int inputCnt;

    [SerializeField]
    private Sprite[] sprite;

    [SerializeField]
    private GameObject player;

    private SpriteRenderer spriteRenderer;

    protected override void Start()
    {
        base.Start();
        inputCnt = 0;
        //RandomDecideCommand(); // 入力するボタンを決定する
        spriteRenderer = player.GetComponent<SpriteRenderer>();
    }

    public override void OnUpdate()
    {
        base.OnUpdate();
        Singleton<GameParam>.instance.Depth++;

        // ゲームプレイフラグがtrueのときだけしか操作しちゃだめ
        if (BaseObjectSingleton<GameInstance>.Instance.IsPlayGame)
        {

           // if (Input.GetButtonDown(inputButtonName[inputCnt]))
            //{
                inputCnt++;

                // 一度のフェーズのボタンが入力し終わったらもう一度入力するボタンを決定する
                if (inputCnt == INPUT_COMMAND_NUM)
                {
                    // 画像切り替え
                    if(inputCnt % 2 == 1)
                    {
                        spriteRenderer.sprite = sprite[0];
                    }
                    else if(inputCnt % 2 == 0)
                    {
                        spriteRenderer.sprite = sprite[1];
                    }



                    //RandomDecideCommand(); 
                }
           // }
        }
    }

}
*/