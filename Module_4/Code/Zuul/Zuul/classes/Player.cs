class Player
{ 
    // auto property
    public Room CurrentRoom { get; set; }

    // Fields
    private int health;

    // constructor
    public Player()
    {
        CurrentRoom = null;

        health = 100;
    }

    
}
