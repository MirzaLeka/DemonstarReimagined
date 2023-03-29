using EntityFrameworkCoreData;
using EntityFrameworkCoreDomain;
using System.Collections.Generic;

namespace ConsoleAppEF2;

class AuthorisedPerson
{
    public string ClientID { get; set; }
    public string ClientName { get; set; }    
    public string JMBG { get; set; }
}

class Program
{
    private int age { get; set; } = 34;
    private readonly Dictionary<string, List<AuthorisedPerson>> _authorisedPeople = new ();
    private static readonly string[] _accountIDs =
    {
        "1",
        "2",
        "3"
    };

	static void Main(string[] args)
    {
        var p = new Program();
        p.InsertAccount(_accountIDs[0], "1111", "Mirza", "000000");
		p.InsertAccount(_accountIDs[2], "2222", "Armin", "000000");
		p.InsertAccount(_accountIDs[0], "3333", "Dzeno", "000000");
		p.InsertAccount(_accountIDs[1], "4444", "Branko", "000000");

		p._authorisedPeople.TryGetValue(_accountIDs[0], out List<AuthorisedPerson> authorisedPeople1);
		p._authorisedPeople.TryGetValue(_accountIDs[1], out List<AuthorisedPerson> authorisedPeople2);
		p._authorisedPeople.TryGetValue(_accountIDs[2], out List<AuthorisedPerson> authorisedPeople3);

        var people1 = authorisedPeople1;
        var people2 = authorisedPeople2;
        var people3 = authorisedPeople3;

		Console.ReadLine();
    }

    private void InsertAccount(string accountID, string clientID, string clientName, string jmbg)
    {
        if (_authorisedPeople.ContainsKey(accountID))
        {
            Console.WriteLine("hello");
            _authorisedPeople[accountID].Add(CreateAuthorisedPoeple(clientID, clientName, jmbg));

		} else
        {
            Console.WriteLine("world");
            _authorisedPeople.Add(accountID, new List<AuthorisedPerson>
            {
                CreateAuthorisedPoeple(clientID, clientName, jmbg)
            });

		}
    }

    private AuthorisedPerson CreateAuthorisedPoeple(string clientID, string customerName, string jmbg)
    {
        return new AuthorisedPerson
        {
            ClientID = clientID,
            ClientName = customerName,
            JMBG = jmbg
        };
    }
}
