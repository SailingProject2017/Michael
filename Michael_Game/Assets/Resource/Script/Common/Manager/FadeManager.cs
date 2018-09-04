using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FadeManager : BaseObject
{

    #region Singleton

    private static FadeManager _instance;

    public static FadeManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = (FadeManager)FindObjectOfType(typeof(FadeManager));
            }

            return _instance;
        }
    }

    #endregion Singleton

    [SerializeField]
    private Image fade;

    private Color fadeColor = Color.black;

    public void Start()
    {
        fade.raycastTarget = false;
    }
  

    public void Load(int scene)
    {
        FadeManager.instance.StartCoroutine(SceneLoad(scene));
    }

    IEnumerator SceneLoad(int scene)
    {

        fade.raycastTarget = true;
        fade.color = new Color(0, 0, 0, 0);

        // フェードイン
        while (fade.color.a < 1)
        {
            fade.color += new Color(0, 0, 0, 1f * (1.75f * Time.deltaTime));
            yield return null;
        }
        fade.color = new Color(0, 0, 0, 1);

        yield return null;

        SceneManager.LoadScene(scene);

        // フェードアウト
        while (fade.color.a > 0)
        {
            fade.color -= new Color(0, 0, 0, 1f * (1.75f * Time.deltaTime));
            yield return null;
        }

        fade.color = new Color(0, 0, 0, 0);
        fade.raycastTarget = false;
    }
}