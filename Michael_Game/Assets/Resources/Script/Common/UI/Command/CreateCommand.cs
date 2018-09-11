using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCommand : BaseObject {

    // 生成させたいSprite
    private GameObject commandSprite;

    // 生成場所
    [SerializeField]
    private GameObject canvas;

    [SerializeField]
    private GameObject [] commandArray;
    private GameObject[] prefab;

    private void Start()
    {
        prefab = new GameObject[4];
    }
    
    // コマンドを生成する
    private void NewCommand()
    {
        // 生成場所初期化
        var newPos = this.transform.position;
        newPos.x = -240;
        this.transform.position = newPos;

        for (int i = 0; i < 4; i++)
        {
            switch (BaseObjectSingleton<CommandController>.Instance.inputButtonNameList[i])
            {
                case "A":
                    commandSprite = commandArray[0];
                    break;
                case "X":
                    commandSprite = commandArray[1];
                    break;
                case "Y":
                    commandSprite = commandArray[2];
                    break;
                case "B":
                    commandSprite = commandArray[3];
                    break;
                case "Up":
                    commandSprite = commandArray[4];
                    break;
                case "Left":
                    commandSprite = commandArray[5];
                    break;
                case "Right":
                    commandSprite = commandArray[6];
                    break;
                case "Down":
                    commandSprite = commandArray[7];
                    break;
            }

            // 生成
            prefab[i] = (GameObject)Instantiate(commandSprite, this.transform.position, Quaternion.identity);
            prefab[i].transform.SetParent(canvas.transform, false);

            // 生成場所移動
            newPos = this.transform.position;
            newPos.x += 158;
            this.transform.position = newPos;
        }
        BaseObjectSingleton<CommandController>.Instance.IsCreateCommandUI = false;
    }

    private void DeleteCommand(int _num)
    {
        Destroy(prefab[_num]);
        BaseObjectSingleton<CommandController>.Instance.IsDeleteCommandUI = false;
        BaseObjectSingleton<CommandController>.Instance.ListNum++;
    }

    public override void OnUpdate()
    {
        base.OnUpdate();

        if (BaseObjectSingleton<CommandController>.Instance.IsCreateCommandUI)
            NewCommand();

        if (BaseObjectSingleton<CommandController>.Instance.IsDeleteCommandUI)
            DeleteCommand(BaseObjectSingleton<CommandController>.Instance.ListNum);
    }
}