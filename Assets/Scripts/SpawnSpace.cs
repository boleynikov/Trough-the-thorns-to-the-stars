using UnityEngine;
using UnityEditor;
public class SpawnSpace : MonoBehaviour
{
    public float speed = 4f;
    public GameObject space;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < -10.2f)
        {
            Instantiate(space, new Vector3(0, 17f, 20f), Quaternion.identity);            
            Destroy(gameObject);
        }
    }
}
