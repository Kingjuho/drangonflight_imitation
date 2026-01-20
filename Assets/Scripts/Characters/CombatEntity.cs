using UnityEngine;

public class CombatEntity : MonoBehaviour, ICombat
{
    public GameObject deadEffect;

    // 사망 처리
    public virtual void Dead()
    {
        DeadEffect();
        Destroy(gameObject);
    }

    // 사망 이펙트
    public void DeadEffect()
    {
        GameObject go = Instantiate(deadEffect, transform.position, Quaternion.identity);
        Destroy(go, 1);
    }
}
