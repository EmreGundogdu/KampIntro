using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 2000, FirstName = "Emre", LastName = "Gündoğdu", IdentityNumber = 12345 });
        }
    }
}
