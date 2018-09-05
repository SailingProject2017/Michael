using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDepthRenderer : BaseObject
{

    [SerializeField]
    private Sprite[] sprite;

    [SerializeField]
    private GameObject[] gameObjects;

    private SpriteRenderer[] spriteRenderer;

    void Start()
    {
        spriteRenderer = new SpriteRenderer[4];

        for (int i = 0; i < 4; i++)
        {
            spriteRenderer[i] = gameObjects[i].GetComponent<SpriteRenderer>();
            Debug.Log(spriteRenderer[i]);
        }

    }

    public override void OnUpdate()
    {
        base.OnUpdate();
        ClucDepth();
    }

    private void ChangeSprite(int _depth, int keta)
    {
        keta--;

        switch (_depth)
        {
            case 0:
                spriteRenderer[keta].sprite = sprite[0];
                break;

            case 1:
                spriteRenderer[keta].sprite = sprite[1];
                break;

            case 2:
                spriteRenderer[keta].sprite = sprite[2];
                break;

            case 3:
                spriteRenderer[keta].sprite = sprite[3];
                break;

            case 4:
                spriteRenderer[keta].sprite = sprite[4];
                break;

            case 5:
                spriteRenderer[keta].sprite = sprite[5];
                break;

            case 6:
                spriteRenderer[keta].sprite = sprite[6];
                break;

            case 7:
                spriteRenderer[keta].sprite = sprite[7];
                break;

            case 8:
                spriteRenderer[keta].sprite = sprite[8];
                break;

            case 9:
                spriteRenderer[keta].sprite = sprite[9];
                break;

            default:
                spriteRenderer[keta].sprite = sprite[0];
                break;
        }
    }

    private void ClucDepth()
    {

        int depth;

        switch (Singleton<GameParam>.instance.EnemyDepth.ToString().Length)
        {
            case 1:
                // 1桁目を表示
                ChangeSprite(Singleton<GameParam>.instance.EnemyDepth, 1);
                break;

            case 2:
                // 2桁目を表示
                ChangeSprite(Singleton<GameParam>.instance.EnemyDepth / 10, 2);
                depth = Singleton<GameParam>.instance.EnemyDepth % 10;

                // 1桁目を表示
                ChangeSprite(depth, 1);
                break;

            case 3:
                // 3桁目を表示
                ChangeSprite(Singleton<GameParam>.instance.EnemyDepth / 100, 3);
                depth = Singleton<GameParam>.instance.EnemyDepth % 100;

                // 2桁目を表示
                ChangeSprite(depth / 10, 2);
                depth = Singleton<GameParam>.instance.EnemyDepth % 10;

                // 1桁目を表示
                ChangeSprite(depth, 1);

                break;


            case 4:
                // 4桁目を表示
                ChangeSprite(Singleton<GameParam>.instance.EnemyDepth / 1000, 4);
                depth = Singleton<GameParam>.instance.EnemyDepth % 1000;

                // 3桁目を表示
                ChangeSprite(depth / 100, 3);
                depth = Singleton<GameParam>.instance.EnemyDepth % 100;

                // 2桁目を表示
                ChangeSprite(depth / 10, 2);
                depth = Singleton<GameParam>.instance.EnemyDepth % 10;

                // 1桁目を表示
                ChangeSprite(depth, 1);
                break;


            default:

                break;
        }
    }


}

