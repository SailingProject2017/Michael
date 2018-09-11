using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : BaseObject
{


    public override void OnUpdate()
    {
        base.OnUpdate();

        if (BaseObjectSingleton<CommandController>.Instance.IsMove)
        {
            this.transform.position += new Vector3(0, 1, 0);
            BaseObjectSingleton<CommandController>.Instance.IsMove = false;
        }
    }


}