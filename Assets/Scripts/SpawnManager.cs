using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject SpawnPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // InvokeRepeating("함수 이름", 초기 지연 시간, 지연할 시간)
        InvokeRepeating("Spawn", 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Spawn()
    {
        Vector3 random = new Vector3(Random.Range(-2, 3), 0, 0);
        Instantiate(SpawnPrefab, transform.position + random, Quaternion.identity);
    }
}