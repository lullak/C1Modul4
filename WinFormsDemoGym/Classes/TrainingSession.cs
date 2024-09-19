using WinFormsDemoGym.Interfaces;

namespace WinFormsDemoGym.Classes
{
    public class TrainingSession : IMaintainable<TrainingSession>
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Instructor Instructor { get; set; }
        public List<Member> Participants { get; set; }

        public void Delete(TrainingSession obj)
        {
            throw new NotImplementedException();
        }

        public List<TrainingSession> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(TrainingSession obj)
        {
            throw new NotImplementedException();
        }

        public void Update(TrainingSession obj)
        {
            throw new NotImplementedException();
        }
    }
}
