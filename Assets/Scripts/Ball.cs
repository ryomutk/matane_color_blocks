using UnityEngine;

public class Ball:MonoBehaviour
{
    [SerializeField] SpriteRenderer ball;
    bool _hasColor = false;

    public bool hasColor
    {
        get
        {
            return _hasColor;
        }
    }

    public Vector3Int normalizedRGB
    {
        get
        {
            return Vector3Int.RoundToInt(new Vector3(
                ball.color.r,
                ball.color.g,
                ball.color.b
            ));
        }
    }

    public Color color
    {
        get
        {
            return ball.color;
        }
    }

    public void SetColor(Color color)
    {
        ball.color = color;
    }

    public void Init()
    {
        _hasColor = true;
        ball.color = new Color(0,0,0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Block")
        {
            Block block = collision.transform.GetComponent<Block>();

            if(hasColor)
            {
                if(block.normalizedRGB == normalizedRGB)
                {
                    
                }
            }
        }
    }
}