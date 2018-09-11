using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class OnClickButton : BaseObject {

    public void OnClickSingleButton()
    {
        SceneManager.LoadScene("SinglePlay");
    }

    public void OnClickDualButton()
    {
        SceneManager.LoadScene("Matching");
    }

    public void OnClickStartButton()
    {
        SceneManager.LoadScene("DualPlay");
    }

}
