using UnityEngine;

public class GameController : MonoBehaviour {
    private void Start() {
        var contexts = new Contexts();

        var e = contexts.game.CreateEntity();
    }
}