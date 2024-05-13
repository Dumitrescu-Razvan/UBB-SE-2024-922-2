using ProfessionalProfile.Domain;

namespace ProfessionalProfile.Interfaces
{
    public interface IAssesmentResultRepo
    {
        public AssessmentResult GetById(int id);
        public ICollection<AssessmentResult> GetAll();
        public void Add(AssessmentResult item);
        public void Update(AssessmentResult item);
        public void Delete(int id);
        public ICollection<AssessmentResult> GetAssessmentResultsByUserId(int userId);
    }
}
