using System;

namespace CloudServiceProvider {
    public class ByteProgressReport : CloudProgressReport {
        public long BytesSeen { get; set; }

        public static ByteProgressReport Error => new ByteProgressReport(RequestStatus.OtherError, 0);

        public ByteProgressReport(RequestStatus status, long bytesSeen) : base(status) {
            BytesSeen = bytesSeen;
        }

        public static ByteProgressReport FromError(Exception e, RequestStatus error = RequestStatus.OtherError) {
            return new ByteProgressReport(error, 0) { 
                Exception = e
            };
        }
    }
}
