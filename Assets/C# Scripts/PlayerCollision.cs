using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public Movements movement;
    public obstacleMover _obstacleMover;
    public SpriteRenderer playerColor;
    public ParticleSystem ps;
    public float m_red = 0f;
    public float m_green = 0f;
    public float m_blue = 0f;

    void Start() {
        playerColor = GetComponent<SpriteRenderer>();
        ps = GetComponent<ParticleSystem>();
        
        
    }


    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.tag == "Obstacles")
        {
            var psCol = ps.colorOverLifetime;
            psCol.enabled = true;
            Gradient grad = new Gradient();
            grad.SetKeys(
                new GradientColorKey[] {
                    new GradientColorKey(Color.black, 0.0f), new GradientColorKey(Color.gray, 1.0f)},
                new GradientAlphaKey[] {
                    new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f)}
                );

            playerColor.color = Color.grey;
            psCol.color = grad;
            ParticleSystem particles = GetComponent<ParticleSystem>();
            Debug.Log("Collided with obstacles");
            movement.enabled = false;
            _obstacleMover.enabled = false;
            // particles.Stop();
            FindObjectOfType<GameManager>().endGame();
        }
    }

    // void ChangeColorObstacles(){
    //     if (collision.collider.tag == "Obstacles")
    //     {
    //         Debug.Log("Collided with obstacles");
    //         movement.enabled = false;
    //         FindObjectOfType<GameManager>().endGame();
    //     }
    // }
}
