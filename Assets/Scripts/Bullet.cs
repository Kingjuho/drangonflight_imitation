using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 15f;

    void Start()
    {
        
    }

    void Update()
    {
        // y축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    // 카메라 밖으로 나가면 호출되는 함수
    private void OnBecameInvisible() { Destroy(gameObject); }

    // isTrigger가 있는 물체와 충돌했을 때 호출되는 함수

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 충돌한 객체의 태그가 Enemy일 시
        if (collision.gameObject.CompareTag("Enemy")) 
        {
            // 플레이어 스코어 증가
            GameManager.instance.Addscore(100);

            // ICombat 인터페이스가 있는지 체크, 있으면 Dead() 호출
            if (collision.TryGetComponent<ICombat>(out ICombat target)) target.Dead();
        }

        // 부딪히면 무조건 삭제
        Destroy(gameObject);
    }
}