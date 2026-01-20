using UnityEngine;

public class Background : MonoBehaviour
{
    public float scrollSpeed = 0.25f;
    private Material myMaterial;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        // 오프셋을 머터리얼에서 가져온 후 offset 변경
        Vector2 newOffset = myMaterial.mainTextureOffset;
        newOffset.Set(0, newOffset.y + scrollSpeed * Time.deltaTime); // 프레임 보정 필수
        myMaterial.mainTextureOffset = newOffset;
    }
}