using UnityEngine;

public static class VectorExtensions
{

    public static Vector2 SetX(this Vector2 vector, float x) => new Vector2(x, vector.y);
    
    public static Vector2 SetY(this Vector2 vector, float y) => new Vector2(vector.x, y);
    
    public static Vector2 AddX(this Vector2 vector, float x) => new Vector2(vector.x + x, vector.y);
    
    public static Vector2 AddY(this Vector2 vector, float y) => new Vector2(vector.x, vector.y + y);


    public static Vector3 SetX(this Vector3 vector, float x) => new Vector3(x, vector.y, vector.z);
    
    public static Vector3 SetY(this Vector3 vector, float y) => new Vector3(vector.x, y, vector.z);
    
    public static Vector3 SetZ(this Vector3 vector, float z) => new Vector3(vector.x, vector.y, z);
    
    public static Vector3 AddX(this Vector3 vector, float x) => new Vector3(vector.x + x, vector.y, vector.z);

    public static Vector3 AddY(this Vector3 vector, float y) => new Vector3(vector.x, vector.y + y, vector.z);
    
    public static Vector3 AddZ(this Vector3 vector, float z) => new Vector3(vector.x, vector.y, vector.z + z);
    

}
