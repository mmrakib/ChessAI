using UnityEngine;

public class Chessboard : MonoBehaviour
{
    private static Texture2D texture;
    private static Sprite sprite;

    public void Awake()
    {
        texture = Texture2D.whiteTexture;
        sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));

        if (sprite == null)
        {
            Debug.LogError("Failed to create square sprite.");
        }
    }

    public void Start()
    {
        DrawSquare(new Vector2(0, 0), Color.red);
    }

    public void DrawSquare(Vector2 position, Color color, float scaleFactor = 25)
    {
        GameObject obj = new("Square");
        SpriteRenderer renderer = obj.AddComponent<SpriteRenderer>();
        
        renderer.sprite = sprite;
        renderer.color = color;
        obj.transform.position = (Vector3) position;
        obj.transform.localScale = new Vector3(scaleFactor, scaleFactor, 0);

        obj.transform.parent = transform;
    }
}
