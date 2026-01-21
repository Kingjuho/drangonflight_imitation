using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // 싱글톤
    public static GameManager instance;

    // 스코어
    int _score = 0;
    public Text scoreText;

    // 스타트
    public Text startText;
    Coroutine startCoroutine;

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

        // 스타트 텍스트
        startCoroutine = StartCoroutine(BlinkText(0.5f));
        StartCoroutine(Countdown(3));
    }

    // 스코어 추가
    public void Addscore(int amount)
    {
        _score += amount;
        scoreText.text = $"Score : {_score}";

        // 난이도 변경
        if (_score > 1000) SceneManager.LoadScene(1);
    }

    // 텍스트 깜빡임
    IEnumerator BlinkText(float interval)
    {
        while (true)
        {
            if (startText != null) startText.enabled = !startText.enabled;
            yield return new WaitForSeconds(interval);
        }
    }

    // 카운트다운 표시
    IEnumerator Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            startText.text = $"CountDown : {i}";
            yield return new WaitForSeconds(1f);
        }

        startText.text = "Go!";

        yield return new WaitForSeconds(1f);

        StopCoroutine(startCoroutine);
        startText.enabled = false;
    }
}