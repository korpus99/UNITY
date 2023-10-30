using UnityEngine;
public class zadanie5 : MonoBehaviour
{
    // Instantiates prefabs in a circle formation
    public GameObject prefab;
    public int numberOfObjects = 10;
    public float radius = 3f;
    void Start()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            Vector3 pos = transform.position + new Vector3(i * 10, 0, i + 5);
            Instantiate(prefab, pos, Quaternion.identity);
        }
    }
}