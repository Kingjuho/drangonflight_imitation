using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.InputSystem.Processors;

public class Enemy : CombatEntity
{
    public float moveSpeed = 2f;

    void Start()
    {
        
    }

    void Update()
    {
        // Y축 이동
        float distanceY = Time.deltaTime * moveSpeed * -1;
        transform.Translate(0, distanceY, 0);
    }

    // 카메라 밖으로 나가면 호출되는 함수
    private void OnBecameInvisible() { Destroy(gameObject); }

    // isTrigger가 있는 물체와 충돌했을 때 호출되는 함수
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // collision.gameObject.tag보다 안전한 방식
        if (collision.gameObject.CompareTag("Player")) Dead();
    }

    // 사망 처리
    public override void Dead()
    {
        // 사운드 재생
        if (SoundManager.instance != null) SoundManager.instance.Dead();
        base.Dead();
    }
}