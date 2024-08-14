User user1 = new User("Adam");
User user2 = new User("Monika");
User user3 = new User("Zuzia");
User user4 = new User("Damian");

// User1.login = "Adam";

class User
{
    private string login;
    private string password;
    private string name;

    public User(string login)
    {
        this.login = login;

    }
}

