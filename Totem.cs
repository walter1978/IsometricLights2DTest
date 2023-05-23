using Godot;

public class Totem : Sprite
{
  public override void _Ready()
  {
    ZIndex = SpriteHelper.GetZIndex(this);
  }
}
