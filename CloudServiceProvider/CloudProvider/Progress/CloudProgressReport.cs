using System;

namespace CloudServiceProvider {
    public class CloudProgressReport {
        public RequestStatus Status { get; set; }
        public Exception Exception { get; set; }

        public CloudProgressReport(RequestStatus status) { 
            Status = status;
        }
    }
}
