using UnityEngine;

public class Bullet : MonoBehaviour
{
    #region KID 區域 - 不要偷看 @3@
    [Header("讓子彈飛的速度"), Range(0f, 2000f)]
    public float speed = 1.5f;
    [Header("剛體")]
    public Rigidbody2D rig;

    private void Start()
    {
        Move();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject, 0.03f);
    }

    //子彈飛出攝影機時刪除物件
    private void OnBecameInvisible()
    {
        Destroy(gameObject, 0.03f);
    }
    /// <summary>
    /// 讓子彈飛
    /// </summary>
    private void Move()
    {
        rig.AddForce(transform.right * speed);
    }
    #endregion
}
