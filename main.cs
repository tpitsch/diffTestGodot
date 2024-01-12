using Godot;
using System;

public partial class main : Node2D
{
	//I am a comment
	int clickCount = 0;	
	Enemy badGuy;
	
	public override void _Ready()
	{
		this.badGuy = GetNode<Enemy>("Enemy");
		this.Start();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
	public void Start() {
		var startPos = GetNode<Node2D>("EnemyPos");
		this.badGuy.Position = startPos.Position;
		}
	private void _on_enemy_health_depleted()
	{
		this.badGuy.QueueFree();
	}
	
}





