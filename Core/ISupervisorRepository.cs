namespace Core;

public interface ISupervisorRepository
{
    Task<SupervisorDetailsDTO> CreateAsync(SuperVisorCreateDTO supervisor);
    Task<SupervisorDetailsDTO> ReadAsync(int supervisorId);
    Task<IReadOnlyCollection<SupervisorDetailsDTO>> ReadAsync();
    Task<Status> UpdateAsync(int id, SupervisorUpdateDTO supervisor);
}