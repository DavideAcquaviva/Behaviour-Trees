﻿using Derrixx.BehaviourTrees.Runtime.BlackboardScripts.BlackboardProperties;
using Derrixx.BehaviourTrees.Runtime.Nodes;
using UnityEngine;

namespace DefaultNamespace
{
	public class RotateTowardsNode : ActionNode
	{
		[SerializeField] private ObjectBlackboardProperty _target;

		public override string GetDescription() => $"Rotate towards {(_target != null ? _target.Key : "Target")}";

		protected override State OnUpdate() => State.Running;
	}
}