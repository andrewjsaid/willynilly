using System;

namespace WillyNilly
{
    public class RecordSetVariable : IRandomVariable<string[]>
    {
        private readonly string[] _members;

        public RecordSetVariable(string[] members)
        {
            _members = members ?? throw new ArgumentNullException(nameof(members));
        }

        public string[] Sample()
        {
            var record = _members[RandomPool.NextInt(0, _members.Length)];
            var result = record.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            result = Array.ConvertAll(result, s => s.Trim());
            return result;
        }
    }
}
