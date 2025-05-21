using System;

namespace CloudBackup {
    public class ProgressReport {
        public string Title { get; set; }
        public string Message { get; set; }
        
        public State State { get; set; }
        public float Percentage { get; set; }

        public Exception Exception { get; set; }

        public static ProgressReport Error => new ProgressReport(string.Empty, string.Empty, 0) {
            State = State.ExceptionThrown
        };

        public ProgressReport(string title, string message, float percentage) { 
            Title = title;
            Message = message;

            State = State.NotStarted;
            Percentage = percentage;
        }

        public static ProgressReport FromError(Exception e) {
            ProgressReport output = Error;
            output.Exception = e;

            return output;
        }
    }
}
