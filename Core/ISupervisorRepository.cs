namespace PB.Core
{

    public interface ISupervisorRepository
    {

        Task<SupervisorDetailsDTO> CreateAsync(SuperVisorCreateDTO supervisor);
        Task<SupervisorDetailsDTO> ReadAsync(int supervisorId);
        Task<IReadOnlyCollection<SupervisorDetailsDTO>> ReadAllAsync();
        Task<Response> UpdateAsync(int id, SupervisorUpdateDTO supervisor);
    }
}