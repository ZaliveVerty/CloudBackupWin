using System;

namespace CloudServiceProvider.GoogleDrive {
    public readonly struct Output<TValue> {
        public TValue Value { get; }
        public Certainty Certainty { get; }

        public Output(TValue value, Certainty certainty) {
            Value = value;
            Certainty = certainty;
        }
    }
}
