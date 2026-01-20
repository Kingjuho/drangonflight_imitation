using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;   // 미사일 프리펩

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // InvokeRepeating("함수 이름", 초기 지연 시간, 지연할 시간)
        InvokeRepeating("Shoot", 0.15f, 0.15f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        // 사운드 재생
        SoundManager.instance.Bullet();
        // 미사일 프리팹 생성
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}