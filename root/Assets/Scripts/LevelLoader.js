#pragma strict

public static var levelCount: int;
private var num : int;

num = Random.Range(1,4);

function LoadFirstLevel() {
	Application.LoadLevel("Prototype");
}
function ExitGame() {
	Application.Quit();
}