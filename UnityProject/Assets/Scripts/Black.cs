using UnityEngine;
using UnityEngine.UI;

public class Black : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習


    [Header("血量")]
    public int BkHP = 10;

    [Header("顯示血量")]
    public Text BkHPgui;

    [Header("音效來源")]
    public AudioSource Bkaud;

    [Header("受傷音效")]
    public AudioClip Bkac1, Bkac2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
    }

    //直接從怪物取得子彈碰撞
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "子彈(Clone)")
        {
            if (BkHP > 0)
            {
                BkHP -= 1;
                BkHPgui.text = "" + BkHP;
                if (BkHP == 0) { BkHPgui.text = "有種你再開一槍!"; }
                Bkaud.PlayOneShot(Bkac1, 1f);
            }
            else
            {
                BkHPgui.text = "鞭屍阿!";
                Bkaud.PlayOneShot(Bkac2,1f);
            }
        }
        else
        {
            print("我不叫子彈，我叫:" + collision.gameObject.name);
        }
    }
    #endregion
}
