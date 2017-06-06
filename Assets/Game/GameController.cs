using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameSparks.RT;

public class GameController : MonoBehaviour {

	private static GameController instance;

	public static GameController Instance(){
		return instance;
	}

	public GameObject[] tankprefabs;
	public GameObject shellPrefabRef;
	private Tank[] playerTanksList;
	public Tank[] GetAllTanks(){
		return playerTanksList;
	}

	public Text[] playerKillsUHUDList, playerNamesHUDList;

	private static Shell[] shellPool = new Shell[16];

	public static Shell[] GetShellPool(){
		return shellPool;
	}

	void Awake() {
		instance = this;
	}

	/// <summary>
	/// Updates the opponent tank's position, rotation, and if they have been reset
	/// </summary>
	/// <param name="_packet">Packet Received From Opponent Player</param>
	public void UpdateOpponentTanks(RTPacket _packet){

	}
	/// <summary>
	/// Instantiates the opponent shells with the id of the opponent
	/// </summary>
	/// <param name="_packet">Packet Received From Opponent Player</param>
	public void InstantiateOpponentShells(RTPacket _packet){

	}
	/// <summary>
	/// Updates the opponent shell's rotation and position
	/// </summary>
	/// <param name="_packet">Packet Received From Opponent Player</param>
	public void UpdateOpponentShells(RTPacket _packet){

	}
	/// <summary>
	/// This is called when an opponent has registered a collision.
	/// It will remove the shell that hit, reset the opponent's tank, and update the
	/// score of the owner of the shell that hit.
	/// </summary>
	/// <param name="_packet">Packet Received From Opponent Player</param>
	public void RegisterOpponentCollision(RTPacket _packet){

	}
	/// <summary>
	/// This method is called when a player disconnects from the RT session
	/// </summary>
	/// <param name="_peerId">Peer Id of the player who disconnected</param>
	public void OnOpponentDisconnected(int _peerId){

	}

	void Start(){
		Transform shellPoolObj = GameObject.Find ("Shell Pool").transform;

		for (int i = 0; i < shellPool.Length; i++) {
			GameObject newShell = Instantiate (shellPrefabRef, Vector2.zero, Quaternion.identity) as GameObject;
			newShell.gameObject.SetActive (false);
			newShell.transform.SetParent (shellPoolObj);
			shellPool [i] = newShell.GetComponent<Shell> ();
		}
	}
}
