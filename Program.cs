using WelcomeApp;

Console.WriteLine("Welcome to Authentication App");
SignIn obj = new SignIn();
Console.WriteLine(obj.Authenticate("admin", "admin@12345"));