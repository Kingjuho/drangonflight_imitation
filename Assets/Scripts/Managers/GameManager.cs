using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // 싱글톤
    public static GameManager instance;

    // 스코어
    int _score = 0;
    public Text scoreText;

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
    }

    public void Addscore(int amount)
    {
        _score += amount;
        scoreText.text = $"Score : {_score}";
    }
}