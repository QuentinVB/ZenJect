using UnityEngine;

public interface IPathfinding
{
    Vector3 Direction { get; }
    Quaternion Orientation { get; }
}