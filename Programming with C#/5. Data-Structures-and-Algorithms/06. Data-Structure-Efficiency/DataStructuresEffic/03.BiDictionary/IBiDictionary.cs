﻿namespace DataStructuresEfficiency
{
    using System.Collections.Generic;

    public interface IBiDictionary<K1, K2, V>
    {
        int Count { get; }

        ICollection<IKeyValueTuple<K1, K2, V>> Value { get; }

        void Add(K1 key1, K2 key2, V value);

        ICollection<V> GetByFirstKey(K1 key1);

        ICollection<V> GetBySecondKey(K2 key2);

        ICollection<V> GetByTwoKeys(K1 key1, K2 key2);

        void RemoveByFirstKey(K1 key1);

        void RemoveBySecondKey(K2 key2);

        void RemoveByTwoKeys(K1 key1, K2 key2);

        void Clear();
    }
}
