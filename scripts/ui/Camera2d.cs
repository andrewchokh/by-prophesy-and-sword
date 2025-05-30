using Godot;
using System;

public partial class Camera2d : Camera2D
{
	public override void _Ready()
	{
		RenderingServer.SetDefaultClearColor(Color.FromHtml("313638"));
	}
}
