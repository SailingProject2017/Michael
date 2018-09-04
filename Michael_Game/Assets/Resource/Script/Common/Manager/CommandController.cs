using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandController : BaseObject
{

    protected const int INPUT_COMMAND_NUM = 4; // 一度のフェーズで入力されるコマンドの上限

    protected List<int> commandList;

    protected List<string> inputButtonName;

    protected virtual void Start()
    {
        commandList = new List<int>();
        inputButtonName = new List<string>();
    }

    // 入力しなくてはいけないコマンドを決めるメソッド
    public void RandomDecideCommand()
    {

        // 最初に前のフェーズのコレクションをきれいにしてから
        inputButtonName.Clear();

        // Addするお( *´艸｀)
        for (int i = 0; i < INPUT_COMMAND_NUM; i++)
        {
            // 8種類のボタンを入れる
            commandList.Add(Random.Range(0, 7));

            switch (commandList[i])
            {
                case 0:
                    inputButtonName.Add("A");
                    break;
                case 1:
                    inputButtonName.Add("X");
                    break;
                case 2:
                    inputButtonName.Add("Y");
                    break;
                case 3:
                    inputButtonName.Add("B");
                    break;
                case 4:
                    inputButtonName.Add("Up");
                    break;
                case 5:
                    inputButtonName.Add("Left");
                    break;
                case 6:
                    inputButtonName.Add("Right");
                    break;
                case 7:
                    inputButtonName.Add("Down");
                    break;

            }
        }
    }
}