using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SRP
{
    public class Booking
    {
        private readonly List<Participant> _participants;

        public Booking()
        {
            _participants = new List<Participant>();
        }

        public void AddParticipant(Participant participant) => _participants.Add(participant);

        public void RemoveEntryAt(int index) => _participants.RemoveAt(index);

        public void SaveToFile(string directoryPath, string fileName)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), ToString());
        }

        public void SaveToCloud(string provider, string fileName)
        {
            throw new NotImplementedException();
        }

        public override string ToString() =>
            string.Join(Environment.NewLine, _participants.Select(x => $"Name: {x.Name}"));
    }
}
