using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputButton : BaseObject
{

    private string inputButtonName;

    public override void OnUpdate()
    {
        base.OnUpdate();
        if (BaseObjectSingleton<CommandController>.Instance.IsGame)
        {

            // ゲームパット
            if (Input.GetButtonDown("A")) inputButtonName = "A";
            if (Input.GetButtonDown("X")) inputButtonName = "X";
            if (Input.GetButtonDown("Y")) inputButtonName = "Y";
            if (Input.GetButtonDown("B")) inputButtonName = "B";

            if (Input.GetButtonDown("Up")) inputButtonName = "Up";
            if (Input.GetButtonDown("Left")) inputButtonName = "Left";
            if (Input.GetButtonDown("Right")) inputButtonName = "Right";
            if (Input.GetButtonDown("Down")) inputButtonName = "Down";

            // キーボード
            if (Input.GetKeyDown("a")) inputButtonName = "A";
            if (Input.GetKeyDown("x")) inputButtonName = "X";
            if (Input.GetKeyDown("y")) inputButtonName = "Y";
            if (Input.GetKeyDown("b")) inputButtonName = "B";

            if (Input.GetKeyDown("UpArrow")) inputButtonName = "Up";
            if (Input.GetKeyDown("LeftArrow")) inputButtonName = "Left";
            if (Input.GetKeyDown("RightArrow")) inputButtonName = "Right";
            if (Input.GetKeyDown("DownArrow")) inputButtonName = "Down";

            // 入力されたボタンを代入
            BaseObjectSingleton<CommandController>.Instance.InputButtonName = inputButtonName;
        }

    }
}