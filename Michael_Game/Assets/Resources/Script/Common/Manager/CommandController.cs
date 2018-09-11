using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandController : BaseObjectSingleton<CommandController>
{

    public const int INPUT_COMMAND_NUM = 4; // 一度のフェーズで入力されるコマンドの上限

    private List<int> commandList;

    public List<string> inputButtonNameList;

    private string inputButtonName;
    private bool isCreateCommandUI;
    private bool isDeleteCommandUI;
    private bool isMove = false;
    private bool isGame = false;
    private int listNum = 0;



    public string InputButtonName
    {
        set { inputButtonName = value; }
        get { return inputButtonName; }
    }

    public bool IsCreateCommandUI
    {
        set { isCreateCommandUI = value; }
        get { return isCreateCommandUI; }
    }

    public bool IsDeleteCommandUI
    {
        set { isDeleteCommandUI = value; }
        get { return isDeleteCommandUI; }
    }

    public bool IsMove
    {
        set { isMove = value; }
        get { return isMove; }
    }

    public bool IsGame
    {
        set { isGame = value; }
        get { return isGame; }
    }

    public int ListNum
    {
        set { listNum = value; }
        get { return listNum; }
    }

    private void Start()
    {
        commandList = new List<int>();
        inputButtonNameList = new List<string>();

        CommandInitialize();
    }

    private void CommandInitialize()
    {

        // アクセサーの初期化
        InputButtonName = "NULL";
        IsCreateCommandUI = false;
        IsDeleteCommandUI = false;
        ListNum = 0;

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

        // UI作成用メソッドの呼び出しフラグを立てる
        IsCreateCommandUI = true;
    }

    public override void OnUpdate()
    {
        base.OnUpdate();

        if (IsGame)
        {
           
            // debug用
            //if (Input.GetKeyDown("a"))
            //{
            //    Debug.Log(ListNum);
            //    IsDeleteCommandUI = true;
            //    Debug.Log(ListNum);
            //}

            // すべて入力が終わったら次のフェーズに移す
            if (listNum == INPUT_COMMAND_NUM)
            {
                // 動く！
                IsMove = true;
                CommandInitialize();
                ListNum = 0;
            }

            if (inputButtonName != "NULL")
            {
                if (inputButtonNameList[ListNum] == InputButtonName)
                {
                    IsDeleteCommandUI = true;
                }
            }
        }
    }
}