using System.Collections.Generic;

namespace BlazorMdc
{
    public interface IMdcIcon
    {
        public string Class { get; }

        public string Text { get; }

        public IDictionary<string, object> Attributes { get; }

        public string IconName { get; }

        public bool RequiresWhiteFilter { get; }
    }
}
