using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 2;
    private Rigidbody2D componentRigidbody;
    // Start is called before the first frame update
    private void Start()
    {
        componentRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        componentRigidbody.velocity = Vector2.zero;
        if (Input.GetKey(KeyCode.LeftArrow)) componentRigidbody.velocity += Vector2.left * speed;
        if (Input.GetKey(KeyCode.RightArrow)) componentRigidbody.velocity += Vector2.right * speed;
        if (Input.GetKey(KeyCode.UpArrow)) componentRigidbody.velocity += Vector2.up * speed;
        if (Input.GetKey(KeyCode.DownArrow)) componentRigidbody.velocity += Vector2.down * speed;
    }

    
}
