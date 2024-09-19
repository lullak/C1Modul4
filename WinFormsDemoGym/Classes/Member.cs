using WinFormsDemoGym.Interfaces;

namespace WinFormsDemoGym.Classes
{
    public class Member : Person, IMaintainable<Member>
    {
        public int MemberNo { get; set; }

        public void Delete(Member obj)
        {
            throw new NotImplementedException();
        }

        public List<Member> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Member obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Member obj)
        {
            throw new NotImplementedException();
        }
    }
}
