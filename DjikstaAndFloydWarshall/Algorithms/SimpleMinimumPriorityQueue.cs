using System.Collections.Generic;

namespace DjikstaAndFloydWarshall
{
    public class SimpleMinimumPriorityQueue
    {
        private readonly List<(int index, int distance)> _values;

        public bool IsEmpty => _values.Count == 0;

        public SimpleMinimumPriorityQueue()
        {
            _values = new List<(int index, int distance)>();
        }

        public (int index, int distance) ExtractMin()
        {
            var minAt = 0;
            var min = _values[minAt];
            
            for (int i = 1; i < _values.Count; i++)
            {
                if (_values[i].distance < min.distance)
                {
                    min = _values[i];
                    minAt = i;
                }
            }

            _values.RemoveAt(minAt);
            return min;
        }

        public void UpdatePriority((int index, int distance) node)
        {
            var indexOf = _values.FindIndex(v => v.index == node.index);

            if (indexOf == -1)
            {
                _values.Add(node);
                return;
            }

            _values[indexOf] = node;
        }
    }
}
