﻿namespace _2ND_Backend_Exam.DATA.DAL.Interfaces
{
    public interface IEduMaterialRepository : IRepository<EduMaterial>
    {
        public Task<EduMaterial> GetByIdAsync(int id);
    }
}