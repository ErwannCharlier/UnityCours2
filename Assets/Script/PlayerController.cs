using UnityEngine;

public class TestPlayerController : MonoBehaviour
{
    public float moveSpeed = 2f;   // vitesse horizontale
    public float jumpSpeed = 7f;   // vitesse verticale quand on saute

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        // Déplacement gauche/droite
        Vector2 v = rb.velocity;
        v.x = horizontal * moveSpeed;

        // Saut (pas de check au sol pour le test)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            v.y = jumpSpeed;
        }

        rb.velocity = v;
    }
}
