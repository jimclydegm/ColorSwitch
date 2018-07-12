using UnityEngine;

public class Player : MonoBehaviour {

    public float jumpForce = 10f;

    public Rigidbody2D rb;
    public SpriteRenderer sr;

    public string currenColor;

    public Color cyan;
    public Color yellow;
    public Color pink;
    public Color magenta;

    void Start()
    {
        SetRandomColor();    
    }

    // Update is called once per frame
    void Update () {

        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "ColorChanger")
        {
            Debug.Log("Color change");
            SetRandomColor();
            Destroy(collision.gameObject);
            return;
        }

        if(collision.tag != currenColor)
        {
            Debug.Log("Game over");
        }
    }

    void SetRandomColor()
    {
        int index = Random.Range(1, 4);

        switch(index)
        {
            case 0:
                currenColor = "Cyan";
                sr.color = cyan;
                break;
            case 1:
                currenColor = "Yellow";
                sr.color = yellow;
                break;
            case 2:
                currenColor = "Pink";
                sr.color = pink;
                break;
            case 3:
                currenColor = "Magenta";
                sr.color = magenta;
                break;
            default:
                break;
        }
    }
}