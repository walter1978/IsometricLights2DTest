using Godot;

public class GemEllipticalPath : Sprite
{
    private Vector2 centerPoint = new Vector2(1180, 620);
    private float semiMajorAxis = 610f;
    private float semiMinorAxis = 410f;
    private float speed = 1;

    private float angle = 0f;

    public override void _Process(float delta)
    {
        ZIndex = SpriteHelper.GetZIndex(this);

        angle += speed * delta;
        float x = centerPoint.x + semiMajorAxis * Mathf.Cos(angle);
        float y = centerPoint.y + semiMinorAxis * Mathf.Sin(angle);
        Position = new Vector2(x, y);
    }
}
