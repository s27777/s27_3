namespace LegacyApp;

public class ClientRepositoryAdapter : IClientRepository
{
    private ClientRepository _clientRepository;

    public ClientRepositoryAdapter()
    {
        _clientRepository = new ClientRepository();
    }

    public Client GetById(int idClient)
    {
        return _clientRepository.GetById(idClient);
    }
}