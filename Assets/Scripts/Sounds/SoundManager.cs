using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // 싱글톤
    public static SoundManager instance;

    // 오디오 소스
    AudioSource _audioSource;

    // 오디오 클립
    public AudioClip soundBullet;
    public AudioClip soundDead;

    void Awake()
    {
        // 유일성 보장
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;

        // 파괴 방지
        DontDestroyOnLoad(gameObject);

        // 내 객체의 오디오소스 컴포넌트 가져오기
        _audioSource = GetComponent<AudioSource>();
    }

    public void Bullet() { _audioSource.PlayOneShot(soundBullet); }
    public void Dead() { _audioSource.PlayOneShot(soundDead); }
}
