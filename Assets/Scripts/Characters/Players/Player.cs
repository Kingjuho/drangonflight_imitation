using UnityEngine;

public class Player : CombatEntity
{
    public float moveSpeed = 5f;

    void Start()
    {
        
    }

    void Update()
    {
        // 방향 * 시간 * 스피드
        float distanceX = Input.GetAxisRaw("Horizontal") * Time.deltaTime * moveSpeed;
        transform.Translate(distanceX, 0, 0);
    }

    // isTrigger가 있는 물체와 충돌했을 때 호출되는 함수
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 충돌한 객체의 태그가 Enemy일 시 Dead()
        if (collision.gameObject.CompareTag("Enemy")) Dead();
    }

}