using UnityEngine;

public class PipeMover : MonoBehaviour
{
    public float speed = 2f;
    public int rotacion;

    private void Start()
    {
       
        transform.Rotate(rotacion, 0, 0);
    }

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        
        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}