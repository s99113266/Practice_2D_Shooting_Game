using UnityEngine;

public class White : MonoBehaviour
{

    #region KID 區域 - 不要偷看 @3@
    [Header("移動速度"), Range(0f, 100f)]
    public float speed = 1.5f;

    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shot();
        }
    }

    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        rig.AddForce(transform.right * Input.GetAxisRaw("Horizontal") * speed);
    }
    #endregion

    #region 練習區域 - 在此區域內練習
    [Header("子彈預制物")]
    public GameObject Bullet;

    [Header("音效來源")]
    public AudioSource aud;

    [Header("音效物件")]
    public AudioClip ac;
    public void shot()
    {
        Instantiate(Bullet,new Vector3(rig.transform.position.x + 2.2f, rig.transform.position.y - 0.1f, 0), Quaternion.identity);
        aud.PlayOneShot(ac, 1.5f);
    }


    #endregion
}
