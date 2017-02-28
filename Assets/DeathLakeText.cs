using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DeathLakeText : MonoBehaviour {

	public Text text;
	private enum States {boat, note, engine_01, blanket, oars, key, engine_02, paddle, sleep, continue_paddling,
						death_01, death_02, death_03, death_04, death_05, look_overboard, oar_weapon, beach,  
						dock, inspect, picture, boathouse, story_01, story_02};
	private States myState;						

	// Use this for initialization
	void Start () {
		myState = States.boat;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.boat) {
			state_boat();
		} else if (myState == States.oars) {
			state_oars();
		} else if (myState == States.engine_01) {
			state_engine_01();
		} else if (myState == States.note) {
			state_note();
		} else if (myState == States.blanket) {
			state_blanket();
		} else if (myState == States.paddle) {
			state_paddle();
		} else if (myState == States.sleep) {
			state_sleep();
		} else if (myState == States.death_01) {
			state_death_01();
		} else if (myState == States.continue_paddling) {
			state_continue_paddling();
		} else if (myState == States.look_overboard) {
			state_look_overboard();
		} else if (myState == States.death_02) {
			state_death_02();
		} else if (myState == States.death_03) {
			state_death_03();
		} else if (myState == States.key) {
			state_key();
		} else if (myState == States.engine_02) {
			state_engine_02();
		} else if (myState == States.beach) {
			state_beach();
		} else if (myState == States.death_04) {
			state_death_04();
		} else if (myState == States.inspect) {
			state_inspect();
		} else if (myState == States.death_05) {
			state_death_05();
		}
		
	}
	
	void state_boat() {
		text.text = "You have a pounding headache and find yourself in a small fishing boat on a lake. Unsure how" +
					" you got here, you're scared beyond belief, but need to figure out a way back to shore." +
					" It's extremely foggy, however you look around and find a few items: a pair of oars, a small 5cc engine," +
					" a blanket that looks covered in blood, and an envelope containing a note.\n" +
					"- Press O to use the Oars, E to use the Engine, B to look under the Blanket, or N to read the Note.";
					
		if (Input.GetKeyDown(KeyCode.O)) {
			myState = States.oars;
		} else if (Input.GetKeyDown(KeyCode.E)) {
			myState = States.engine_01;
		} else if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.blanket;
		} else if (Input.GetKeyDown(KeyCode.N)) {
			myState = States.note;
		}
	}
	
	void state_oars() {
		text.text = "You pick up the oars and are desperate to get to safety. However, they are extremely" +
					" heavy and you aren't sure you have the strength to paddle all the way to shore. You have" +
					" to decide if you're going to paddle for shore or return to looking around the boat.\n" +
					"- Press P to begin Paddling or R to Return to looking around the boat";
					
		if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.paddle;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.boat;
		}
	}
	
	void state_engine_01() {
		text.text = "You attempt to get the engine started by yanking on the pull cord over and over but" +
					" nothing happens. Frustrated, you kick it a few times but then notice that it requires" +
					" a key. \"It must be around here somewhere\"\n" +
					"- Press R to continue looking around the boat for that key!";
					
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.boat;
		}
	}
	
	void state_note() {
		text.text = "You open the envelope to find a poorly written note. It says \"I'm so sorry I did this" +
					" to you, but every year a sacrifice must be made, I would do anything to protect my family." +
					" I hope you understand that... I will pray you can escape before it finds you! JS\"\n" +
					"You are now terrified and determined to find a way to escape.\n" +
					"- Press R to look around the boat for a way outta here!!";
		
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.boat;
		}
	}
	
	void state_blanket() {
		text.text = "You grab the edge of the blanket and pull it back to find a rotting deer carcass. It's" +
					" covered in flies and smells horrendous. Attached to one of its hooves you see a string and" +
					" pull on it to discover a small key. You must decide if the key will work in the boat" +
					" engine or if's a trap.\n" +
					"- Press R to leave the key alone and Return to looking around the boat or K to try the" +
					" Key out in the boat engine.";
		
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.boat;
		} else if (Input.GetKeyDown(KeyCode.K)) {
			myState = States.key;
		}
	}
	
	void state_paddle() {
		text.text = "You decide to push onward and are paddling with all your might. Your head is throbbing" +
					" still and your starting to become disoriented. It might be in your best interest to" +
					" get some sleep to build up some strength. However, you may just be desperate to get" +
					" to shore and decide to continue paddling.\n" +
					"- Press S to get some Sleep or C to Continue Paddling.";
		
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sleep;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.continue_paddling;
		}
	}
	
	void state_sleep() {
		text.text = "You curl up in a ball determined to get some sleep and continue towards the shoreline once" +
					" you've regained some strength. You drift out peacefully and get some much needed sleep." + 
					" Suddenly you are awoken by something grabbing your leg. You wake up and............\n" +
					"- Press SPACE BAR to continue on";
		
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.death_01;
		}
	}
	
	void state_death_01() {
		text.text = "The giant sea monster has caught you by surprise and grabbed you by the leg with one of its" +
					" giant tentacles. You wake up just in time to see its giant teeth bite your head off!\n\n" +
					"THE LAKE MONSTER HAS KILLED YOU. GAME OVER!!";			
	}
	
	void state_continue_paddling() {
		text.text = "Your persistence to continue paddling is paying off and you finally reach a break in the" +
					" fog and you can see the beach is only about 1000 feet away. You are overjoyed to almost be" +
					" to shore when all of a sudden the boat comes to a stop. You hear some splashing around the" +
					" boat and frozen with fear. Do you look overboard to see what you're stuck on or grab the oar" +
					" to use as a weapon if need be?\n" +
					"- Press L to Look Overboard or W to use the oar as a Weapon";
		
		if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.look_overboard;
		} else if (Input.GetKeyDown(KeyCode.W)) {
			myState = States.oar_weapon;
		}
	}
	
	void state_look_overboard() {
		text.text = "As you look overboard to figure out what you're stuck on you see......\n\n" +
					"- Press SPACE BAR to continue";
		
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.death_02;
		}
	}
	
	void state_oar_weapon() {
		text.text = "You pick up the oar ready to fight anything that might come out from underneath the boat. Just" +
					" then you see multiple tentacles come up on all sides of the boat, flailing all around you. As" +
					" you lift up the oar to swing at it you realize your muscles are beyond spent from excessive" +
					" paddling you've done. You muster up just enough strength to swing it once and......\n" +
					"- Press SPACE BAR to continue";
		
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.death_03;
		}
	}
	
	void state_death_02() {
		text.text = "A giant squid-like creature grabs you by the neck as you peer over the edge and pulls you." +
					" into the water. It begins to dive deeper into the abyss crushing your windpipe along the way." +
					" It gets darker and darker and you realize this is the......end.\n\n" +
					"THE LAKE MONSTER HAS KILLED YOU. GAME OVER!!";			
	}
	
	void state_death_03() {
		text.text = "The oar breaks across the tentacle, causing blood to spray all over. This just infuriates the" +
					" creature and it grabs you by the waist and violently slams you down on the edge of the boat." +
					" Instantly you feel you back break and your body goes limp. You pass out from the pain......\n\n" +
					"THE LAKE MONSTER HAS KILLED YOU. GAME OVER!!";			
	}
	
	void state_key() {
		text.text = "You take the key and crawl over to the engine, excited that this might help you get away faster." +
					" Just then a feeling of doubt comes over you. \"What if I put this key in and the engine explodes?\"" +
					" Now unsure of what to do you must make a decision. Put the key in the engine and hope it works or" +
					" trust your instincts that this is a trap and grab the oars to start paddling ashore" +
					"- Press E to start the Engine with the key or O to pick up the oars.";
					
		
		if (Input.GetKeyDown(KeyCode.O)) {
			myState = States.oars;
		} else if (Input.GetKeyDown(KeyCode.E)) {
			myState = States.engine_02;
		}
	}
	
	void state_engine_02() {
		text.text = "You put the key in and nothing happens. You are relieved it didn't explode and you give the pull cord" +
					" a couple of tugs and the engine some roaring to life. You realize the fog has lifted and as you sit" +
					" down to steer towards shore you happen to catch the outline of a giant sea creature circling the boat." +
					" Petrified, you realize you must make a decision and FAST! Do you speed towards the beach? Maybe the" +
					" dock instead? Instead you could inspect the waters and see if it's safe... What do you choose?\n" +
					"- Press B for the Beach, D for the Dock, or I to Inspect the waters around you";
		
		if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.beach;
		} else if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.dock;
		} else if (Input.GetKeyDown(KeyCode.I)) {
			myState = States.inspect;
		} 
	}

	void state_beach() {
		text.text = "The beach looks like it's closest so you start zooming towards it. The creature doesn't appear to" +
					" be anywhere in sight. You are almost there when all of a sudden a bunch of tentacles come shooting" +
					" up out of the water. You try to speed up to escape when the engine is ripped from the boat. The" +
					" damage to the boat causes it to begin to sink when......\n" +
					"- Press SPACE BAR to continue";
		
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.death_04;
		}
	}

	void state_death_04() {
		text.text = "The creature surfaces. You can see its hideousness in all its glory. Giant teeth, each bigger than" +
					" your entire body. You desperately try to swim away but to no avail. It is slowly reeling you in" +
					" with its tentacles, seemingly toying with you. Then with one sudden motion......." +
					"you disappear \n\n" +
					"THE LAKE MONSTER HAS KILLED YOU. GAME OVER!!";			
	}
	
	void state_inspect() {
		text.text = "You decide to inspect the waters to see if its safe to continue forward. You move around the boat" +
					" looking in every direction and seeing absolutely nothing. Out of nowhere, a strong gust of wind" +
					" knocks you onto your back. As you attempt to stand back up, you look down and see a large crack" +
					" forming across the bottom of the boat. Then.........\n" +
					"- Press SPACE BAR to continue";
		
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.death_05;
		}
	}
	
	void state_death_05() {
		text.text = "With one fell swoop the sea monster breaks the boat in half and drags it twoards the bottom." +
					" It hasn't grabbed you but the force of the singking boat is dragging you down with it" +
					" As your air runs out and you drown the last thing you see is the monster swimming back up" +
					" to finish you off.\n\n" +
					"THE LAKE MONSTER HAS KILLED YOU. GAME OVER!!";			
	}
}

