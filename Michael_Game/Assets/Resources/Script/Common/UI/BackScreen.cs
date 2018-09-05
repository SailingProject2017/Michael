using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackScreen : BaseObject
{

    // 背景が切り替わるタイミング カメラのpositionで判断
    private int changeBackGroundMeter = 10;

    private const int BACKGROUND_SIZE = 36;

    [SerializeField]
    private GameObject BackGround_1;
    [SerializeField]
    private GameObject BackGround_2;


    public override void OnUpdate()
    {
        base.OnUpdate();

        // 指定した場所までカメラが移動したら生成用の関数を呼び出す
        if(this.transform.position.y > changeBackGroundMeter)
        {
            CreateBackGround();
        }
    }

    public void CreateBackGround()
    {
        if(BackGround_1.transform.position.y < changeBackGroundMeter)
        {
            changeBackGroundMeter += BACKGROUND_SIZE;
            Vector3 temp = new Vector3(0, changeBackGroundMeter, 0);
            BackGround_1.transform.position = temp;
        }
        else if (BackGround_2.transform.position.y < changeBackGroundMeter)
        {
            changeBackGroundMeter += BACKGROUND_SIZE;
            Vector3 temp = new Vector3(0, changeBackGroundMeter, 0);
            BackGround_2.transform.position = temp;
        }


    }
}