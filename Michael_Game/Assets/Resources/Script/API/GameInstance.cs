/**********************************************************************************************/
/*@file       GameInstance.cs
*********************************************************************************************
* @brief      保持する必要のあるすべてのクラスインスタンスを管理するためのクラス
*********************************************************************************************
* @author     Ryo Sugiyama
*********************************************************************************************
* Copyright © 2017 Ryo Sugiyama All Rights Reserved.
**********************************************************************************************/

public class GameInstance : BaseObjectSingleton<GameInstance>
{

    /* inGame関連 */
    
    private bool isPorse;      // @brief ポーズ中かどうか判別する変数
    private bool isPlayGame;   // @brief mainゲームを遊んでいるかどうかを判別
    

    protected override void AppendListConstructor()
    {
        base.AppendListConstructor();
    
        isPorse = false;
        isPlayGame = false;
     
    }

    #region ポーズ判定
    /********************************************************************************************/
 
    /// <summary>
    /// @brief isPorseの変数アクセサー
    /// </summary>
    public bool IsPorse
    {
        set { isPorse = value; }
        get { return isPorse; }
    }
    #endregion

    #region ゲーム判定
    /********************************************************************************************/

    /// <summary>
    /// @brief isPlayGameの変数アクセサー
    /// </summary>
    public bool IsPlayGame
    {
        set { isPlayGame = value; }
        get { return isPlayGame; }
    }
    #endregion

}
