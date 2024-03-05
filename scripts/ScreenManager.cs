using Godot;
using System;

public partial class ScreenManager : Node
{

	public string ActiveScreen 
	{
		get
		{
			return activeScreen;
		}
		set
		{
			SetActive(activeScreen, false);
			activeScreen = value;
			SetActive(activeScreen, true);
		}
	}
	private string activeScreen;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		ActiveScreen = "Main Menu";
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	void SetActive(string screen, bool state)
	{
		CanvasItem node = FindChild(screen) as CanvasItem;
		if (node != null)
		{
			node.SetProcess(state);
			node.Visible = state;
		}
	}

	// Signals

	public void _on_exit_button_pressed()
	{
		GetTree().Quit();
	}

	public void _on_novice_level_pressed()
	{
		ActiveScreen = "Novice";
	}

	public void _on_intermediate_level_pressed()
	{
		ActiveScreen = "Intermediate";
	}

	public void _on_advanced_level_pressed()
	{
		ActiveScreen = "Advanced";
	}

	public void _on_back_to_menu_pressed()
	{
		ActiveScreen = "Main Menu";
	}
}
