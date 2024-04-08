using System;

namespace LegacyApp;

public class UserCreditServiceAdapter : IUserCreditService
{
    private UserCreditService _userCreditService;

    public UserCreditServiceAdapter()
    {
        _userCreditService = new UserCreditService();
    }

    public int GetCreditLimit(string lastName, DateTime birthDate)
    {
        return _userCreditService.GetCreditLimit(lastName, birthDate);
    }
}