#pragma strict
enum States{ START, GAME, PAUSE, END };
public var currentStates : States = States.START;
/*
	case Start:
		Starts the game, first state, this state happens if the player quits the level, dies and doesnt 
		want to play again.
		this state has opition for game opitions, starting game, and quiting
	case Game:
		Loads the starting level then lets the level manager take override
	case Pause:
		Pauses Game lets you change opitions or quit
	case Death:
		If player is dead pull up this state which has a quit or replay
*/
function Start () {
	
}

function Update () {
	
	switch(currentStates) {
	case currentStates.START:
		Debug.Log("Start");
		break;
	case currentStates.GAME:
		break;
	case currentStates.PAUSE:
		break;
	case currentStates.END:
		break;
	}
}
