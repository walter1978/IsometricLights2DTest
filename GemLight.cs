using Godot;
using System;

public class GemLight : Light2D
{
    private static readonly float MIN_ENERGY = 0.6f;
    private static readonly float MAX_ENERGY = 1.3f;
    private static readonly float CHANGE_AMOUNT = 0.1f;
    private Random random = new Random();
    private Boolean decreasing = true;

    public override void _Ready()
    {
        Energy = (float) (random.Next(Convert.ToInt32(MIN_ENERGY * 10), Convert.ToInt32(MAX_ENERGY * 10))) / 10;
    }

    public override void _Process(float delta)
    {
        if (decreasing)
        {
            Energy -= CHANGE_AMOUNT * delta * 4;
            if (Energy <= MIN_ENERGY)
            {
                Energy = MIN_ENERGY;
                decreasing = false;
            }
        }
        else 
        {
            Energy += CHANGE_AMOUNT * delta * 4;
            if (Energy >= MAX_ENERGY)
            {
                Energy = MAX_ENERGY;
                decreasing = true;
            }
        }
    }
}