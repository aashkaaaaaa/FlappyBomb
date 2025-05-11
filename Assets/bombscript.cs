using UnityEngine;

public class bombscript : MonoBehaviour
{
    public Rigidbody2D myrigidbody2D;
    public float flapStrenght;
    public logicScript logic;
    bool isalive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isalive)
        {

            myrigidbody2D.linearVelocity = Vector2.up * flapStrenght;

        }
        if (transform.position.y > 17 || transform.position.x > 17 || transform.position.y < -17 || transform.position.x < -17)
        {
            logic.gameOver();
        }

     }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision with: " + collision.gameObject.name);
        logic.gameOver();
        isalive = false;

    }
    

}
