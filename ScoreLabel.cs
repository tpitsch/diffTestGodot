using Godot;
using System;

public partial class ScoreLabel : Label
{
	int val;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//Editing script to post chaanges to github
		//label label for labels
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
	private void _on_enemy_health_changed(long val)
	{
		Text = $"HP: {val}";
		if (val < 1) Text = "AAAAHHH IM DED!!!";
	}
}






