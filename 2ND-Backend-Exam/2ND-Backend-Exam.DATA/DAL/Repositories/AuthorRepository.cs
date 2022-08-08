﻿namespace _2ND_Backend_Exam.DATA.DAL.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(EduContext context): base(context) { }

        public async Task<Author> GetByIdAsync(int id)
            => await _entity.SingleOrDefaultAsync(x => x.Id == id);

        public async Task<EduMaterial> GetMaterialByIdAsync(int eduMaterialId)
            => await _context.EduMaterials.SingleOrDefaultAsync(x => x.Id == eduMaterialId);
    }
}