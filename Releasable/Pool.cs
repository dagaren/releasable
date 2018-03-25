// <copyright file="Pool.cs" company="David Garcinuño Enríquez">
// Copyright (c) David Garcinuño Enríquez. All rights reserved.
// </copyright>

namespace Dagaren.Releasable
{
    using System;
    using System.Collections.Generic;

    public class Pool<T> : IPool<T>
    {
        private readonly Queue<T> elements;

        private readonly Func<T> generator;

        public Pool(Func<T> generator)
        {
            this.elements = new Queue<T>();

            this.generator = generator ?? throw new ArgumentNullException(nameof(generator));
        }

        public int NumElements
        {
            get
            {
                return this.elements.Count;
            }
        }

        public T Get()
        {
            if (this.elements.Count > 0)
            {
                return this.elements.Dequeue();
            }
            else
            {
                return this.generator();
            }
        }

        public void Return(T obj)
        {
            this.elements.Enqueue(obj);
        }
    }
}
