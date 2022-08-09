namespace _2ND_Backend_Exam.DATA.DAL.Repositories
{
    public class MaterialTypeRepository : Repository<MaterialType>, IMaterialTypeRepository
    {
        public MaterialTypeRepository(EduContext context) : base(context) { }

        public new async Task<IEnumerable<MaterialType>> GetAllAsync()
            => await _entity.Include(type=>type.EduMaterials).ToListAsync();

        public async Task<MaterialType> GetByIdAsync(int id)
            => await _entity.Include(type => type.EduMaterials).SingleOrDefaultAsync(type => type.Id == id);
    }
}
