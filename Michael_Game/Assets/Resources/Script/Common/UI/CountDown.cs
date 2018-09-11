using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//カウントダウンのソース
public class CountDown : BaseObject
{
    //カウントダウンのテキストの表示
    [SerializeField]
    private Text _textCountdown;

    string currentScene;

    bool callOne;

    void Start()
    {
        _textCountdown.text = "";
        currentScene = SceneManager.GetActiveScene().name;
        callOne = false;

        if (currentScene == "SinglePlay")
        {
            StartCoroutine(CountdownCoroutine()); // ゲーム開始時コルーチン開始
        }
    }

    public override void OnUpdate()
    {
        base.OnUpdate();
        if (currentScene == "DualPlay")
        {
            if (Singleton<GameParam>.instance.IsStartMy == true && Singleton<GameParam>.instance.IsStartYou == true && !callOne) 
            {
                StartCoroutine(CountdownCoroutine()); // ゲーム開始時コルーチン開始
                callOne = true;
            }
        }
    }

    //ボタンをクリックしたら、CountdownCoroutine　を呼ぶ
    public void OnClickButtonStart()
    {
        StartCoroutine(CountdownCoroutine());
    }

    // CountdownCoroutine が呼ばれたら、始まる
    IEnumerator CountdownCoroutine()
    {
        _textCountdown.gameObject.SetActive(true);

        _textCountdown.text = "3";
        yield return new WaitForSeconds(1.0f);      //1秒のインターバルがある

        _textCountdown.text = "2";
        yield return new WaitForSeconds(1.0f);      //1秒のインターバルがある

        _textCountdown.text = "1";
        yield return new WaitForSeconds(1.0f);      //1秒のインターバルがある

        _textCountdown.text = "GO!";
        yield return new WaitForSeconds(1.0f);      //1秒のインターバルがある
        BaseObjectSingleton<GameInstance>.Instance.IsPlayGame = true;
        _textCountdown.text = "";
        _textCountdown.gameObject.SetActive(false);
      
    }
}