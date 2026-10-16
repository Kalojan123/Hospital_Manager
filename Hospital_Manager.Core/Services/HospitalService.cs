using Data_Hospital_Manager;
using Data_Hospital_Manager.Entities;
using Hospital_Manager.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Manager.Core.Services
{
    public class HospitalService : IHospitalService
    {
        private readonly HospitalDbContext context_new;
        public HospitalService(HospitalDbContext context)
        {
            context_new = context;
        }
        public async Task<List<Hospital>> GetAllHospitalsAsync()
        {
            return await context_new.Hospitals.Where(h => !h.IsDeleted).ToListAsync();
        }
        public async Task<Hospital?> GetHospitalByIdAsync(int id)
        {
            return await context_new.Hospitals.FindAsync(id);
        }
        public async Task AddHospitalAsync(Hospital hospital)
        {
            context_new.Hospitals.Add(hospital);
            await context_new.SaveChangesAsync();
        }
        public async Task UpdateHospitalAsync(Hospital hospital)
        {
            await context_new.SaveChangesAsync();
        }
        public async Task DeleteHospitalAsync(int id)
        {
            var hospital = await context_new.Hospitals.FindAsync(id);
            if (hospital != null)
            {
                hospital.IsDeleted = true;
                await context_new.SaveChangesAsync();
            }
        }
    }
}
