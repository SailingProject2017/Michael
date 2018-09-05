using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputButton : CommandController
{




    public override void OnUpdate()
    {
        base.OnUpdate();


        if (Input.GetButtonDown("A")) inputButtonName = "A";
        if (Input.GetButtonDown("X")) inputButtonName = "X";
        if (Input.GetButtonDown("Y")) inputButtonName = "Y";
        if (Input.GetButtonDown("B")) inputButtonName = "B";

        if (Input.GetButtonDown("Up")) inputButtonName = "Up";
        if (Input.GetButtonDown("Left")) inputButtonName = "Left";
        if (Input.GetButtonDown("Right")) inputButtonName = "Right";
        if (Input.GetButtonDown("Down")) inputButtonName = "Down";

        // 入力されたボタンを親クラスに通知
        base.InputButtonName = inputButtonName;
    }

}
