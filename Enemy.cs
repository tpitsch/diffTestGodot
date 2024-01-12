using Godot;
using System;

public partial class Enemy : Area2D
{
	public int health {get;set;}
	
	[Signal]
	public delegate void HealthDepletedEventHandler();
	[Signal]
	public delegate void HealthChangedEventHandler(int val);
	
	public override void _Ready()
	{
		this.health = 10;
		EmitSignal(SignalName.HealthChanged,this.health);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
	private void _on_input_event(Node viewport, InputEvent @event, long shape_idx)
	{
		if(Input.IsActionPressed("click")){
			this.health--;
			EmitSignal(SignalName.HealthChanged,this.health);
		}
		
		if(this.health <= 0){
			EmitSignal(SignalName.HealthDepleted);
		}
	}
}



