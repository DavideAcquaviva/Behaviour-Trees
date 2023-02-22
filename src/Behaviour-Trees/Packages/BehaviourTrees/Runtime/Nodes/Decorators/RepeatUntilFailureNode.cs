﻿namespace Derrixx.BehaviourTrees.Runtime.Nodes
{
	public class RepeatUntilFailureNode : DecoratorNode
	{
		protected override State OnEvaluate(BehaviourTreeRunner runner)
		{
			return Child.Evaluate(runner) == State.Failure ? State.Success : State.Running;
		}
	}
}