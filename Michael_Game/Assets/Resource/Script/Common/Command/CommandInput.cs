using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInput : CommandController
{

    protected override void Start()
    {
        base.Start();
    }

    public void Command()
    {
        // 入力されたkeyを判断する
        if (Input.anyKeyDown)
        {
            foreach (var _key in Input.inputString)
            {
                CommandListComparison(_key);
                Debug.Log(_key);
            }

        }
    }

    // コマンドリストと入力されたコマンドが一致しているかの比較を行う
    public void CommandListComparison(int _key)
    {
        Debug.Log(_key);
        for (int i = 0; i < INPUT_COMMAND_NUM; i++)
        {
            if (_key == commandList[i])
            {
                Debug.Log("hit");
                commandList[i]= 9999;
            }
        }
    }
}
