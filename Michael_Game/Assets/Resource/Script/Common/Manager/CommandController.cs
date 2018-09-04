using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandController : BaseObject
{

    protected const int INPUT_COMMAND_NUM = 4; // 一度のフェーズで入力されるコマンドの上限

    protected List<int> commandList;

    protected List<string> inputButtonNameList;

    protected string inputButtonName;

    private int listNum;

    protected virtual void Start()
    {
        CommandInitialize();
    }

    protected virtual void CommandInitialize()
    {
        commandList = new List<int>();
        inputButtonNameList = new List<string>();

        InputButtonName = "NULL";
        listNum = 0;

        // リストのデータをクリア
        commandList.Clear();
        inputButtonNameList.Clear();

        // Addするお( *´艸｀)
        for (int i = 0; i < INPUT_COMMAND_NUM; i++)
        {
            // 8種類のボタンを入れる
            commandList.Add(Random.Range(0, 7));

            switch (commandList[i])
            {
                case 0:
                    inputButtonNameList.Add("A");
                    break;
                case 1:
                    inputButtonNameList.Add("X");
                    break;
                case 2:
                    inputButtonNameList.Add("Y");
                    break;
                case 3:
                    inputButtonNameList.Add("B");
                    break;
                case 4:
                    inputButtonNameList.Add("Up");
                    break;
                case 5:
                    inputButtonNameList.Add("Left");
                    break;
                case 6:
                    inputButtonNameList.Add("Right");
                    break;
                case 7:
                    inputButtonNameList.Add("Down");
                    break;

            }
        }
    }

    public string InputButtonName
    {
        set { inputButtonName = value; }
        get { return inputButtonName; }
    }

    public override void OnUpdate()
    {
        base.OnUpdate();

        if(inputButtonName != "NULL")
        {
            if(inputButtonNameList[listNum] == InputButtonName)
            {
                listNum++;
            }
        }

        // すべて入力が終わったら次のフェーズに移す
        if (listNum == INPUT_COMMAND_NUM) CommandInitialize();

    }

}