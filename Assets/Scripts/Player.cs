using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 방향 * 시간 * 스피드
        float distanceX = Input.GetAxisRaw("Horizontal") * Time.deltaTime * moveSpeed;
        transform.Translate(distanceX, 0, 0);
    }
}
