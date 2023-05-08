//void Start() {} method gets called once at start of game
//void Update(){} method called once per frame

class Enemy:MonoBehaviour {
    public static int numberOfEnemiesAlive = 0;
    int instanceExample = 0;
    bool canSeePlayer = false;

    void Start() {
        numberOfEnemiesAlive + 1;
        instanceExample = instanceExample + 1;
    }

    void Update() {
        //set canSeePlayer to true if enemy is within certain distance
        if (canSeePlayer) {

        }
    }

}

//we put a class in a file each
//static classes do not copy into instances
// public classes can be pulled from other locations
static class Maths{
    public static float pi = 3.141592653f;


    public static float SquareRoot(float n) {
        float result = 0;
        //calculate sqrt of n and store result in variable
        return result;

    }
}
//so if we want to link to this ^^^ method from another location
//we can do the following vvv
class OtherClass : MonoBehaviour { 
    void RandomMethod() {
    float x = Maths.pi;
    }
}