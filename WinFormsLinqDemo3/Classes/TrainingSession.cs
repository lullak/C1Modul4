namespace WinFormsLinqDemo3.Classes
{
    public class TrainingSession
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Instructor Trainer { get; set; }
        public TrainingSessionType Type { get; set; }

        public static List<TrainingSession> Search(string condition, string type, DateTime startTime, DateTime endTime)
        {
            var result = new List<TrainingSession>();

            if (type == "Instruktör")
            {
                result = (from session in Repository.GetTrainingSessionData()
                          where session.Trainer.Name.Contains(condition)
                          && session.StartTime >= startTime
                          && session.EndTime >= endTime
                          select session).ToList();
            }
            else
            {
                result = (from session in Repository.GetTrainingSessionData()
                          where session.Type.Name.Contains(condition)
                          && session.StartTime >= startTime
                          && session.EndTime <= endTime
                          select session).ToList();
            }
            return result;
        }
    }
}
