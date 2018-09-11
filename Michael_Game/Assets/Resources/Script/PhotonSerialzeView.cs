using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonSerialzeView : Photon.MonoBehaviour {

    void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.isWriting)
        {
            //データの送信
            stream.SendNext(Singleton<GameParam>.instance.Depth);
            stream.SendNext(Singleton<GameParam>.instance.IsStartMy);
            if (PhotonNetwork.isMasterClient)
                stream.SendNext(Singleton<GameParam>.instance.TotalTime);
            Debug.Log("SEND");
        }
        else
        {
            //データの受信
            Singleton<GameParam>.instance.EnemyDepth = (int)stream.ReceiveNext();
            Singleton<GameParam>.instance.IsStartYou = (bool)stream.ReceiveNext();
            if(!PhotonNetwork.isMasterClient)
                Singleton<GameParam>.instance.TotalTime = (float)stream.ReceiveNext();
            Debug.Log("Receive");
        }
    }
}
