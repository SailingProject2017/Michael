using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagScreen : BaseObject
{

    // 背景が切り替わるタイミング カメラのpositionで判断
    private float changeBagGroundMeter = 10.0f;

    private const int BAGGROUND_SIZE = 36;

    [SerializeField]
    private GameObject BagGround_1;
    [SerializeField]
    private GameObject BagGround_2;


    public override void OnUpdate()
    {
        base.OnUpdate();

        // 指定した場所までカメラが移動したら生成用の関数を呼び出す
        if(this.transform.position.y > changeBagGroundMeter)
        {
            CreateBagGround();
        }
    }

    public void CreateBagGround()
    {
        if(BagGround_1.transform.position.y < changeBagGroundMeter)
        {
            changeBagGroundMeter += BAGGROUND_SIZE;
            Vector3 temp = new Vector3(0, changeBagGroundMeter, 0);
            BagGround_1.transform.position = temp;
        }
        else if (BagGround_2.transform.position.y < changeBagGroundMeter)
        {
            changeBagGroundMeter += BAGGROUND_SIZE;
            Vector3 temp = new Vector3(0, changeBagGroundMeter, 0);
            BagGround_2.transform.position = temp;
        }


    }
}