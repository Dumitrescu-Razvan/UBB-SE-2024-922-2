using ProfessionalProfile.Domain;

namespace ProfessionalProfile.Interfaces
{
    public interface IBussinssCardRepo
    {
        public BussinesCard GetById(int id);
        public ICollection<BussinesCard> GetAll();
        public void Add(BussinesCard item);
        public void Update(BussinesCard item);
        public void Delete(int id);
    }
}
