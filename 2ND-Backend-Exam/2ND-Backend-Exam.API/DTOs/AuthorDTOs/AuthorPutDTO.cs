namespace _2ND_Backend_Exam.API.DTOs.AuthorDTOs
{
    public class AuthorPutDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public IEnumerable<int>? MaterialsIds { get; set; }
    }
}
