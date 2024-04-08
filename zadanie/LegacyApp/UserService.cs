using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

/*
 * Poza UserService:
 * zmiana typu klienta ze stringa na enum
 * usunięcie HasCreditLimit, zamiast tego CreditLimit jest nullable
 * GetById jest teraz statyczne
 */

namespace LegacyApp
{
    public interface IClientRepository
    {
        Client GetById(int idClient);
    }
    public interface IUserCreditService
    {
        //Client GetById(int idClient);
        int GetCreditLimit(string lastName, DateTime birthDate);
    }
    public class UserService
    {
        private IUserCreditService _userCreditService;
        private IClientRepository _clientRepository;

        public UserService(IUserCreditService ucs, IClientRepository cr)
        {
            _userCreditService = ucs;
            _clientRepository = cr;
        }

        /*
        [Obsolete]
        public UserService()
        {
            _userCreditService = new UserCreditService();
            _clientRepository = new ClientRepository();
        }*/
        
        [Obsolete]
        public UserService() : this(new UserCreditServiceAdapter(), new ClientRepositoryAdapter())
        {
            
        }
        
        private User user = new User();
        private UserCreditService userCreditService = new UserCreditService();
        public bool AddUser(string firstName, string lastName, string email, DateTime dateOfBirth, int clientId)
        {
            bool validated = validate(firstName, lastName, email, dateOfBirth);
            if (!validated) { return false; }
            
            var client = _clientRepository.GetById(clientId);

            user.Client = client;
            user.DateOfBirth = dateOfBirth;
            user.EmailAddress = email;
            user.FirstName = firstName;
            user.LastName = lastName;
            
            user.CreditLimit = setClientLimits(client.Type);
            
            UserDataAccess.AddUser(user);
            return true;
        }

        public bool validate(string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                return false;
            }
            
            //string emailFormat = @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z]+$";
            //string emailFormat = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            //if (Regex.IsMatch(email, emailFormat))
            
            if (!email.Contains("@") && !email.Contains("."))
            {
                return false;
            }
            
            var now = DateTime.Now;
            int age = now.Year - dateOfBirth.Year;
            if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day)) age--;

            if (age < 21)
            {
                return false;
            }

            return true;
        }

        public int? setClientLimits(Client.ClientType ct)
        {
            if (ct == Client.ClientType.VeryImportantClient)
            {
                return null;
            }
            else if (ct == Client.ClientType.ImportantClient)
            {

                    int creditLimit = _userCreditService.GetCreditLimit(user.LastName, user.DateOfBirth);
                    creditLimit = creditLimit * 2;
                    user.CreditLimit = creditLimit;
            }
            else
            {
                    //IUSERCREDITSERVICE
                    int creditLimit = _userCreditService.GetCreditLimit(user.LastName, user.DateOfBirth);
                    user.CreditLimit = creditLimit;
            }

            return null;
        }
        
    }
}
