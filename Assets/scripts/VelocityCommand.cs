﻿using UnityEngine;
using System.Collections;

public class VelocityCommand : Command {

	public const float multiplier = 300;
	public Vector3 velocity;

	public VelocityCommand() : base("VELOCITY") {

	}

	public override void generate(){
		velocity = new Vector3(Random.Range(-multiplier * rigidbody.mass, multiplier * rigidbody.mass), 0, Random.Range(-multiplier * rigidbody.mass, multiplier * rigidbody.mass));
	}

	public override void execute(NodeScript script){
		generate();
		rigidbody.AddForce(velocity);
		script.next();
	}

}
