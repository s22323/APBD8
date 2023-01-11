using APBD8.DTOs;

namespace APBD8.Services
{
    public interface IClinicDbService
    {
        Task<IEnumerable<DoctorDTO>> GetDoctorsAsync();
        Task AddDoctorAsync(DoctorDTO doctorDTO);
        Task ChangeDoctorAsync(int id, DoctorDTO doctorDTO);
        Task DeleteDoctorAsync(int id);
        Task<PrescriptionDTO> GetPrescription(int id);
    }
}
