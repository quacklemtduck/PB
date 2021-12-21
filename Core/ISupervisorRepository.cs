namespace PB.Core
{
    public interface ISupervisorRepository
    {
        Task<SupervisorDetailsDTO> CreateAsync(SuperVisorCreateDTO supervisor);
        Task<Option<SupervisorDetailsDTO>> ReadAsync(string supervisorId);
        Task<IReadOnlyCollection<SupervisorDetailsDTO>> ReadAllAsync();
        Task<Response> UpdateAsync(string id, SupervisorUpdateDTO supervisor);
        Task<Response> DeleteAsync(string id);
    }
}