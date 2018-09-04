using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : CommandController
{

    private int inputCnt;

    protected override void Start()
    {
        base.Start();
        inputCnt = 0;
        RandomDecideCommand(); // 入力するボタンを決定する
    }

    public override void OnUpdate()
    {
        base.OnUpdate();

        // ゲームプレイフラグがtrueのときだけしか操作しちゃだめ
        if (BaseObjectSingleton<GameInstance>.Instance.IsPlayGame)
        {

            if (Input.GetButtonDown(inputButtonName[inputCnt]))
            {
                inputCnt++;

                // 一度のフェーズのボタンが入力し終わったらもう一度入力するボタンを決定する
                if (inputCnt == INPUT_COMMAND_NUM)
                {
                    // todo 上るアニメーション

                    RandomDecideCommand();
                }
            }
        }
    }
}