using Godot;
using System;

public partial class Sprite2D_script : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		float AMOUNT = 15;
		if (Input.IsKeyPressed(Key.Z)){
			this.Position += new Vector2(0, -AMOUNT);
		}
		if (Input.IsKeyPressed(Key.S)){
			this.Position += new Vector2(0, AMOUNT);
		}
		if (Input.IsKeyPressed(Key.Q)){
			this.Position += new Vector2(-AMOUNT, 0);
		}
		if (Input.IsKeyPressed(Key.D)){
			this.Position += new Vector2(AMOUNT, 0);
		}
	}
}
