using Godot;

public class SpriteHelper 
{
    public static int GetZIndex(Sprite sprite) {
        return (int) (sprite.Position.y + (sprite.Texture.GetHeight() / 2)) / 140;
    }

    public static int GetZIndexV2(Sprite sprite) {
        TileMap tileMap = (TileMap) sprite.GetNode("%TileMap");
        Vector2 mapPos = tileMap.WorldToMap(new Vector2(sprite.Position.x, sprite.Position.y + (sprite.Texture.GetHeight() / 2)));
        return (int) mapPos.y + 10;
    }

    private void setBrightness(float brightValue, Sprite sprite) {
        float hue, saturation, value;
        sprite.Modulate.ToHsv(out hue, out saturation, out value);
        float brightness = value * brightValue;
        Color newColor = Color.FromHsv(hue, saturation, brightness, sprite.Modulate.a);
        sprite.Modulate = newColor;
    }
}
