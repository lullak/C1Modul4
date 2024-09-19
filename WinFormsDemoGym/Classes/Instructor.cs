using WinFormsDemoGym.Interfaces;

namespace WinFormsDemoGym.Classes
{
    public class Instructor : Person, IMaintainable<Instructor>
    {
        public int InstructorNo { get; set; }

        public void Delete(Instructor obj)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Instructor obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Instructor obj)
        {
            throw new NotImplementedException();
        }
    }
}
