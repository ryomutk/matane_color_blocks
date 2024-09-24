using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Block : MonoBehaviour
{
    [SerializeField] SpriteRenderer _frame;
    [SerializeField] SpriteRenderer _block;

    public Vector3Int normalizedRGB
    {
        get
        {
            return Vector3Int.RoundToInt(new Vector3(
                _block.color.r,
                _block.color.g,
                _block.color.b
            ));
        }
    }

    public Color frameColor
    {
        get
        {
            return _frame.color;
        }

        private set
        {
            _frame.color = value;
        }
    }

    public Color blockColor
    {
        get
        {
            return _block.color;
        }

        private set
        {
            _block.color = value;
        }
    }


    Vector2 position;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Ball")
        {
            Ball ball = collision.transform.GetComponent<Ball>();
            if(ball.hasColor)
            {
                SetColor(ball.color);
            }
        }
    }

    void SetColor(Color color)
    {
        _block.DOColor(color, 0.5f);
    } 
}
