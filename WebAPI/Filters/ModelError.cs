using System.Collections.Generic;

namespace WebAPI.Filters
{
    public class ModelError
    {
        public string Type { get; }
        public IEnumerable<string> Errors { get; }

        public ModelError(string type, IEnumerable<string> errors)
        {
            Type = type;
            Errors = errors;
        }
    }
}
