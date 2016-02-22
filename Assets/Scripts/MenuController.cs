using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

	public SkinnedMeshRenderer[] bodyArray;

	public Color purple;
	public SkinnedMeshRenderer headRenderer;
	public Mesh[] headMeshArray;
	private int headMeshIndex = 0;

	public SkinnedMeshRenderer handRenderer;
	public Mesh[] handMeshArray;
	private int handMeshIndex = 0;


	public void OnHeadMeshNext()
	{
		headMeshIndex++;
		headMeshIndex %= headMeshArray.Length;
		headRenderer.sharedMesh = headMeshArray[headMeshIndex];
	}
	public void OnHandMeshNext()
	{
		handMeshIndex++;
		handMeshIndex %= handMeshArray.Length;
		handRenderer.sharedMesh = handMeshArray[handMeshIndex];
	}
	public void OnChangeColorBlue()
	{
		OnChangeColor(Color.blue);
	}
	public void OnChangeColorCyan()
	{
		OnChangeColor(Color.cyan);
	}
	public void OnChangeColorGreen()
	{
		OnChangeColor(Color.green);
	}
	public void OnChangeColorPurple()
	{
		OnChangeColor(purple);
	}
	public void OnChangeColorRed()
	{
		OnChangeColor(Color.red);
	}
	public void OnPlay()
	{
		
	}

	void OnChangeColor(Color c)
	{
		foreach(SkinnedMeshRenderer renderer in bodyArray)
		{
			renderer.material.color = c;
		}
	}
}
