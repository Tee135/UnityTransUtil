using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TransUtility
{
	public static Vector3 UpdateConcentricMove( Vector3 currentPosition, Vector3 centralPosition, Vector3 axis, float, radius, float degreePerSecond )
	{
		Vector3 moveVec = (currentPosition - centralPosition).Normalized() * radius;
		moveVec = Quaternion.AngleAxis( degreePerSecond * Time.deltaTime, axis ) * moveVec;

		Vector3 movedPos = (centralPosition + moveVec) - currentPosition;

		return (movedPos - currentPosition);
	}
}
