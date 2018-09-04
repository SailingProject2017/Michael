using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCommand : CommandController {

    // 生成させたいSprite
    private GameObject commandSprite;

    // 生成場所
    [SerializeField]
    private GameObject canvas;

    [SerializeField]
    private GameObject [] commandArray;

    protected override void CommandInitialize()
    {
        base.CommandInitialize();

        commandArray = new GameObject[7];
    }

    // コマンドを生成する
    public void NewCommand()
    {

        // 生成場所初期化
        var newPos = this.transform.position;
        newPos.x = 0;
        this.transform.position = newPos;

        for (int i = 0; i < INPUT_COMMAND_NUM; i++) {
            switch (inputButtonNameList[i])
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
            GameObject prefab = (GameObject)Instantiate(commandSprite, this.transform.position,Quaternion.identity);
            prefab.transform.SetParent(canvas.transform, false);

            // 生成場所移動
            newPos = this.transform.position;
            newPos.x += 25;
            this.transform.position = newPos;
        }
    }

}
